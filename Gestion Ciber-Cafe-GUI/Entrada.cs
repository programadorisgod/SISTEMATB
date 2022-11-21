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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}
