using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Productos : Form
    {
        Entidades.Producto producto = new Entidades.Producto();
        Logica.ServicioProducto servicioProducto = new Logica.ServicioProducto();
        int row = -1;
        public Productos()
        {
            InitializeComponent();
            RefreshLista();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void RefreshLista()
        {
            grillaListaProductos.DataSource = servicioProducto.GetAll();
        }
        void Limpiar()
        {
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxValorVenta.Text = "";
            textBoxDescripcion.Text = "";
        }
        void Llenar(Entidades.Producto producto)
        {
            textBoxCodigo.Text = producto.Codigo.ToString();
            textBoxNombre.Text = producto.Nombre;
            textBoxValorVenta.Text = producto.ValorVenta.ToString();
            textBoxDescripcion.Text = producto.Descripcion;
        }
        void Guardar()
        {
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxValorVenta.Text == "")
            {
                MessageBox.Show("Llene todos los campos, por favor");
            }
            else
            {
                if (row == -1)
                {
                    producto.Codigo = int.Parse(textBoxCodigo.Text);
                    producto.Nombre = textBoxNombre.Text;
                    producto.Descripcion = textBoxDescripcion.Text;
                    producto.ValorVenta = double.Parse(textBoxValorVenta.Text);
                    var Respuesta = MessageBox.Show("Desea guardar el producto?", "Responde...", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        var mensaje = servicioProducto.Guardar(producto);
                        MessageBox.Show(mensaje);
                        Limpiar();
                        RefreshLista();
                    }
                }
                else
                {
                    var Respuesta = MessageBox.Show("Desea modificar el producto?", "Responde...", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        producto.Codigo = int.Parse(textBoxCodigo.Text);
                        producto.Nombre = textBoxNombre.Text;
                        producto.Descripcion = textBoxDescripcion.Text;
                        producto.ValorVenta = double.Parse(textBoxValorVenta.Text);
                        //var mensaje = servicioProducto.Edit(producto, row);
                        //MessageBox.Show(mensaje);
                        textBoxCodigo.Focus();
                        RefreshLista();
                    }
                        
                    Limpiar();
                    row = -1;
                }
                mostraretiqueta.Checked = false;
            }
        }
        void Eliminar()
        {
            if (row != -1)
            {
                var Respuesta = MessageBox.Show("Desea borrar el producto?", "Responde...", MessageBoxButtons.YesNo);
                if (Respuesta == DialogResult.Yes)
                {
            //        var mensaje = servicioProducto.Delete(row);
          //          MessageBox.Show(mensaje);
                    RefreshLista();
                }
                Limpiar();
                row = -1;
                mostraretiqueta.Checked = false;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.PowderBlue;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpiar();
            RefreshLista();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            textBoxCodigo.Focus();
        }

        private void Productos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxValorVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxDescripcion.Focus();
            }
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxNombre.Focus();
            }
        }

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxNombre.Focus();
            }
        }

        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxCodigo.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBoxValorVenta.Focus();
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxValorVenta.Focus();
            }
        }

        private void textBoxValorVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxNombre.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBoxDescripcion.Focus();
            }
        }

        private void textBoxDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxValorVenta.Focus();
            }
        }

        private void textBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void grillaListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        //    Llenar(servicioProducto.GetAll()[row]);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void grillaListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
      //      Llenar(servicioProducto.GetAll()[row]);
        }

        private void btnGenerarCodigoBarras_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text.Trim() == "")
            {
                msgError("Por favor, ingrese el codigo");
            }
            else
            {
                try
                {
                    TYPE TipoCodigo = TYPE.CODE128;
                    BarcodeLib.Barcode code = new BarcodeLib.Barcode();
                    code.IncludeLabel = mostraretiqueta.Checked;
                    var imagen = code.Encode(TipoCodigo, textBoxCodigo.Text.Trim(), Color.Black, Color.White, 400, 100);

                    Byte[] barcode = ImageToByte2(imagen);

                    SaveFileDialog save = new SaveFileDialog();
                    save.FileName = string.Format("{0}.png", textBoxCodigo.Text.Trim());
                    save.Filter = "Imagen|*.png";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(save.FileName, barcode);
                        MessageBox.Show("Codigo generado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ep)
                {
                    MessageBox.Show(string.Format("Lo sentimos, no se pudo generar el codigo :(. \nMayor informacion:\n{0}, ", ep.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information));
                }
                labelError.Visible = false;
            }
        }
        private void msgError(string msg)
        {
            labelError.Text = "    " + msg;
            labelError.Visible = true;
        }
        public static byte[] ImageToByte2(Image image)
        {
            using (var sr = new MemoryStream())
            {
                image.Save(sr, System.Drawing.Imaging.ImageFormat.Png);
                return sr.ToArray();
            }
        }
    }
}
