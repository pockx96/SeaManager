namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class CalculadoraEntradas
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
            this.IconCenterLeft = new FontAwesome.Sharp.IconButton();
            this.IconRight = new FontAwesome.Sharp.IconButton();
            this.IconLeft = new FontAwesome.Sharp.IconButton();
            this.IconCenterRight = new FontAwesome.Sharp.IconButton();
            this.LblFicha = new System.Windows.Forms.Label();
            this.IconFicha = new System.Windows.Forms.PictureBox();
            this.FichasContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconFicha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.IconCenterLeft);
            this.panel1.Controls.Add(this.IconRight);
            this.panel1.Controls.Add(this.IconLeft);
            this.panel1.Controls.Add(this.IconCenterRight);
            this.panel1.Controls.Add(this.LblFicha);
            this.panel1.Controls.Add(this.IconFicha);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 51);
            this.panel1.TabIndex = 12;
            // 
            // IconCenterLeft
            // 
            this.IconCenterLeft.FlatAppearance.BorderSize = 0;
            this.IconCenterLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconCenterLeft.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.IconCenterLeft.IconColor = System.Drawing.Color.Silver;
            this.IconCenterLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCenterLeft.Location = new System.Drawing.Point(610, 9);
            this.IconCenterLeft.Name = "IconCenterLeft";
            this.IconCenterLeft.Size = new System.Drawing.Size(43, 36);
            this.IconCenterLeft.TabIndex = 19;
            this.IconCenterLeft.UseVisualStyleBackColor = true;
            this.IconCenterLeft.Click += new System.EventHandler(this.IconCenterLeft_Click);
            // 
            // IconRight
            // 
            this.IconRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IconRight.FlatAppearance.BorderSize = 0;
            this.IconRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconRight.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.IconRight.IconColor = System.Drawing.Color.White;
            this.IconRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconRight.Location = new System.Drawing.Point(659, 9);
            this.IconRight.Name = "IconRight";
            this.IconRight.Size = new System.Drawing.Size(43, 36);
            this.IconRight.TabIndex = 18;
            this.IconRight.UseVisualStyleBackColor = false;
            this.IconRight.Click += new System.EventHandler(this.IconRight_Click);
            // 
            // IconLeft
            // 
            this.IconLeft.Enabled = false;
            this.IconLeft.FlatAppearance.BorderSize = 0;
            this.IconLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconLeft.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.IconLeft.IconColor = System.Drawing.Color.Silver;
            this.IconLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconLeft.Location = new System.Drawing.Point(610, 9);
            this.IconLeft.Name = "IconLeft";
            this.IconLeft.Size = new System.Drawing.Size(43, 36);
            this.IconLeft.TabIndex = 17;
            this.IconLeft.UseVisualStyleBackColor = true;
            this.IconLeft.Click += new System.EventHandler(this.IconLeft_Click);
            // 
            // IconCenterRight
            // 
            this.IconCenterRight.FlatAppearance.BorderSize = 0;
            this.IconCenterRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconCenterRight.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.IconCenterRight.IconColor = System.Drawing.Color.White;
            this.IconCenterRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCenterRight.Location = new System.Drawing.Point(659, 9);
            this.IconCenterRight.Name = "IconCenterRight";
            this.IconCenterRight.Size = new System.Drawing.Size(43, 36);
            this.IconCenterRight.TabIndex = 16;
            this.IconCenterRight.UseVisualStyleBackColor = true;
            this.IconCenterRight.Click += new System.EventHandler(this.IconCenterRight_Click);
            // 
            // LblFicha
            // 
            this.LblFicha.AutoSize = true;
            this.LblFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFicha.ForeColor = System.Drawing.SystemColors.Control;
            this.LblFicha.Location = new System.Drawing.Point(54, 17);
            this.LblFicha.Name = "LblFicha";
            this.LblFicha.Size = new System.Drawing.Size(87, 24);
            this.LblFicha.TabIndex = 14;
            this.LblFicha.Text = "Camaron";
            // 
            // IconFicha
            // 
            this.IconFicha.Image = global::MarDeCortezDsk.Properties.Resources.shrimp_white;
            this.IconFicha.Location = new System.Drawing.Point(6, 9);
            this.IconFicha.Name = "IconFicha";
            this.IconFicha.Size = new System.Drawing.Size(43, 36);
            this.IconFicha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconFicha.TabIndex = 13;
            this.IconFicha.TabStop = false;
            // 
            // FichasContainer
            // 
            this.FichasContainer.Location = new System.Drawing.Point(15, 82);
            this.FichasContainer.Name = "FichasContainer";
            this.FichasContainer.Size = new System.Drawing.Size(583, 266);
            this.FichasContainer.TabIndex = 18;
            // 
            // CalculadoraEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.FichasContainer);
            this.Controls.Add(this.panel1);
            this.Name = "CalculadoraEntradas";
            this.Size = new System.Drawing.Size(742, 360);
            this.Load += new System.EventHandler(this.CalculadoraEntradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconFicha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IconCenterLeft;
        private FontAwesome.Sharp.IconButton IconRight;
        private FontAwesome.Sharp.IconButton IconLeft;
        private FontAwesome.Sharp.IconButton IconCenterRight;
        private System.Windows.Forms.Label LblFicha;
        private System.Windows.Forms.PictureBox IconFicha;
        private System.Windows.Forms.Panel FichasContainer;
    }
}
