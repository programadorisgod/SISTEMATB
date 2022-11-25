using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Hitorial_Ventas : Form
    {
        Entidades.Ventas ventas = new Entidades.Ventas();
        Logica.ServicioHistorial servicioHistorial = new Logica.ServicioHistorial();
        List<DetalleSalida> detalleSalidas = new List<DetalleSalida>();
        Logica.ServiciosAdministrador administrador = new Logica.ServiciosAdministrador();
        int contador = 0;
        public Hitorial_Ventas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Hitorial_Ventas_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Permite realizar la busqueda de la venta realizada en X fecha seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Calendario.Value > DateTime.Now)
            {
                MessageBox.Show("Por favor, ingrese una fecha valida", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Por favor, ingrese la cedula del cliente", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime fecha = Convert.ToDateTime(Calendario.Value.ToString("dd/MM/yyyy"));
                ventas = servicioHistorial.Obtener(fecha.ToString("yyyy-MM-dd"), txtCedula.Text);

                if (ventas != null)
                {
                    Fechaventa.Text = ventas.FechaRegistro;
                    DocClien.Text = ventas.CedulaCliente;
                    txtnombreclie.Text = ventas.NombreCliente;

                    detalleSalidas = servicioHistorial.salidas(ventas.IdVenta);
                    grillaHistorial.Rows.Clear();
                    foreach (var item in detalleSalidas)
                    {
                        grillaHistorial.Rows.Add(new object[] { item.CodigoProducto, item.Nombreproducto, item.Cantidad, item.SubTotal });
                    }
                    lbltotalF.Text = ventas.TotalVenta.ToString();
                }
                else
                {
                    MessageBox.Show("No hay resultados realacionados", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }


        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Permite generar un documento en formato PDF con el uso del nuget XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnimprimir_Click(object sender, EventArgs e)
        {

            if (txtCedula.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cedula", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtnombreclie.Text == "")
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente ", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            contador++;
            string paginahtml = Properties.Resources.PlatillaPdf.ToString();
            Administrador admin = administrador.Obtener();
            paginahtml = paginahtml.Replace("@Administrador", admin.Nombre.ToString());
            paginahtml = paginahtml.Replace("@DOCUMENTO", admin.Cedula.ToString());
            paginahtml = paginahtml.Replace("@Cliente", txtnombreclie.Text);
            paginahtml = paginahtml.Replace("@DOCCLIENTE", txtCedula.Text);
            paginahtml = paginahtml.Replace("@fecharegistro", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml = paginahtml.Replace("@numero", contador.ToString());
            string filas = string.Empty;
            foreach (DataGridViewRow row in grillaHistorial.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Codigo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nomp"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            paginahtml = paginahtml.Replace("@filas", filas);
            paginahtml = paginahtml.Replace("@montototal", lbltotalF.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    // pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Stacked_Red_Boxes_35541, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader streamReader = new StringReader(paginahtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdfDoc, streamReader);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("El documento, se ha descargado exitosamente", "Querido usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Hitorial_Ventas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
