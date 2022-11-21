using Entidades;
using Logica;
using NPOI.SS.Formula.Functions;
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
    public partial class Proveedores : Form
    {
        Entidades.Proveedor proveedor = new Entidades.Proveedor();
        Logica.ServicioProveedor servicioProveedor = new Logica.ServicioProveedor();
        int row = -1;
        string Cedula = null;
        public Proveedores()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        void RefreshLista()
        {
            grillaListaProveedores.DataSource = servicioProveedor.GetAll();
        }

        void Limpiar()
        {
            textBoxCedula.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";
            textBoxRazonSocial.Text = "";
            textBoxCedula.Focus();
        }

        void Llenar(Entidades.Proveedor proveedor)
        {
            Cedula = proveedor.Cedula;
            textBoxCedula.Text = proveedor.Cedula;
            textBoxNombre.Text = proveedor.Nombre;
            textBoxTelefono.Text = proveedor.Telefono;
            textBoxRazonSocial.Text = proveedor.RazonSocial;
        }

        void Guardar()
        {
            if (textBoxCedula.Text == "" || textBoxNombre.Text == "" || textBoxTelefono.Text == "")
            {
                msgError("Llene todos los campos, por favor");
            }
            else
            {
                if (row == -1)
                {
                    labelError.Visible = false;
                    proveedor.Cedula = textBoxCedula.Text;
                    proveedor.Nombre = textBoxNombre.Text;
                    proveedor.Telefono = textBoxTelefono.Text;
                    proveedor.RazonSocial = textBoxRazonSocial.Text;
                    var Respuesta = MessageBox.Show("Desea guardar el proveedor?", "Responde...", MessageBoxButtons.YesNo);

                    if (Respuesta == DialogResult.Yes)
                    {
                        var mensaje = servicioProveedor.Guardar(proveedor);
                        MessageBox.Show(mensaje);
                        Limpiar();
                        RefreshLista();
                    }
                }
                else
                {
                    var Respuesta = MessageBox.Show("Desea modificar el proveedor?", "Responde...", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        if (Cedula == textBoxCedula.Text)
                        {
                            Cedula = " ";
                        }
                        labelError.Visible = false;
                        proveedor.Cedula = textBoxCedula.Text;
                        proveedor.Nombre = textBoxNombre.Text;
                        proveedor.Telefono = textBoxTelefono.Text;
                        proveedor.RazonSocial = textBoxRazonSocial.Text;
                        var mensaje = servicioProveedor.Edit(proveedor, row, Cedula);
                        MessageBox.Show(mensaje);
                        RefreshLista();
                    }
                    Limpiar();
                    row = -1;
                }
            }
        }

        void Eliminar()
        {
            if (row != -1)
            {
                var Respuesta = MessageBox.Show("Desea borrar el proveedor?", "Responde...", MessageBoxButtons.YesNo);
                if (Respuesta == DialogResult.Yes)
                {
                    var mensaje = servicioProveedor.Delete(proveedor);
                    MessageBox.Show(mensaje);
                    RefreshLista();
                }
                Limpiar();
                row = -1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void Proveedores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            textBoxCedula.Focus();
            RefreshLista();
        }

        private void msgError(string msg)
        {
            labelError.Text = "    " + msg;
            labelError.Visible = true;
        }

        private void textBoxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxNombre.Focus();
            }
        }

        private void textBoxCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxNombre.Focus();
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxTelefono.Focus();
            }
        }

        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxCedula.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBoxTelefono.Focus();
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxRazonSocial.Focus();
            }
        }

        private void textBoxTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxNombre.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBoxRazonSocial.Focus();
            }
        }

        private void textBoxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void grillaListaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            proveedor = servicioProveedor.GetAll()[row];
            Llenar(proveedor);
        }

        private void grillaListaProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            proveedor = servicioProveedor.GetAll()[row];
            Llenar(proveedor);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void textBoxRazonSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxTelefono.Focus();
            }
        }
    }
}
