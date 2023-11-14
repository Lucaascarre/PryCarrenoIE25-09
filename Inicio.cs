﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCarrenoIE
{
    public partial class Inicio : Form
    {

       clsElClub objBaseDatos;
        
        public Inicio()



        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsElClub();
            objBaseDatos.ConectarBD();
            lblEstadoConexion.Text = objBaseDatos.EstadoConexion;
            lblEstadoConexion.BackColor = Color.Green;
            objBaseDatos.TraerDatos(GrlMostrarDatos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorCodigo(int.Parse(txtId.Text));
        }
    }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Task oTask = new Task (Carga);
        //    oTask.Start();
        //    await oTask;
        //}


        //public void Carga()

        //{
        //    Thread.Sleep(3000);
        //}
}
