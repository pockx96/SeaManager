namespace MarDeCortezDsk.UserControlls
{
    partial class PescadoFicha
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
            this.pctbx_Lgprdct = new System.Windows.Forms.PictureBox();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtboxCantidad = new System.Windows.Forms.TextBox();
            this.LblPresentacion = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.RbtnEntero = new System.Windows.Forms.RadioButton();
            this.CmBoxPaquete = new System.Windows.Forms.ComboBox();
            this.CmBoxEntero = new System.Windows.Forms.ComboBox();
            this.RBtnEmpaquetado = new System.Windows.Forms.RadioButton();
            this.BtnEnviar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.CmBoxPreEntero = new System.Windows.Forms.ComboBox();
            this.CmBoxPreEmpaquetado = new System.Windows.Forms.ComboBox();
            this.PescadoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Lgprdct)).BeginInit();
            this.DatosGroupBox.SuspendLayout();
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
            this.PescadoContainer.TabIndex = 3;
            this.PescadoContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PescadoContainer_Paint);
            // 
            // pctbx_Lgprdct
            // 
            this.pctbx_Lgprdct.Image = global::MarDeCortezDsk.Properties.Resources.fish_black;
            this.pctbx_Lgprdct.Location = new System.Drawing.Point(188, 7);
            this.pctbx_Lgprdct.Name = "pctbx_Lgprdct";
            this.pctbx_Lgprdct.Size = new System.Drawing.Size(97, 44);
            this.pctbx_Lgprdct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbx_Lgprdct.TabIndex = 5;
            this.pctbx_Lgprdct.TabStop = false;
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.CmBoxPreEntero);
            this.DatosGroupBox.Controls.Add(this.CmBoxPreEmpaquetado);
            this.DatosGroupBox.Controls.Add(this.RBtnEmpaquetado);
            this.DatosGroupBox.Controls.Add(this.CmBoxEntero);
            this.DatosGroupBox.Controls.Add(this.CmBoxPaquete);
            this.DatosGroupBox.Controls.Add(this.RbtnEntero);
            this.DatosGroupBox.Controls.Add(this.LblCantidad);
            this.DatosGroupBox.Controls.Add(this.LblProducto);
            this.DatosGroupBox.Controls.Add(this.TxtboxCantidad);
            this.DatosGroupBox.Controls.Add(this.LblPresentacion);
            this.DatosGroupBox.Controls.Add(this.LblTipo);
            this.DatosGroupBox.Location = new System.Drawing.Point(76, 57);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(311, 229);
            this.DatosGroupBox.TabIndex = 23;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Enter += new System.EventHandler(this.DatosGroupBox_Enter);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(3, 85);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(86, 20);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Text = "Producto:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(5, 192);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(86, 20);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtboxCantidad
            // 
            this.TxtboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCantidad.Location = new System.Drawing.Point(126, 186);
            this.TxtboxCantidad.Name = "TxtboxCantidad";
            this.TxtboxCantidad.Size = new System.Drawing.Size(95, 29);
            this.TxtboxCantidad.TabIndex = 5;
            // 
            // LblPresentacion
            // 
            this.LblPresentacion.AutoSize = true;
            this.LblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPresentacion.Location = new System.Drawing.Point(3, 146);
            this.LblPresentacion.Name = "LblPresentacion";
            this.LblPresentacion.Size = new System.Drawing.Size(119, 20);
            this.LblPresentacion.TabIndex = 4;
            this.LblPresentacion.Text = "Presentacion:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(6, 33);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(43, 20);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo";
            // 
            // RbtnEntero
            // 
            this.RbtnEntero.AutoSize = true;
            this.RbtnEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnEntero.Location = new System.Drawing.Point(114, 49);
            this.RbtnEntero.Name = "RbtnEntero";
            this.RbtnEntero.Size = new System.Drawing.Size(75, 24);
            this.RbtnEntero.TabIndex = 11;
            this.RbtnEntero.Text = "Entero";
            this.RbtnEntero.UseVisualStyleBackColor = true;
            this.RbtnEntero.CheckedChanged += new System.EventHandler(this.RbtnEntero_CheckedChanged);
            // 
            // CmBoxPaquete
            // 
            this.CmBoxPaquete.FormattingEnabled = true;
            this.CmBoxPaquete.Items.AddRange(new object[] {
            "Lenguado",
            "Manta",
            "Cazon",
            "Cochito",
            "Cochito Picado",
            "Atun",
            "Malin Ahumado",
            "Atun Aumado",
            "Merluza",
            "Guitarra",
            "Angelito",
            "Baya",
            "Jurel",
            "Bass"});
            this.CmBoxPaquete.Location = new System.Drawing.Point(121, 87);
            this.CmBoxPaquete.Name = "CmBoxPaquete";
            this.CmBoxPaquete.Size = new System.Drawing.Size(121, 21);
            this.CmBoxPaquete.TabIndex = 14;
            // 
            // CmBoxEntero
            // 
            this.CmBoxEntero.FormattingEnabled = true;
            this.CmBoxEntero.Items.AddRange(new object[] {
            "Palometa",
            "Curvina",
            "Pampano",
            "Mojarra",
            "Extranjero",
            "Pargo",
            "Baqueta",
            "Baya",
            "Botete"});
            this.CmBoxEntero.Location = new System.Drawing.Point(121, 114);
            this.CmBoxEntero.Name = "CmBoxEntero";
            this.CmBoxEntero.Size = new System.Drawing.Size(121, 21);
            this.CmBoxEntero.TabIndex = 15;
            // 
            // RBtnEmpaquetado
            // 
            this.RBtnEmpaquetado.AutoSize = true;
            this.RBtnEmpaquetado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnEmpaquetado.Location = new System.Drawing.Point(114, 19);
            this.RBtnEmpaquetado.Name = "RBtnEmpaquetado";
            this.RBtnEmpaquetado.Size = new System.Drawing.Size(128, 24);
            this.RBtnEmpaquetado.TabIndex = 16;
            this.RBtnEmpaquetado.Text = "Empaquetado";
            this.RBtnEmpaquetado.UseVisualStyleBackColor = true;
            this.RBtnEmpaquetado.CheckedChanged += new System.EventHandler(this.RBtnEmpaquetado_CheckedChanged);
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
            // CmBoxPreEntero
            // 
            this.CmBoxPreEntero.FormattingEnabled = true;
            this.CmBoxPreEntero.Items.AddRange(new object[] {
            "Para el disco",
            "100 - 500 Mgr",
            "500 - 800 Mgr",
            "800 - 1.2 Kg",
            "1.2 - 1.5 Kg",
            "1.5 - 2 Kg",
            "3 - 4 Kg",
            "5 Kg",
            "6 kg",
            "7 Kg",
            "8 Kg",
            "9 Kg",
            "10 Kg"});
            this.CmBoxPreEntero.Location = new System.Drawing.Point(121, 175);
            this.CmBoxPreEntero.Name = "CmBoxPreEntero";
            this.CmBoxPreEntero.Size = new System.Drawing.Size(121, 21);
            this.CmBoxPreEntero.TabIndex = 18;
            // 
            // CmBoxPreEmpaquetado
            // 
            this.CmBoxPreEmpaquetado.FormattingEnabled = true;
            this.CmBoxPreEmpaquetado.Items.AddRange(new object[] {
            "Dos kilos",
            "Cinco kilos",
            "Diez Kilos",
            "Al Vacio"});
            this.CmBoxPreEmpaquetado.Location = new System.Drawing.Point(121, 148);
            this.CmBoxPreEmpaquetado.Name = "CmBoxPreEmpaquetado";
            this.CmBoxPreEmpaquetado.Size = new System.Drawing.Size(121, 21);
            this.CmBoxPreEmpaquetado.TabIndex = 17;
            // 
            // PescadoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PescadoContainer);
            this.Name = "PescadoFicha";
            this.Size = new System.Drawing.Size(486, 356);
            this.PescadoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Lgprdct)).EndInit();
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PescadoContainer;
        private System.Windows.Forms.PictureBox pctbx_Lgprdct;
        private BotonRedondo BtnEnviar;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtboxCantidad;
        private System.Windows.Forms.Label LblPresentacion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.RadioButton RbtnEntero;
        private System.Windows.Forms.ComboBox CmBoxEntero;
        private System.Windows.Forms.ComboBox CmBoxPaquete;
        private System.Windows.Forms.RadioButton RBtnEmpaquetado;
        private System.Windows.Forms.ComboBox CmBoxPreEntero;
        private System.Windows.Forms.ComboBox CmBoxPreEmpaquetado;
    }
}
