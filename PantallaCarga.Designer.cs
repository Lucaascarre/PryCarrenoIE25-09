namespace PryCarrenoIE
{
    partial class PantallaCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCarga));
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.Porcentaje = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerCarga
            // 
            this.timerCarga.Enabled = true;
            // 
            // barraProgreso
            // 
            this.barraProgreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.barraProgreso.ForeColor = System.Drawing.Color.DodgerBlue;
            this.barraProgreso.Location = new System.Drawing.Point(297, 400);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(230, 23);
            this.barraProgreso.TabIndex = 0;
            // 
            // Porcentaje
            // 
            this.Porcentaje.AutoSize = true;
            this.Porcentaje.BackColor = System.Drawing.Color.Transparent;
            this.Porcentaje.Location = new System.Drawing.Point(387, 405);
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Size = new System.Drawing.Size(0, 13);
            this.Porcentaje.TabIndex = 1;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.BackColor = System.Drawing.Color.Transparent;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.Location = new System.Drawing.Point(370, 439);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(88, 13);
            this.lblCargando.TabIndex = 2;
            this.lblCargando.Text = "CARGANDO...";
            // 
            // PantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryCarrenoIE.Properties.Resources.Diseño_sin_título1;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.Porcentaje);
            this.Controls.Add(this.barraProgreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaCarga";
            this.Text = "PantallaCarga";
            this.Load += new System.EventHandler(this.PantallaCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.Label Porcentaje;
        private System.Windows.Forms.Label lblCargando;
        public System.Windows.Forms.ProgressBar barraProgreso;
    }
}