namespace MarDeCortezDsk.UserControlls
{
    partial class labelCrear
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCrear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCrear
            // 
            this.LblCrear.AutoSize = true;
            this.LblCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrear.ForeColor = System.Drawing.Color.White;
            this.LblCrear.Location = new System.Drawing.Point(0, 0);
            this.LblCrear.Name = "LblCrear";
            this.LblCrear.Size = new System.Drawing.Size(181, 24);
            this.LblCrear.TabIndex = 41;
            this.LblCrear.Text = "Crear nuevo usuario";
            this.LblCrear.Click += new System.EventHandler(this.LblCrear_Click);
            // 
            // labelCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.LblCrear);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "labelCrear";
            this.Size = new System.Drawing.Size(233, 22);
            this.Load += new System.EventHandler(this.labelCrear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCrear;
    }
}
