using NPOI.SS.Formula.Functions;
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
    public partial class ListarProductos : Form
    {
        int p = -1;
        Logica.ServicioProducto servicioProducto = new Logica.ServicioProducto();
        public int codigo_ { get; set; }
        public string descripcion_ { get; set; }
        public int stock_ { get; set; }
        public string precioventa_ { get; set; }
        public ListarProductos()
        {
            InitializeComponent();
        }
        void Refres()
        {
            foreach (var item in servicioProducto.GetAll())
            {
                GrillaProductos.Rows.Add(new object[]
                {
                    "",
                    item.Codigo,
                    item.Descripcion,
                    item.Stock = 50,
                    item.ValorVenta = 5000
                    
                }) ;
            }
        }
        private void ListarProductos_Load(object sender, EventArgs e)
        {
            Refres();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GrillaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p = e.RowIndex;
            if (p != -1)
            {
                if (GrillaProductos.Columns[e.ColumnIndex].Name == "seleccionar")
                {
                    codigo_ = Convert.ToInt32(GrillaProductos.Rows[p].Cells["Codigo"].Value.ToString());
                    descripcion_ = GrillaProductos.Rows[p].Cells["Descripcion"].Value.ToString();
                    stock_ = Convert.ToInt32(GrillaProductos.Rows[p].Cells["Stock"].Value.ToString());
                    precioventa_ = GrillaProductos.Rows[p].Cells["PrecioVenta"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
