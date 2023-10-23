namespace PryCarrenoIE
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERPROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGARPROVEEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(52)))), ((int)(((byte)(82)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROVEEDORESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROVEEDORESToolStripMenuItem
            // 
            this.pROVEEDORESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERPROVEEDORESToolStripMenuItem,
            this.cARGARPROVEEDORESToolStripMenuItem});
            this.pROVEEDORESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROVEEDORESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pROVEEDORESToolStripMenuItem.Name = "pROVEEDORESToolStripMenuItem";
            this.pROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.pROVEEDORESToolStripMenuItem.Text = "PROVEEDORES";
            // 
            // vERPROVEEDORESToolStripMenuItem
            // 
            this.vERPROVEEDORESToolStripMenuItem.Name = "vERPROVEEDORESToolStripMenuItem";
            this.vERPROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.vERPROVEEDORESToolStripMenuItem.Text = "VER PROVEEDORES";
            this.vERPROVEEDORESToolStripMenuItem.Click += new System.EventHandler(this.vERPROVEEDORESToolStripMenuItem_Click);
            // 
            // cARGARPROVEEDORESToolStripMenuItem
            // 
            this.cARGARPROVEEDORESToolStripMenuItem.Name = "cARGARPROVEEDORESToolStripMenuItem";
            this.cARGARPROVEEDORESToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cARGARPROVEEDORESToolStripMenuItem.Text = "CARGAR PROVEEDORES";
            this.cARGARPROVEEDORESToolStripMenuItem.Click += new System.EventHandler(this.cARGARPROVEEDORESToolStripMenuItem_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryCarrenoIE.Properties.Resources.PROSEGUR1;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERPROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARGARPROVEEDORESToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}