namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class ProveedorConfig
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
            this.UsuariosContainer = new System.Windows.Forms.Panel();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // UsuariosContainer
            // 
            this.UsuariosContainer.Location = new System.Drawing.Point(0, 57);
            this.UsuariosContainer.Name = "UsuariosContainer";
            this.UsuariosContainer.Size = new System.Drawing.Size(876, 443);
            this.UsuariosContainer.TabIndex = 43;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.Location = new System.Drawing.Point(32, 2);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(445, 62);
            this.TitleBar.TabIndex = 44;
            this.TitleBar.Text = "Configuración de proveedores";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // ProveedorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.UsuariosContainer);
            this.Name = "ProveedorConfig";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.ProveedorConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UsuariosContainer;
        private FontAwesome.Sharp.IconButton TitleBar;
    }
}
