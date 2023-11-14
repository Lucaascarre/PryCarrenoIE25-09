using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace PryCarrenoIE
{
    internal class clsElClub
    {
        OleDbConnection conexionBD;
        OleDbCommand comandBD;
        OleDbDataReader LeerBD;
        public string EstadoConexion;
        public string DatosTabla;

        public void ConectarBD()
        {
            try
            {
                string rutaArchivo = @"../../Resources/El Club/EL_CLUB.accsdb";
                string Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = Conexion;
                conexionBD.Open();
                EstadoConexion = "Conectado";
            }
            catch (Exception EX)

            {
                EstadoConexion = "Error:" + EX.Message;
            }
        }



        public void TraerDatos(DataGridView Grilla)
        {
            try
            {
                string EstadoCliente = "";

                using (OleDbCommand comandBD = new OleDbCommand("SELECT * FROM SOCIOS", conexionBD))
                {
                    using (OleDbDataReader LeerBD = comandBD.ExecuteReader())
                    {
                        Grilla.Columns.Add("Nombre", "Nombre");
                        Grilla.Columns.Add("Apellido", "Apellido");
                        Grilla.Columns.Add("Lugar Nacimiento", "Lugar Nacimiento");
                        Grilla.Columns.Add("Edad", "Edad");
                        Grilla.Columns.Add("Sexo", "Sexo");
                        Grilla.Columns.Add("Ingreso", "Ingreso");
                        Grilla.Columns.Add("Puntaje", "Puntaje");
                        Grilla.Columns.Add("Estado", "Estado");

                        if (LeerBD.HasRows)
                        {
                            while (LeerBD.Read())
                            {
                                if (LeerBD.GetBoolean(8) == true)
                                {
                                    EstadoCliente = "Activo";
                                }
                                else
                                {
                                    EstadoCliente = "Inactivo";
                                }

                                Grilla.Rows.Add(LeerBD[1], LeerBD[2], LeerBD[3], LeerBD[4], LeerBD[5], LeerBD[6], LeerBD[7], EstadoCliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer datos: " + ex.Message);
            }
        }


        public void BuscarPorCodigo(int CodigoSocio)
        {
            comandBD = new OleDbCommand();

            comandBD.Connection = conexionBD;
            comandBD.CommandType = System.Data.CommandType.TableDirect;
            comandBD.CommandText = "SOCIOS";//que tabla traigo

            LeerBD = comandBD.ExecuteReader();

            if (LeerBD.HasRows) //si tiene filas
            {
                bool seEncuentra = false;
                while (LeerBD.Read())
                {
                    if (int.Parse(LeerBD[0].ToString()) == CodigoSocio)
                    {
                        MessageBox.Show("cliente existe", "consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        seEncuentra = true;
                        break;
                    }

                }

                if (seEncuentra == false)
                {
                    MessageBox.Show("No Existe",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        

        public void CambiarEstadoCliente(int id)
        {


            OleDbCommand comandoBD = new OleDbCommand();

            OleDbDataAdapter objAdaptador;

            // DataSet, se usa como contenedor de los datos de la base de datos 
            DataSet objDataSet = new DataSet();

            try
            {

                conexionBD = new OleDbConnection();
                string rutaArchivo = @"../../Resources/El Club/EL_CLUB.accsdb";
                string Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;


                conexionBD.ConnectionString = Conexion;
                conexionBD.Open();
                EstadoConexion = "Conectado";

            }
            catch (Exception ex)
            {

                EstadoConexion = "Error" + ex.Message;
            }

            comandoBD.Connection = conexionBD;

            // le indico que voy a modificar una tabla tal
            comandoBD.CommandType = CommandType.TableDirect;

            //Le digo que tabla 
            comandoBD.CommandText = "SOCIOS";

            //Creo el objeto DataAdapter y le paso como parámetro el comando que quiero vincular
            objAdaptador = new OleDbDataAdapter(comandoBD);

            // almacena su contenido en el dataSet
            objAdaptador.Fill(objDataSet, "SOCIOS");

            DataTable dataTable = objDataSet.Tables["SOCIOS"];

            foreach (DataRow registro in dataTable.Rows)
            {
                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    //edito la fila 
                    registro.BeginEdit();

                    //Cambio el valor de true a false o al reves dependiendo el estado actual
                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    //Final de la edición
                    registro.EndEdit();

                    //rompo el bucle después de modificar
                    break;
                }
            }

            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            objAdaptador.Update(objDataSet, "SOCIOS");

            MessageBox.Show("Estado de cliente modificado!");
        }

        public void CrearCuenta()
        {
            try
            {
                OleDbCommand comandoBD = new OleDbCommand();

                OleDbDataAdapter objAdaptador;

                // DataSet, se usa como contenedor de los datos de la base de datos 
                DataSet objDataSet = new DataSet();

                conexionBD = new OleDbConnection();
                string rutaArchivo = @"../../Resources/El Club/EL_CLUB.accsdb";
                string Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;


                conexionBD.ConnectionString = Conexion;
                conexionBD.Open();
                EstadoConexion = "Conectado";




                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla quiero traer
                comandoBD.CommandText = "Usuario";

                objAdaptador = new OleDbDataAdapter(comandoBD);

                objAdaptador.Fill(objDataSet, "Usuario");

                DataTable objTabla = objDataSet.Tables["Usuario"];

                //Creo el nuevo DataRow con la estructura de campos de la tabla de la cual quiero traer los datos
                DataRow nuevoRegistro = objTabla.NewRow();

                //Asigno valores a todos los campos del DataRow
                //nuevoRegistro["Nombre"] = frmRegistrarUsuario.Usuario;
                //nuevoRegistro["Contraseña"] = frmRegistrarUsuario.ContraseñaIguales;
                //nuevoRegistro["Perfil"] = frmRegistrarUsuario.Perfil;

                //Agrego el DataRow a la tabla
                objTabla.Rows.Add(nuevoRegistro);


                //Creo el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

                //Actualizo la base con los cambios
                objAdaptador.Update(objDataSet, "Usuario");

                EstadoConexion = "Cuenta creada exitosamente";
            }
            catch (Exception error)
            {
                EstadoConexion = error.Message;
            }
        }
    }
}
