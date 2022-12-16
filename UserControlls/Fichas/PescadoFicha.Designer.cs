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
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.TxtboxCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmBoxPresentacion = new System.Windows.Forms.ComboBox();
            this.RBtnEmpaquetado = new System.Windows.Forms.RadioButton();
            this.CmBoxProducto = new System.Windows.Forms.ComboBox();
            this.RbtnEntero = new System.Windows.Forms.RadioButton();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblPresentacion = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PescadoContainer.SuspendLayout();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtboxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // PescadoContainer
            // 
            this.PescadoContainer.Controls.Add(this.DatosGroupBox);
            this.PescadoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PescadoContainer.Location = new System.Drawing.Point(0, 0);
            this.PescadoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PescadoContainer.Name = "PescadoContainer";
            this.PescadoContainer.Size = new System.Drawing.Size(486, 350);
            this.PescadoContainer.TabIndex = 3;
            this.PescadoContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PescadoContainer_Paint);
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.TxtboxCantidad);
            this.DatosGroupBox.Controls.Add(this.label3);
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.CmBoxPresentacion);
            this.DatosGroupBox.Controls.Add(this.RBtnEmpaquetado);
            this.DatosGroupBox.Controls.Add(this.CmBoxProducto);
            this.DatosGroupBox.Controls.Add(this.RbtnEntero);
            this.DatosGroupBox.Controls.Add(this.LblCantidad);
            this.DatosGroupBox.Controls.Add(this.LblProducto);
            this.DatosGroupBox.Controls.Add(this.LblPresentacion);
            this.DatosGroupBox.Controls.Add(this.LblTipo);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DatosGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.DatosGroupBox.Location = new System.Drawing.Point(119, 0);
            this.DatosGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.DatosGroupBox.Size = new System.Drawing.Size(271, 342);
            this.DatosGroupBox.TabIndex = 23;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Enter += new System.EventHandler(this.DatosGroupBox_Enter);
            // 
            // TxtboxCantidad
            // 
            this.TxtboxCantidad.Location = new System.Drawing.Point(24, 296);
            this.TxtboxCantidad.Name = "TxtboxCantidad";
            this.TxtboxCantidad.Size = new System.Drawing.Size(120, 26);
            this.TxtboxCantidad.TabIndex = 34;
            this.TxtboxCantidad.ValueChanged += new System.EventHandler(this.TxtboxCantidad_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "_________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "_________________________________";
            // 
            // CmBoxPresentacion
            // 
            this.CmBoxPresentacion.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.CmBoxPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.CmBoxPresentacion.FormattingEnabled = true;
            this.CmBoxPresentacion.Location = new System.Drawing.Point(24, 208);
            this.CmBoxPresentacion.Name = "CmBoxPresentacion";
            this.CmBoxPresentacion.Size = new System.Drawing.Size(162, 23);
            this.CmBoxPresentacion.TabIndex = 17;
            this.CmBoxPresentacion.SelectedIndexChanged += new System.EventHandler(this.CmBoxPresentacion_SelectedIndexChanged);
            this.CmBoxPresentacion.TextChanged += new System.EventHandler(this.CmBoxPresentacion_TextChanged);
            // 
            // RBtnEmpaquetado
            // 
            this.RBtnEmpaquetado.AutoSize = true;
            this.RBtnEmpaquetado.Font = new System.Drawing.Font("Liberation Sans", 12F);
            this.RBtnEmpaquetado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.RBtnEmpaquetado.Location = new System.Drawing.Point(108, 54);
            this.RBtnEmpaquetado.Name = "RBtnEmpaquetado";
            this.RBtnEmpaquetado.Size = new System.Drawing.Size(125, 21);
            this.RBtnEmpaquetado.TabIndex = 16;
            this.RBtnEmpaquetado.Text = "Empaquetado";
            this.RBtnEmpaquetado.UseVisualStyleBackColor = true;
            this.RBtnEmpaquetado.CheckedChanged += new System.EventHandler(this.RBtnEmpaquetado_CheckedChanged);
            // 
            // CmBoxProducto
            // 
            this.CmBoxProducto.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.CmBoxProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.CmBoxProducto.FormattingEnabled = true;
            this.CmBoxProducto.Location = new System.Drawing.Point(24, 132);
            this.CmBoxProducto.Name = "CmBoxProducto";
            this.CmBoxProducto.Size = new System.Drawing.Size(162, 23);
            this.CmBoxProducto.TabIndex = 14;
            this.CmBoxProducto.SelectedIndexChanged += new System.EventHandler(this.CmBoxPaquete_SelectedIndexChanged);
            this.CmBoxProducto.TextChanged += new System.EventHandler(this.CmBoxProducto_TextChanged);
            // 
            // RbtnEntero
            // 
            this.RbtnEntero.AutoSize = true;
            this.RbtnEntero.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnEntero.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.RbtnEntero.Location = new System.Drawing.Point(21, 54);
            this.RbtnEntero.Name = "RbtnEntero";
            this.RbtnEntero.Size = new System.Drawing.Size(72, 21);
            this.RbtnEntero.TabIndex = 11;
            this.RbtnEntero.Text = "Entero";
            this.RbtnEntero.UseVisualStyleBackColor = true;
            this.RbtnEntero.CheckedChanged += new System.EventHandler(this.RbtnEntero_CheckedChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Liberation Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.LblCantidad.Location = new System.Drawing.Point(17, 269);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(85, 19);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Liberation Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.LblProducto.Location = new System.Drawing.Point(17, 106);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(88, 19);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Text = "Producto:";
            this.LblProducto.Click += new System.EventHandler(this.LblProducto_Click);
            // 
            // LblPresentacion
            // 
            this.LblPresentacion.AutoSize = true;
            this.LblPresentacion.Font = new System.Drawing.Font("Liberation Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.LblPresentacion.Location = new System.Drawing.Point(17, 180);
            this.LblPresentacion.Name = "LblPresentacion";
            this.LblPresentacion.Size = new System.Drawing.Size(118, 19);
            this.LblPresentacion.TabIndex = 4;
            this.LblPresentacion.Text = "Presentación:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Liberation Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.LblTipo.Location = new System.Drawing.Point(17, 15);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(139, 19);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo de Pescado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "_________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PescadoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.PescadoContainer);
            this.Name = "PescadoFicha";
            this.Size = new System.Drawing.Size(486, 350);
            this.Load += new System.EventHandler(this.PescadoFicha_Load);
            this.PescadoContainer.ResumeLayout(false);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtboxCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PescadoContainer;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblPresentacion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.RadioButton RbtnEntero;
        private System.Windows.Forms.ComboBox CmBoxProducto;
        private System.Windows.Forms.RadioButton RBtnEmpaquetado;
        private System.Windows.Forms.ComboBox CmBoxPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TxtboxCantidad;
    }
}
