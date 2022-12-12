namespace MarDeCortezDsk.UserControlls
{
    partial class OtrosFicha
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
            this.PescadoContainer = new System.Windows.Forms.Panel();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.CmBoxPresentacion = new System.Windows.Forms.ComboBox();
            this.CmBoxProducto = new System.Windows.Forms.ComboBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtboxCantidad = new System.Windows.Forms.TextBox();
            this.LblPresentacion = new System.Windows.Forms.Label();
            this.BtnEnviar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.pctbx_Lgprdct = new System.Windows.Forms.PictureBox();
            this.PescadoContainer.SuspendLayout();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Lgprdct)).BeginInit();
            this.SuspendLayout();
            // 
            // PescadoContainer
            // 
            this.PescadoContainer.Controls.Add(this.DatosGroupBox);
            this.PescadoContainer.Controls.Add(this.BtnEnviar);
            this.PescadoContainer.Controls.Add(this.pctbx_Lgprdct);
            this.PescadoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PescadoContainer.Location = new System.Drawing.Point(0, 0);
            this.PescadoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PescadoContainer.Name = "PescadoContainer";
            this.PescadoContainer.Size = new System.Drawing.Size(486, 356);
            this.PescadoContainer.TabIndex = 4;
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.CmBoxPresentacion);
            this.DatosGroupBox.Controls.Add(this.CmBoxProducto);
            this.DatosGroupBox.Controls.Add(this.LblCantidad);
            this.DatosGroupBox.Controls.Add(this.LblProducto);
            this.DatosGroupBox.Controls.Add(this.TxtboxCantidad);
            this.DatosGroupBox.Controls.Add(this.LblPresentacion);
            this.DatosGroupBox.Location = new System.Drawing.Point(76, 57);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(311, 229);
            this.DatosGroupBox.TabIndex = 23;
            this.DatosGroupBox.TabStop = false;
            // 
            // CmBoxPresentacion
            // 
            this.CmBoxPresentacion.FormattingEnabled = true;
            this.CmBoxPresentacion.Items.AddRange(new object[] {
            "SUELTO",
            "KILO",
            "MARQUETA DOS KILOS",
            "MARQUETA CINCO KILOS",
            "MARQUETA DIEZ KILOS"});
            this.CmBoxPresentacion.Location = new System.Drawing.Point(154, 105);
            this.CmBoxPresentacion.Name = "CmBoxPresentacion";
            this.CmBoxPresentacion.Size = new System.Drawing.Size(121, 21);
            this.CmBoxPresentacion.TabIndex = 17;
            // 
            // CmBoxProducto
            // 
            this.CmBoxProducto.FormattingEnabled = true;
            this.CmBoxProducto.Items.AddRange(new object[] {
            "PULPO CAMPECHANO -1",
            "PULPO CAMPECHANO 1-2 ",
            "PULPO CAMPECHANO 2-4 ",
            "PULPO CAMPECHANO 4-6 ",
            "PULPO REGIONAL CHICO ",
            "PULPO REGIONAL 1-2 ",
            "PULPO REGIONAL 2-4 ",
            "PULPO REGIONAL 4-6",
            "CALAMAR",
            "CALAMAR LIMPIO REGIONAL",
            "CALAMAR VAINA LIMPIO",
            "CALAMAR AROS LIMPIO",
            "TENTACULO DE CALAMAR",
            "CALLO CATARINA",
            "CALLO ARBOL",
            "CALLO CONCHA ESPINA",
            "CALLO ESCARLOPA",
            "CALLO RINON",
            "CALLO HACHA",
            "CARACOL CHINO",
            "CARACOL BURRO",
            "CARACOL DE UÑA"});
            this.CmBoxProducto.Location = new System.Drawing.Point(149, 44);
            this.CmBoxProducto.Name = "CmBoxProducto";
            this.CmBoxProducto.Size = new System.Drawing.Size(121, 21);
            this.CmBoxProducto.TabIndex = 14;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(33, 149);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(86, 20);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(24, 42);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(86, 20);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Text = "Producto:";
            // 
            // TxtboxCantidad
            // 
            this.TxtboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCantidad.Location = new System.Drawing.Point(154, 143);
            this.TxtboxCantidad.Name = "TxtboxCantidad";
            this.TxtboxCantidad.Size = new System.Drawing.Size(95, 29);
            this.TxtboxCantidad.TabIndex = 5;
            // 
            // LblPresentacion
            // 
            this.LblPresentacion.AutoSize = true;
            this.LblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPresentacion.Location = new System.Drawing.Point(24, 103);
            this.LblPresentacion.Name = "LblPresentacion";
            this.LblPresentacion.Size = new System.Drawing.Size(119, 20);
            this.LblPresentacion.TabIndex = 4;
            this.LblPresentacion.Text = "Presentacion:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEnviar.BorderRadius = 20;
            this.BtnEnviar.BorderSize = 0;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(188, 298);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(97, 42);
            this.BtnEnviar.TabIndex = 22;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.TextColor = System.Drawing.Color.White;
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // pctbx_Lgprdct
            // 
            this.pctbx_Lgprdct.Image = global::MarDeCortezDsk.Properties.Resources.mussel;
            this.pctbx_Lgprdct.Location = new System.Drawing.Point(188, 7);
            this.pctbx_Lgprdct.Name = "pctbx_Lgprdct";
            this.pctbx_Lgprdct.Size = new System.Drawing.Size(97, 44);
            this.pctbx_Lgprdct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbx_Lgprdct.TabIndex = 5;
            this.pctbx_Lgprdct.TabStop = false;
            // 
            // OtrosFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PescadoContainer);
            this.Name = "OtrosFicha";
            this.Size = new System.Drawing.Size(486, 356);
            this.PescadoContainer.ResumeLayout(false);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Lgprdct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PescadoContainer;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.ComboBox CmBoxPresentacion;
        private System.Windows.Forms.ComboBox CmBoxProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtboxCantidad;
        private System.Windows.Forms.Label LblPresentacion;
        private BotonRedondo BtnEnviar;
        private System.Windows.Forms.PictureBox pctbx_Lgprdct;
    }
}
