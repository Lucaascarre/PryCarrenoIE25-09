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

namespace PryCarrenoIE
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }



        private void PantallaCarga_Load(object sender, EventArgs e)
        {
            timerCarga.Start();
        }
        private void timerCarga_Tick(object sender, EventArgs e)
        {
            if (barraProgreso.Value < 100)
            {
                barraProgreso.Value += 1;
                Porcentaje.Text = barraProgreso.Value.ToString() + "%";

            }

            if (barraProgreso.Value == barraProgreso.Maximum)

            {
                timerCarga.Stop();
                this.Hide();
                PantallaPrincipal frminicioprincipal = new PantallaPrincipal();
                frminicioprincipal.Show();
            }
            




        }

        private void PantallaCarga_Load_1(object sender, EventArgs e)
        {

        }
    }
}

