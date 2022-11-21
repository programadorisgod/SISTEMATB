using Entidades;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Ventas : Form
    {
        private static int codigoproducto = 0;
        private static int stock_ = 0;
        private static string precioventa_ = string.Empty;

        Logica.ServicioVentas servicioVentas = new Logica.ServicioVentas();
        Logica.ServicioCliente servicioCliente = new Logica.ServicioCliente();
        Entidades.Ventas ventas = new Entidades.Ventas();
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var form = new ListarClietnes())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DocClien.Text = form.Cedulacliente;
                    txtnombreclie.Text = form.NombreCliente;
                }
            }
        }

        private void Btnotro_Click(object sender, EventArgs e)
        {

            if (txtcodigoproducto.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingrese el codigo del producto, para poder agregarlo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Por favor llene la descripcion, para poder agregarlo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (YaExiste())
            {
                MessageBox.Show("Este producto ya se agregó a carrito de compras", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string mensaje = string.Empty;
            //  int realizar = servicioVentas.reducirCantidad(codigoproducto, Convert.ToInt32(txtCantidad.Value.ToString()), out mensaje);
            int realizar = 4;
            decimal subtotal = 0;
            decimal precioventa = 0;
            decimal.TryParse(precioventa_, out precioventa);
            if (realizar > 0)
            {
                subtotal = Convert.ToDecimal(txtCantidad.Value.ToString()) * precioventa;
                GrillaClientes.Rows.Add(new object[]
                {"",
                    txtcodigoproducto.Text,
                    txtDescripcion.Text,
                    txtCantidad.Value.ToString(),
                    precioventa.ToString(),
                    subtotal.ToString()
                });
                CalcularTotalPagar();
            }
            else
            {
                MessageBox.Show("Error", "¡Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void RealizarVenta()
        {
            if (DocClien.Text.Trim() == "")
            {
                MessageBox.Show("Por favor debe seleccionar la cedula del cliente para poder agregarlo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (txtnombreclie.Text.Trim() == "")
            {
                MessageBox.Show("Por favor debe seleccionar el nombre del cliente para poder agregarlo", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int cantidad = 0;
                List<DetalleSalida> detalleSalidas = new List<DetalleSalida>();
                foreach (DataGridViewRow item in GrillaClientes.Rows)
                {
                    detalleSalidas.Add(new DetalleSalida()
                    {
                        CodigoProducto = Convert.ToInt32(item.Cells["Codigo"].Value.ToString()),
                        Descripcion = item.Cells["Descripcion"].Value.ToString(),
                        PrecioVenta = Convert.ToDecimal(item.Cells["Precio"].Value.ToString()),
                        Cantidad = Convert.ToInt32(item.Cells["Cantidads"].Value.ToString()),
                        SubTotal = Convert.ToDecimal(item.Cells["Subtotal"].Value.ToString())

                    });
                    cantidad += Convert.ToInt32(item.Cells["Cantidads"].Value.ToString());
                }
                string mensaje = string.Empty;
                int id_cliente = servicioVentas.BuscarporID(DocClien.Text.ToString());

                ventas.Idcliente = id_cliente;
                ventas.CantidadProductos = cantidad;
                ventas.TotalVenta = Convert.ToDouble(lbltotalF.Text);
                ventas.ListaDetalleSalida = detalleSalidas;

                int realizado = servicioVentas.Insertar(ventas, out mensaje);

                if (realizado < 1)
                {
                    MessageBox.Show(mensaje, "¡Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Venta realizada con exito", "¡Gracias por comprar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                DocClien.Text = "";
                GrillaClientes.Rows.Clear();
                txtnombreclie.Text = "";
                lbltotalF.Text = "";
                DocClien.Focus();
            }
           
        }

        private bool YaExiste()
        {
            bool mensaje = false;
            if (GrillaClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in GrillaClientes.Rows)
                {

                    if (item.Cells["Codigo"].Value.ToString() == codigoproducto.ToString())
                    {
                        mensaje = true;
                        break;
                    }
                }
            }
            return mensaje;
        }


        private void btnventa_Click(object sender, EventArgs e)
        {
            RealizarVenta();
        }
        void CalcularTotalPagar()
        {
            decimal total = 0;
            if (GrillaClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in GrillaClientes.Rows)
                {
                    total += Convert.ToDecimal(item.Cells["SubTotal"].Value.ToString());
                }
            }
            lbltotalF.Text = total.ToString();
        }

        private void GrillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje = string.Empty;
            int p = e.RowIndex;
            if (p != -1)
            {
                if (GrillaClientes.Columns[e.ColumnIndex].Name == "eliminar")
                {
                    int codigo = Convert.ToInt32(GrillaClientes.Rows[p].Cells["Codigo"].Value.ToString());
                    int cantidad = Convert.ToInt32(GrillaClientes.Rows[p].Cells["Cantidads"].Value.ToString());
                    int realizar = servicioVentas.CantidadNormal(codigo, cantidad, out mensaje);

                    if (realizar > 0)
                    {
                        GrillaClientes.Rows.RemoveAt(p);
                        CalcularTotalPagar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void bntBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var form = new ListarProductos())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtcodigoproducto.Text = form.codigo_.ToString();
                    txtDescripcion.Text = form.descripcion_;
                    txtStock.Text = form.stock_.ToString();
                    precioventa_ = form.precioventa_;

                    txtCantidad.Value = 1;
                    txtCantidad.Focus();
                }
            }
        }

        private void txtcodigoproducto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string mensaje = string.Empty;
            if (e.KeyData == Keys.Enter)
            {




            }
        }
    }

}

