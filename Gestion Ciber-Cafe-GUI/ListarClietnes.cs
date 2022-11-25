using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ciber_Cafe_GUI
{
    public partial class ListarClietnes : Form
    {
        public string Cedulacliente { get; set; }
        public string NombreCliente { get; set; }
        int p = -1;
        Logica.ServicioCliente servicioCliente = new Logica.ServicioCliente();
        public ListarClietnes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Permite cargar la grilla.
        /// </summary>

        void Refres()
        {
            foreach (var item in servicioCliente.GetAll())
            {
                GrillaClientes.Rows.Add("", item.Cedula, item.Nombre);
            }
        }

        private void ListarClietnes_Load(object sender, EventArgs e)
        {
            Refres();
        }

        /// <summary>
        ///  asigna los valores que se encuentran en la grilla, a las variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p = e.RowIndex;
            if (p != -1)
            {
                Cedulacliente = GrillaClientes.Rows[p].Cells["Cedula"].Value.ToString();
                NombreCliente = GrillaClientes.Rows[p].Cells["Nombre"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
