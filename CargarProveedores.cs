using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        private int valorDelIdDelRegistro;
        private void btnVolver_Click(object sender, EventArgs e)
        {
                       
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPrincipal VarVolver = new PantallaPrincipal();
            VarVolver.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void lblJuzg_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarBaseDeDatos(string nuevoValor)
        {
            // Conectar a la base de datos
            string cadenaConexion = 

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                // Construir la consulta SQL para la actualización
                string consultaSQL = "UPDATE Proveedores SET TuCampo = @NuevoValor WHERE Id = @Id";

                // Crear el comando con los parámetros
                using (OleDbCommand comando = new OleDbCommand(consultaSQL, conexion))
                {
                    comando.Parameters.AddWithValue("@NuevoValor", nuevoValor);
                    comando.Parameters.AddWithValue("@Id", valorDelIdDelRegistro);  // Ajusta según tu caso

                    try
                    {
                        // Abrir la conexión y ejecutar la consulta
                        conexion.Open();
                        comando.ExecuteNonQuery();

                        // Puedes agregar más lógica aquí después de la actualización si es necesario
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción que pueda ocurrir durante la actualización
                        MessageBox.Show("Error al actualizar la base de datos: " + ex.Message);
                    }
                }
            }
        }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
            
                // Obtener los datos modificados desde los TextBox
                string nuevoValor = txtNum.Text; // Ajusta según tus controles

                // Llamar a la función para actualizar la base de datos
                ActualizarBaseDeDatos(nuevoValor);

                // Mostrar un mensaje u otras acciones después de la modificación
                MessageBox.Show("Registro modificado correctamente.");
            

        }
    }
}
