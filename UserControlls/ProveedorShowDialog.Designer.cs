namespace MarDeCortezDsk.UserControlls
{
    partial class ProveedorShowDialog
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
            this.BtnCalculadoraTotal = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.CmBoxProveedores = new System.Windows.Forms.ComboBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalculadoraTotal
            // 
            this.BtnCalculadoraTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnCalculadoraTotal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnCalculadoraTotal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCalculadoraTotal.BorderRadius = 20;
            this.BtnCalculadoraTotal.BorderSize = 0;
            this.BtnCalculadoraTotal.FlatAppearance.BorderSize = 0;
            this.BtnCalculadoraTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculadoraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculadoraTotal.ForeColor = System.Drawing.Color.White;
            this.BtnCalculadoraTotal.Location = new System.Drawing.Point(66, 177);
            this.BtnCalculadoraTotal.Name = "BtnCalculadoraTotal";
            this.BtnCalculadoraTotal.Size = new System.Drawing.Size(80, 40);
            this.BtnCalculadoraTotal.TabIndex = 15;
            this.BtnCalculadoraTotal.Text = "Total";
            this.BtnCalculadoraTotal.TextColor = System.Drawing.Color.White;
            this.BtnCalculadoraTotal.UseVisualStyleBackColor = false;
            this.BtnCalculadoraTotal.Click += new System.EventHandler(this.BtnCalculadoraTotal_Click);
            // 
            // CmBoxProveedores
            // 
            this.CmBoxProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxProveedores.FormattingEnabled = true;
            this.CmBoxProveedores.Items.AddRange(new object[] {
            "Tienda",
            "Proveedor1",
            "Proveedor2"});
            this.CmBoxProveedores.Location = new System.Drawing.Point(29, 100);
            this.CmBoxProveedores.Name = "CmBoxProveedores";
            this.CmBoxProveedores.Size = new System.Drawing.Size(159, 28);
            this.CmBoxProveedores.TabIndex = 14;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.LblProveedor.Location = new System.Drawing.Point(25, 48);
            this.LblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(163, 26);
            this.LblProveedor.TabIndex = 13;
            this.LblProveedor.Text = "Elija proveedor:";
            // 
            // ProveedorShowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.BtnCalculadoraTotal);
            this.Controls.Add(this.CmBoxProveedores);
            this.Controls.Add(this.LblProveedor);
            this.Name = "ProveedorShowDialog";
            this.Size = new System.Drawing.Size(213, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BotonRedondo BtnCalculadoraTotal;
        private System.Windows.Forms.ComboBox CmBoxProveedores;
        private System.Windows.Forms.Label LblProveedor;
    }
}
