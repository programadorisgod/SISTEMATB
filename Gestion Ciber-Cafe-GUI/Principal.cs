using Entidades;
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

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
        private void PersonalizarDiseño()
        {
            SubMenuSalidas.Visible = false;
        }
        private void OcultarSubmenu()
        {
            if (SubMenuSalidas.Visible == true)
            {
                SubMenuSalidas.Visible = false;
            }
        }
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            Entrada detalle = new Entrada();
            detalle.Show();
            OcultarSubmenu();
        }

        private void Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            OcultarSubmenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes  clientes = new Clientes();
            clientes.Show();
            OcultarSubmenu();
        }
        private void VisitLink()
        {
            
            linkLabelPrincipal.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=-AgrqLgXUGo");
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            OcultarSubmenu();
        }

        private void linkLabelPrincipal_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede abrir el enlace en el que se hizo clic.");
            }
        }

        private void linkLabelPrincipal_MouseLeave(object sender, EventArgs e)
        {
            linkLabelPrincipal.LinkColor = Color.DeepSkyBlue;
        }

        private void linkLabelPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            linkLabelPrincipal.LinkColor = Color.Cyan;
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(SubMenuSalidas);
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            OcultarSubmenu();
        }

        private void btnDetalleVentas_Click(object sender, EventArgs e)
        {
            Hitorial_Ventas hitorial_Ventas = new Hitorial_Ventas();
            hitorial_Ventas.Show();
            OcultarSubmenu();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //Codigo...
            OcultarSubmenu();
        }
    }
}
