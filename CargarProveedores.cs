using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
        GabarDatos grabarDatos = new GabarDatos();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            grabarDatos.Grabar(txtNum.Text, txtEntidad.Text, txtApertura.Text, txtExp.Text, txtJuzg.Text, txtJurisdicción.Text, txtDirección.Text, txtLiquidador.Text);
            MessageBox.Show("Datos guardados");
            txtNum.Text = "";
            txtEntidad.Text = "";
            txtApertura.Text = "";
            txtExp.Text = "";
            txtJuzg.Text = "";
            txtJurisdicción.Text = "";
            txtDirección.Text = "";
            txtLiquidador.Text = "";

        }
        //private int valorDelIdDelRegistro;
        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPrincipal VarVolver = new PantallaPrincipal();
            VarVolver.Show();
        }

        

        private void lblJuzg_Click(object sender, EventArgs e)
        {

        }



        private void CargarProveedores_Load(object sender, EventArgs e)
        {

        }
        public static string RutaFull;
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string ID = txtNum.Text;
            List<string> LineaArchivo = new List<string>();

            using (StreamReader leer = new StreamReader(RutaFull))
            {
                string line;
                while ((line = leer.ReadLine()) != null)
                {
                    string[] parametros = line.Split(';');
                    if (parametros[0] != ID)
                    {
                        LineaArchivo.Add(line);

                    }
                    else
                    {
                        string nuevaLinea = txtNum.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtExp.Text + ";" + txtJuzg.Text + ";" + txtJurisdicción.Text + ";" + txtDirección.Text + ";" + txtLiquidador.Text;
                        LineaArchivo.Add(nuevaLinea);

                    }
                }
            }
            using (StreamWriter escribir = new StreamWriter(RutaFull))
            {
                foreach (string elemento in LineaArchivo)
                {
                    escribir.WriteLine(elemento);
                }

            }
            MessageBox.Show("Modificado correctamente");
        }
    }
        //private void BtnModificar_Click(object sender, EventArgs e)
        //{
        //    string ID = txtNum.Text;
        //    List<string> LineaArchivo = new List<string>();

        //    // Verifica si RutaFull es nulo, y establece una ruta predeterminada si es necesario
        //    if (RutaFull == null)
        //    {
        //        RutaFull = (@"../../Resources/Proveedores");  // Ajusta esta ruta según tus necesidades
        //    }

        //    using (StreamReader leer = new StreamReader(RutaFull))
        //    {
        //        string line;
        //        while ((line = leer.ReadLine()) != null)
        //        {
        //            string[] parametros = line.Split(';');
        //            if (parametros[0] != ID)
        //            {
        //                LineaArchivo.Add(line);
        //            }
        //            else
        //            {
        //                string nuevaLinea = txtNum.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtExp.Text + ";" + txtJuzg.Text + ";" + txtJurisdicción.Text + ";" + txtDirección.Text + ";" + txtLiquidador.Text;
        //                LineaArchivo.Add(nuevaLinea);
        //            }
        //        }
        //    }

        //    using (StreamWriter escribir = new StreamWriter(RutaFull))
        //    {
        //        foreach (string elemento in LineaArchivo)
        //        {
        //            escribir.WriteLine(elemento);
        //        }
        //    }

        //    MessageBox.Show("Modificado correctamente");
        //}






    }


