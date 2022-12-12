namespace MarDeCortezDsk.UserControlls
{
    partial class botonesEdicion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblEditar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(56, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 18);
            this.panel1.TabIndex = 38;
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.ForeColor = System.Drawing.Color.White;
            this.LblEliminar.Location = new System.Drawing.Point(65, 2);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(65, 20);
            this.LblEliminar.TabIndex = 42;
            this.LblEliminar.Text = "Eliminar";
            this.LblEliminar.Click += new System.EventHandler(this.LblEliminar_Click);
            // 
            // LblEditar
            // 
            this.LblEditar.AutoSize = true;
            this.LblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditar.ForeColor = System.Drawing.Color.White;
            this.LblEditar.Location = new System.Drawing.Point(1, 3);
            this.LblEditar.Name = "LblEditar";
            this.LblEditar.Size = new System.Drawing.Size(51, 20);
            this.LblEditar.TabIndex = 41;
            this.LblEditar.Text = "Editar";
            this.LblEditar.Click += new System.EventHandler(this.LblEditar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblEditar);
            this.panel2.Controls.Add(this.LblEliminar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 26);
            this.panel2.TabIndex = 44;
            // 
            // botonesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panel2);
            this.Name = "botonesEdicion";
            this.Size = new System.Drawing.Size(139, 26);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Label LblEditar;
        private System.Windows.Forms.Panel panel2;
    }
}
