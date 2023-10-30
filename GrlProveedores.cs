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

        private void btnModificarGrilla_Click(object sender, EventArgs e)
        {
            //En la variable n guardo el indice de la fila seleccionada en la grilla
            int n = dataGridView1.CurrentCell.RowIndex;

            CargarProveedores CargarProveedores = new CargarProveedores();

            //El ReadOnly solo deja ver el contenido del txt no deja que se modifique
            CargarProveedores.txtNum.ReadOnly = true;
            //Cargo todos los txt del formulario ABM para que solo modifique lo que quiera, sin tener que cargar todo de nuevo
            CargarProveedores.txtNum.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            CargarProveedores.txtEntidad.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            CargarProveedores.txtApertura.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            CargarProveedores.txtExp.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            CargarProveedores.txtJuzg.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            CargarProveedores.txtJurisdicción.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            CargarProveedores.txtDirección.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();
            CargarProveedores.txtLiquidador.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();

            string ID = Convert.ToString(dataGridView1.Rows[n].Cells[0].Value);

            CargarProveedores.BtnModificar.Visible = true;
            CargarProveedores.btnGrabar.Visible = false;
            CargarProveedores.ruta = rutaArchivoGrilla;
            CargarProveedores.Show();
            this.Hide();
        }

        private void btnBorrarGrilla_Click(object sender, EventArgs e)
        {
            //n es el número de fila seleccionado en la grilla
            int n = dataGridView1.CurrentCell.RowIndex;

            if (n != -1)
            {
                //ID es el número de la celda 0 de la fila seleccionada 
                string ID = Convert.ToString(dataGridView1.Rows[n].Cells[0].Value);

                //Es una lista que funciona igual que un vector pero tiene métodos propios
                List<string> lineasArchivo = new List<string>();

                using (StreamReader reader = new StreamReader(rutaArchivoGrilla))
                {

                    // Lee el resto de las líneas
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Procesa la línea actual aquí y separo los campos con ";"
                        string[] parametros = linea.Split(';');
                        //Copia todas las lineas que no coincide con el ID para sobreescribir el archivo sin la linea que quiero borrar
                        if (parametros[0] != ID)
                        {
                            lineasArchivo.Add(linea);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(rutaArchivoGrilla))
                {
                    foreach (string elemento in lineasArchivo)
                    {
                        // Escribe cada elemento en una línea del archivo, el elemento contiene la línea guardada en el índice momentáneo de la lista
                        writer.WriteLine(elemento);
                    }
                }

                MessageBox.Show("El registro fue eliminado correctamente.");

                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores VarAtrás = new Proveedores();
            VarAtrás.Show();    
        }
    }
}
