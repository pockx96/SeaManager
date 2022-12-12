namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class NuevoProveedorMenu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new CustomControls.RJControls.RJTextBox();
            this.TxtBoxTelefono = new CustomControls.RJControls.RJTextBox();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxNombre);
            this.groupBox1.Controls.Add(this.TxtBoxTelefono);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 355);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(29, 89);
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
            this.TxtBoxNombre.Location = new System.Drawing.Point(33, 55);
            this.TxtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxNombre.Multiline = false;
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxNombre.PasswordChar = false;
            this.TxtBoxNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxNombre.PlaceholderText = "Nombre del proveedor";
            this.TxtBoxNombre.Size = new System.Drawing.Size(210, 35);
            this.TxtBoxNombre.TabIndex = 25;
            this.TxtBoxNombre.Texts = "";
            this.TxtBoxNombre.UnderlinedStyle = false;
            // 
            // TxtBoxTelefono
            // 
            this.TxtBoxTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxTelefono.BorderRadius = 0;
            this.TxtBoxTelefono.BorderSize = 2;
            this.TxtBoxTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxTelefono.Location = new System.Drawing.Point(32, 162);
            this.TxtBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxTelefono.Multiline = false;
            this.TxtBoxTelefono.Name = "TxtBoxTelefono";
            this.TxtBoxTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxTelefono.PasswordChar = false;
            this.TxtBoxTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxTelefono.PlaceholderText = "638-123-45-67";
            this.TxtBoxTelefono.Size = new System.Drawing.Size(207, 35);
            this.TxtBoxTelefono.TabIndex = 27;
            this.TxtBoxTelefono.Texts = "";
            this.TxtBoxTelefono.UnderlinedStyle = false;
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
            // NuevoProveedorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAjustes);
            this.Controls.Add(this.botonRedondo1);
            this.Name = "NuevoProveedorMenu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(876, 443);
            this.Load += new System.EventHandler(this.NuevoUsuario_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox TxtBoxTelefono;
        private CustomControls.RJControls.RJTextBox TxtBoxNombre;
        private BotonRedondo botonRedondo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
    }
}
