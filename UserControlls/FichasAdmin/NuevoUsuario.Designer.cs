namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class NuevoUsuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxId = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new CustomControls.RJControls.RJTextBox();
            this.TxtBoxPass = new CustomControls.RJControls.RJTextBox();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(35, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // TxtBoxTipoUsuario
            // 
            this.TxtBoxTipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxTipoUsuario.FormattingEnabled = true;
            this.TxtBoxTipoUsuario.Items.AddRange(new object[] {
            "Usuario\t",
            "Administrador"});
            this.TxtBoxTipoUsuario.Location = new System.Drawing.Point(35, 210);
            this.TxtBoxTipoUsuario.Name = "TxtBoxTipoUsuario";
            this.TxtBoxTipoUsuario.Size = new System.Drawing.Size(206, 28);
            this.TxtBoxTipoUsuario.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBoxId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxNombre);
            this.groupBox1.Controls.Add(this.TxtBoxTipoUsuario);
            this.groupBox1.Controls.Add(this.TxtBoxPass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 355);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "_______________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Usuario";
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxId.BorderRadius = 0;
            this.TxtBoxId.BorderSize = 2;
            this.TxtBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxId.Location = new System.Drawing.Point(31, 40);
            this.TxtBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxId.Multiline = false;
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxId.PasswordChar = false;
            this.TxtBoxId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxId.PlaceholderText = "Identificador del usuario";
            this.TxtBoxId.Size = new System.Drawing.Size(210, 35);
            this.TxtBoxId.TabIndex = 39;
            this.TxtBoxId.Texts = "";
            this.TxtBoxId.UnderlinedStyle = false;
            this.TxtBoxId._TextChanged += new System.EventHandler(this.TxtBoxId__TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(31, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "_______________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(31, 157);
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
            this.TxtBoxNombre.Location = new System.Drawing.Point(35, 123);
            this.TxtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxNombre.Multiline = false;
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxNombre.PasswordChar = false;
            this.TxtBoxNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxNombre.PlaceholderText = "Nombre y Apellido";
            this.TxtBoxNombre.Size = new System.Drawing.Size(210, 35);
            this.TxtBoxNombre.TabIndex = 25;
            this.TxtBoxNombre.Texts = "";
            this.TxtBoxNombre.UnderlinedStyle = false;
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxPass.BorderRadius = 0;
            this.TxtBoxPass.BorderSize = 2;
            this.TxtBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxPass.Location = new System.Drawing.Point(34, 300);
            this.TxtBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxPass.Multiline = false;
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxPass.PasswordChar = false;
            this.TxtBoxPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxPass.PlaceholderText = "contraseña";
            this.TxtBoxPass.Size = new System.Drawing.Size(207, 35);
            this.TxtBoxPass.TabIndex = 27;
            this.TxtBoxPass.Texts = "";
            this.TxtBoxPass.UnderlinedStyle = false;
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
            this.botonRedondo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(142, 388);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(96, 40);
            this.botonRedondo1.TabIndex = 23;
            this.botonRedondo1.Text = "Guardar";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAjustes);
            this.Controls.Add(this.botonRedondo1);
            this.Name = "NuevoUsuario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(876, 443);
            this.Load += new System.EventHandler(this.NuevoUsuario_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox TxtBoxPass;
        private System.Windows.Forms.ComboBox TxtBoxTipoUsuario;
        private CustomControls.RJControls.RJTextBox TxtBoxNombre;
        private BotonRedondo botonRedondo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox TxtBoxId;
    }
}
