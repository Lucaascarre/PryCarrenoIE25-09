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
    public partial class InicioSesión : Form
    {
        public InicioSesión()
        {
            InitializeComponent();
        }
        

        private void InicioSesión_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        
            {

                clsUsuario objUsuario = new clsUsuario();

                objUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

                if (objUsuario.estadoConexion == "Usuario EXISTE")
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    objUsuario.RegistroLogInicioSesion();

                    this.Hide();
                    Proveedores Pasar = new Proveedores();
                    Pasar.Show();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto...");
                    objUsuario.RegistroLogInicioSesion();
                }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
    }
}
