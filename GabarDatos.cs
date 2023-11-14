using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PryCarrenoIE
{
    internal class GabarDatos
    {


        public static string RutaFull;

        public void Grabar(string Número, string Entidad, string Apertura, string Expediente, string Juzgado, string Jurisdiccion, string Dirección, string Liquidador)
        {






            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources");
            string ruta = info.FullName;
            string rutaArchivoFinal = info.FullName + "/Listado de aseguradores.csv";


            StreamWriter Listado = new StreamWriter((RutaFull), true);
            Listado.Write(Número);
            Listado.Write(";");
            Listado.Write(Entidad);
            Listado.Write(";");
            Listado.Write(Apertura);
            Listado.Write(";");
            Listado.Write(Expediente);
            Listado.Write(";");
            Listado.Write(Juzgado);
            Listado.Write(";");
            Listado.Write(Jurisdiccion);
            Listado.Write(";");
            Listado.Write(Dirección);
            Listado.Write(";");
            Listado.WriteLine(Liquidador);
            Listado.Close();
            Listado.Dispose();
        }
    }
}