namespace PryCarrenoIE
{
    partial class Registrar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_Usuario));
            this.btnRegistrar2 = new System.Windows.Forms.Button();
            this.txtUsuarioRegistrar = new System.Windows.Forms.TextBox();
            this.txtContraseñaRegistrar = new System.Windows.Forms.TextBox();
            this.txtContraseñaRegistrar2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrar2
            // 
            this.btnRegistrar2.Location = new System.Drawing.Point(319, 301);
            this.btnRegistrar2.Name = "btnRegistrar2";
            this.btnRegistrar2.Size = new System.Drawing.Size(125, 23);
            this.btnRegistrar2.TabIndex = 0;
            this.btnRegistrar2.Text = "REGISTRAR";
            this.btnRegistrar2.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioRegistrar
            // 
            this.txtUsuarioRegistrar.Location = new System.Drawing.Point(262, 156);
            this.txtUsuarioRegistrar.Name = "txtUsuarioRegistrar";
            this.txtUsuarioRegistrar.Size = new System.Drawing.Size(229, 20);
            this.txtUsuarioRegistrar.TabIndex = 1;
            // 
            // txtContraseñaRegistrar
            // 
            this.txtContraseñaRegistrar.Location = new System.Drawing.Point(262, 211);
            this.txtContraseñaRegistrar.Name = "txtContraseñaRegistrar";
            this.txtContraseñaRegistrar.Size = new System.Drawing.Size(226, 20);
            this.txtContraseñaRegistrar.TabIndex = 2;
            // 
            // txtContraseñaRegistrar2
            // 
            this.txtContraseñaRegistrar2.Location = new System.Drawing.Point(262, 237);
            this.txtContraseñaRegistrar2.Name = "txtContraseñaRegistrar2";
            this.txtContraseñaRegistrar2.Size = new System.Drawing.Size(226, 20);
            this.txtContraseñaRegistrar2.TabIndex = 3;
            // 
            // Registrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtContraseñaRegistrar2);
            this.Controls.Add(this.txtContraseñaRegistrar);
            this.Controls.Add(this.txtUsuarioRegistrar);
            this.Controls.Add(this.btnRegistrar2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar_Usuario";
            this.Text = "Registrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar2;
        private System.Windows.Forms.TextBox txtUsuarioRegistrar;
        private System.Windows.Forms.TextBox txtContraseñaRegistrar;
        private System.Windows.Forms.TextBox txtContraseñaRegistrar2;
    }
}