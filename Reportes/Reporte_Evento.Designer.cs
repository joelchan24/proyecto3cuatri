namespace Reportes
{
    partial class Reporte_Evento
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
            this.Contenedor_Evento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReporteUsuarios1 = new Reportes.Reportes.ReporteUsuarios();
            this.SuspendLayout();
            // 
            // Contenedor_Evento
            // 
            this.Contenedor_Evento.ActiveViewIndex = -1;
            this.Contenedor_Evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contenedor_Evento.Cursor = System.Windows.Forms.Cursors.Default;
            this.Contenedor_Evento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor_Evento.Location = new System.Drawing.Point(0, 0);
            this.Contenedor_Evento.Name = "Contenedor_Evento";
            this.Contenedor_Evento.Size = new System.Drawing.Size(815, 608);
            this.Contenedor_Evento.TabIndex = 0;
            this.Contenedor_Evento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.Contenedor_Evento.Load += new System.EventHandler(this.Contenedor_Evento_Load);
            // 
            // Reporte_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 608);
            this.Controls.Add(this.Contenedor_Evento);
            this.Name = "Reporte_Evento";
            this.Text = "Reporte_Evento";
            this.Load += new System.EventHandler(this.Reporte_Evento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Contenedor_Evento;
        private Reportes.Reportes.ReporteUsuarios ReporteUsuarios1;
    }
}