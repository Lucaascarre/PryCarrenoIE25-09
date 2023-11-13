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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            
                // Obtén la fila seleccionada en el DataGridView
                DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;

                if (filaSeleccionada != null)
                {
                    // Crea una instancia del formulario de modificación
                    CargarProveedores frmModificacion = new CargarProveedores();

                    // Pasa los datos de la fila seleccionada al formulario de modificación
                    frmModificacion.txtNum.Text = filaSeleccionada.Cells[0].Value.ToString();
                    frmModificacion.txtEntidad.Text = filaSeleccionada.Cells[1].Value.ToString();
                    frmModificacion.txtApertura.Text = filaSeleccionada.Cells[2].Value.ToString();
                    frmModificacion.txtExp.Text = filaSeleccionada.Cells[3].Value.ToString();
                    frmModificacion.txtJuzg.Text = filaSeleccionada.Cells[4].Value.ToString();
                    frmModificacion.txtJurisdicción.Text = filaSeleccionada.Cells[5].Value.ToString();
                    frmModificacion.txtDirección.Text = filaSeleccionada.Cells[6].Value.ToString();
                    frmModificacion.txtLiquidador.Text = filaSeleccionada.Cells[7].Value.ToString();


                // Agrega más líneas según las columnas que tengas en tu DataGridView

                // Muestra el formulario de modificación
                frmModificacion.Show();

                    // Oculta el formulario actual si es necesario
                    this.Hide();
                
                }

        }
    }
}
