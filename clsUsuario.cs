using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace PryCarrenoIE
{
    internal class clsUsuario
    {
        OleDbConnection ConexionBd;
        OleDbCommand ComandoBd;
        OleDbDataReader LectorBd;
        OleDbDataAdapter AdaptadorBd;
        DataSet ObjDs;

        String RutaArchivo;
        public String estadoConexion;

        public clsUsuario()
        {
            try
            {
                RutaArchivo = @"../../Archivos/BDusuarios.accdb";

                ConexionBd = new OleDbConnection();
                ConexionBd.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaArchivo;
                ConexionBd.Open();
                ObjDs = new DataSet();
                estadoConexion = "Conectado";

            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }
        public void RegistroLogInicioSesion()
        {
            try
            {
                ComandoBd = new OleDbCommand();
                ComandoBd.Connection = ConexionBd;
                ComandoBd.CommandType = System.Data.CommandType.TableDirect;
                ComandoBd.CommandText = "Logs";

                AdaptadorBd = new OleDbDataAdapter(ComandoBd);
                AdaptadorBd.Fill(ObjDs, "Logs");
                DataTable objTabla = ObjDs.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(AdaptadorBd);
                AdaptadorBd.Update(ObjDs, "Logs");

                estadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }
        public void ValidarUsuario(string nombreUser, string passUser)
        {
            try
            {
                ComandoBd = new OleDbCommand();

                ComandoBd.Connection = ConexionBd;
                ComandoBd.CommandType = System.Data.CommandType.TableDirect;
                ComandoBd.CommandText = "Usuario";

                LectorBd = ComandoBd.ExecuteReader();

                if (LectorBd.HasRows)
                {
                    while (LectorBd.Read())
                    {
                        if (LectorBd[1].ToString() == nombreUser && LectorBd[2].ToString() == passUser)
                        {
                            estadoConexion = "Usuario EXISTE";
                        }
                    }
                }

            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }


















    }
}
