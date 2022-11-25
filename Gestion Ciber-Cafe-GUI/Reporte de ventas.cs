using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;


namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Reporte_de_ventas : Form
    {

        Logica.ServicioHistorial servicioHistorial = new Logica.ServicioHistorial();
        List<ReporteVentas> reporteVentas = new List<ReporteVentas>();
        public Reporte_de_ventas()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Reporte_de_ventas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GrillaReportes.Rows.Clear();
            DateTime Fechainicio = Convert.ToDateTime(fechainicial.Value.ToString("dd/MM/yyyy"));
            DateTime Fechafin = Convert.ToDateTime(Fechafinal.Value.ToString("dd/MM/yyyy"));
            reporteVentas = servicioHistorial.reporteVentas(Fechainicio.ToString("yyyy-MM-dd"), Fechafin.ToString("yyyy-MM-dd"));
            foreach (ReporteVentas item in reporteVentas)
            {
                GrillaReportes.Rows.Add(new object[]
                {
                    item.FechaRegistro,
                    item.DocumentoCliente,
                    item.NombreCliente,
                    item.NombreProducto,
                    item.CodigoProducto,
                    item.DescripcionProducto,
                    item.Cantidad,
                    item.PrecioVenta,
                    item.SubTotal,
                    item.MonTotal,
                });
            }
        }

        private void Reporte_de_ventas_MouseDown(object sender, MouseEventArgs e)
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
