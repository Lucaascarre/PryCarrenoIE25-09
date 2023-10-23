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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void cARGARPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CargarProveedores VarPasar = new CargarProveedores();
            VarPasar.Show();
        }
        public partial class PantallaCarga : Form
        {


            //private void timerCarga_Tick(object sender, EventArgs e)
            //{
            //    // Realiza tareas de carga o actualización aquí.
            //    // Puedes mostrar un mensaje de progreso o actualizar una barra de progreso.

            //    // Cuando la carga esté completa, detén el Timer.
            //    timerCarga.Stop();

            //    // Cierra la pantalla de carga (PantallaCarga).
            //    this.Close();
            }
            private void PantallaPrincipal_Load(object sender, EventArgs e)
            {

            }

        private void vERPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores frmProveedores = new Proveedores();
            frmProveedores.Show();
        }
    }
    }

