namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class NuevoProducto
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
            this.BtnAjustes = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdBtnEntero = new System.Windows.Forms.RadioButton();
            this.RdBtnEmpaquetado = new System.Windows.Forms.RadioButton();
            this.LinePresentacion = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmboxTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new CustomControls.RJControls.RJTextBox();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.BackBtn = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAjustes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAjustes.IconColor = System.Drawing.Color.White;
            this.BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAjustes.Location = new System.Drawing.Point(28, -67);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Size = new System.Drawing.Size(140, 64);
            this.BtnAjustes.TabIndex = 22;
            this.BtnAjustes.Text = "Usuarios";
            this.BtnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjustes.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre del producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdBtnEntero);
            this.groupBox1.Controls.Add(this.RdBtnEmpaquetado);
            this.groupBox1.Controls.Add(this.LinePresentacion);
            this.groupBox1.Controls.Add(this.lblPresentacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmboxTipo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 360);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdBtnEntero
            // 
            this.RdBtnEntero.AutoSize = true;
            this.RdBtnEntero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdBtnEntero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RdBtnEntero.Location = new System.Drawing.Point(156, 291);
            this.RdBtnEntero.Name = "RdBtnEntero";
            this.RdBtnEntero.Size = new System.Drawing.Size(75, 24);
            this.RdBtnEntero.TabIndex = 46;
            this.RdBtnEntero.TabStop = true;
            this.RdBtnEntero.Text = "Entero";
            this.RdBtnEntero.UseVisualStyleBackColor = true;
            this.RdBtnEntero.Visible = false;
            this.RdBtnEntero.CheckedChanged += new System.EventHandler(this.RdBtnEntero_CheckedChanged);
            // 
            // RdBtnEmpaquetado
            // 
            this.RdBtnEmpaquetado.AutoSize = true;
            this.RdBtnEmpaquetado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdBtnEmpaquetado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RdBtnEmpaquetado.Location = new System.Drawing.Point(19, 291);
            this.RdBtnEmpaquetado.Name = "RdBtnEmpaquetado";
            this.RdBtnEmpaquetado.Size = new System.Drawing.Size(128, 24);
            this.RdBtnEmpaquetado.TabIndex = 45;
            this.RdBtnEmpaquetado.TabStop = true;
            this.RdBtnEmpaquetado.Text = "Empaquetado";
            this.RdBtnEmpaquetado.UseVisualStyleBackColor = true;
            this.RdBtnEmpaquetado.Visible = false;
            this.RdBtnEmpaquetado.CheckedChanged += new System.EventHandler(this.RdBtnEmpaquetado_CheckedChanged);
            // 
            // LinePresentacion
            // 
            this.LinePresentacion.AutoSize = true;
            this.LinePresentacion.ForeColor = System.Drawing.SystemColors.Control;
            this.LinePresentacion.Location = new System.Drawing.Point(15, 318);
            this.LinePresentacion.Name = "LinePresentacion";
            this.LinePresentacion.Size = new System.Drawing.Size(216, 20);
            this.LinePresentacion.TabIndex = 44;
            this.LinePresentacion.Text = "_______________________";
            this.LinePresentacion.Visible = false;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPresentacion.Location = new System.Drawing.Point(15, 256);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(119, 20);
            this.lblPresentacion.TabIndex = 43;
            this.lblPresentacion.Text = "Presentación:";
            this.lblPresentacion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "_______________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tipo de producto:";
            // 
            // CmboxTipo
            // 
            this.CmboxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmboxTipo.FormattingEnabled = true;
            this.CmboxTipo.Items.AddRange(new object[] {
            "Pescado",
            "Otros"});
            this.CmboxTipo.Location = new System.Drawing.Point(19, 180);
            this.CmboxTipo.Name = "CmboxTipo";
            this.CmboxTipo.Size = new System.Drawing.Size(212, 28);
            this.CmboxTipo.TabIndex = 38;
            this.CmboxTipo.TextChanged += new System.EventHandler(this.CmboxTipo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(17, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "_______________________";
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxNombre.BorderRadius = 0;
            this.TxtBoxNombre.BorderSize = 2;
            this.TxtBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxNombre.Location = new System.Drawing.Point(21, 77);
            this.TxtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxNombre.Multiline = false;
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxNombre.PasswordChar = false;
            this.TxtBoxNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxNombre.PlaceholderText = "Nombre del produto";
            this.TxtBoxNombre.Size = new System.Drawing.Size(210, 35);
            this.TxtBoxNombre.TabIndex = 25;
            this.TxtBoxNombre.Texts = "";
            this.TxtBoxNombre.UnderlinedStyle = false;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.botonRedondo1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.botonRedondo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo1.BorderRadius = 20;
            this.botonRedondo1.BorderSize = 0;
            this.botonRedondo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(111, 369);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(87, 36);
            this.botonRedondo1.TabIndex = 23;
            this.botonRedondo1.Text = "Guardar";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.BackgroundColor = System.Drawing.Color.White;
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BackBtn.BorderRadius = 20;
            this.BackBtn.BorderSize = 0;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BackBtn.Location = new System.Drawing.Point(18, 369);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(87, 36);
            this.BackBtn.TabIndex = 34;
            this.BackBtn.Text = "Volver";
            this.BackBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAjustes);
            this.Controls.Add(this.botonRedondo1);
            this.Name = "NuevoProducto";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(316, 410);
            this.Load += new System.EventHandler(this.NuevoUsuario_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox TxtBoxNombre;
        private BotonRedondo botonRedondo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RdBtnEntero;
        private System.Windows.Forms.RadioButton RdBtnEmpaquetado;
        private System.Windows.Forms.Label LinePresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmboxTipo;
        private BotonRedondo BackBtn;
    }
}
