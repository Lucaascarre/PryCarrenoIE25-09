using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCarrenoIE
{
    public partial class CargarProveedores : Form
    {
        public CargarProveedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
                       
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CargarProveedores VarVolver = new CargarProveedores();
            VarVolver.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
