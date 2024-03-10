namespace fuente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lb_fuente = new System.Windows.Forms.Label();
            this.lb_tamaño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(179, 371);
            this.trackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(797, 69);
            this.trackBar.TabIndex = 0;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lb_fuente
            // 
            this.lb_fuente.AutoSize = true;
            this.lb_fuente.BackColor = System.Drawing.Color.Transparent;
            this.lb_fuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fuente.Location = new System.Drawing.Point(175, 138);
            this.lb_fuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fuente.Name = "lb_fuente";
            this.lb_fuente.Size = new System.Drawing.Size(834, 82);
            this.lb_fuente.TabIndex = 1;
            this.lb_fuente.Text = "ALL WE NEED IS LOVE";
            // 
            // lb_tamaño
            // 
            this.lb_tamaño.AutoSize = true;
            this.lb_tamaño.BackColor = System.Drawing.Color.Transparent;
            this.lb_tamaño.Location = new System.Drawing.Point(491, 312);
            this.lb_tamaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tamaño.Name = "lb_tamaño";
            this.lb_tamaño.Size = new System.Drawing.Size(155, 20);
            this.lb_tamaño.TabIndex = 2;
            this.lb_tamaño.Text = "Tamaño de la fuente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 634);
            this.Controls.Add(this.lb_tamaño);
            this.Controls.Add(this.lb_fuente);
            this.Controls.Add(this.trackBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lb_fuente;
        private System.Windows.Forms.Label lb_tamaño;
    }
}

