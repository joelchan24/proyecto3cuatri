namespace Reportes
{
    partial class Reporte_Usuario
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
            this.Contenedor_Usuario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReporteUsuarios1 = new Reportes.ReporteUsuarios();
            this.SuspendLayout();
            // 
            // Contenedor_Usuario
            // 
            this.Contenedor_Usuario.ActiveViewIndex = -1;
            this.Contenedor_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contenedor_Usuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.Contenedor_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor_Usuario.Location = new System.Drawing.Point(0, 0);
            this.Contenedor_Usuario.Name = "Contenedor_Usuario";
            this.Contenedor_Usuario.Size = new System.Drawing.Size(742, 419);
            this.Contenedor_Usuario.TabIndex = 0;
            // 
            // Reporte_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 419);
            this.Controls.Add(this.Contenedor_Usuario);
            this.Name = "Reporte_Usuario";
            this.Text = "Reporte_Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Contenedor_Usuario;
        private Reportes.ReporteUsuarios ReporteUsuarios1;
    }
}