using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PryCarrenoIE

    
{

    public partial class GrlProveedores : Form
    {
        public GrlProveedores()
        {
            InitializeComponent();
        }
        
        public static string rutaArchivoGrilla { get; set; }

        public string ruta = "";

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }

        private void GrlProveedores_Load(object sender, EventArgs e)
        {

        }
        CargarProveedores frmCargarProveedores = new CargarProveedores();
        //CargarProveedores.txtApertura.ReadOnly = true;

       
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores VarAtrás = new Proveedores();
            VarAtrás.Show();    
        }
    }
}
