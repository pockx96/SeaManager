namespace MarDeCortezDsk.Views
{
    partial class ProvedorShowDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvedorShowDialog));
            this.ContainerForm = new MarDeCortezDsk.UserControlls.SPanel();
            this.ContainerTileBar = new MarDeCortezDsk.UserControlls.SPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.ContainerProveedor = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUser = new FontAwesome.Sharp.IconButton();
            this.BtnProveedorAdd = new System.Windows.Forms.Button();
            this.BtnCalculadoraTotal = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.CmBoxProveedores = new System.Windows.Forms.ComboBox();
            this.ContainerForm.SuspendLayout();
            this.ContainerTileBar.SuspendLayout();
            this.ContainerProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerForm
            // 
            this.ContainerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ContainerForm.BorderColor = System.Drawing.Color.White;
            this.ContainerForm.Controls.Add(this.ContainerTileBar);
            this.ContainerForm.Controls.Add(this.ContainerProveedor);
            this.ContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerForm.Edge = 20;
            this.ContainerForm.Location = new System.Drawing.Point(10, 10);
            this.ContainerForm.Name = "ContainerForm";
            this.ContainerForm.Padding = new System.Windows.Forms.Padding(10, 75, 10, 10);
            this.ContainerForm.Size = new System.Drawing.Size(337, 536);
            this.ContainerForm.TabIndex = 13;
            this.ContainerForm.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // ContainerTileBar
            // 
            this.ContainerTileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ContainerTileBar.BorderColor = System.Drawing.Color.White;
            this.ContainerTileBar.Controls.Add(this.iconButton2);
            this.ContainerTileBar.Controls.Add(this.TitleBar);
            this.ContainerTileBar.Edge = 20;
            this.ContainerTileBar.Location = new System.Drawing.Point(0, 0);
            this.ContainerTileBar.Name = "ContainerTileBar";
            this.ContainerTileBar.Size = new System.Drawing.Size(337, 72);
            this.ContainerTileBar.TabIndex = 32;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(47, 72);
            this.iconButton2.TabIndex = 28;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.IconSize = 35;
            this.TitleBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.Location = new System.Drawing.Point(31, 6);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TitleBar.Size = new System.Drawing.Size(296, 62);
            this.TitleBar.TabIndex = 10;
            this.TitleBar.Text = "Selección de proveedor";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // ContainerProveedor
            // 
            this.ContainerProveedor.Controls.Add(this.label5);
            this.ContainerProveedor.Controls.Add(this.BtnUser);
            this.ContainerProveedor.Controls.Add(this.BtnProveedorAdd);
            this.ContainerProveedor.Controls.Add(this.BtnCalculadoraTotal);
            this.ContainerProveedor.Controls.Add(this.LblProveedor);
            this.ContainerProveedor.Controls.Add(this.CmBoxProveedores);
            this.ContainerProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerProveedor.Location = new System.Drawing.Point(10, 75);
            this.ContainerProveedor.Name = "ContainerProveedor";
            this.ContainerProveedor.Size = new System.Drawing.Size(317, 451);
            this.ContainerProveedor.TabIndex = 34;
            this.ContainerProveedor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(43, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "_____________________________________";
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnUser.IconColor = System.Drawing.Color.White;
            this.BtnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUser.IconSize = 80;
            this.BtnUser.Location = new System.Drawing.Point(123, 19);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(71, 85);
            this.BtnUser.TabIndex = 31;
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUser.UseVisualStyleBackColor = false;
            // 
            // BtnProveedorAdd
            // 
            this.BtnProveedorAdd.FlatAppearance.BorderSize = 0;
            this.BtnProveedorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedorAdd.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedorAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnProveedorAdd.Location = new System.Drawing.Point(44, 397);
            this.BtnProveedorAdd.Name = "BtnProveedorAdd";
            this.BtnProveedorAdd.Size = new System.Drawing.Size(228, 28);
            this.BtnProveedorAdd.TabIndex = 33;
            this.BtnProveedorAdd.Text = "Agregar un nuevo proveedor";
            this.BtnProveedorAdd.UseVisualStyleBackColor = true;
            this.BtnProveedorAdd.Click += new System.EventHandler(this.BtnProveedorAdd_Click);
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
            this.BtnCalculadoraTotal.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculadoraTotal.ForeColor = System.Drawing.Color.White;
            this.BtnCalculadoraTotal.Location = new System.Drawing.Point(37, 339);
            this.BtnCalculadoraTotal.Name = "BtnCalculadoraTotal";
            this.BtnCalculadoraTotal.Size = new System.Drawing.Size(243, 40);
            this.BtnCalculadoraTotal.TabIndex = 12;
            this.BtnCalculadoraTotal.Text = "Confirmar";
            this.BtnCalculadoraTotal.TextColor = System.Drawing.Color.White;
            this.BtnCalculadoraTotal.UseVisualStyleBackColor = false;
            this.BtnCalculadoraTotal.Click += new System.EventHandler(this.BtnCalculadoraTotal_Click);
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.LblProveedor.Location = new System.Drawing.Point(63, 116);
            this.LblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(190, 26);
            this.LblProveedor.TabIndex = 9;
            this.LblProveedor.Text = "Elija un Proveedor";
            // 
            // CmBoxProveedores
            // 
            this.CmBoxProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxProveedores.FormattingEnabled = true;
            this.CmBoxProveedores.Location = new System.Drawing.Point(46, 194);
            this.CmBoxProveedores.Name = "CmBoxProveedores";
            this.CmBoxProveedores.Size = new System.Drawing.Size(224, 28);
            this.CmBoxProveedores.TabIndex = 10;
            // 
            // ProvedorShowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(357, 556);
            this.Controls.Add(this.ContainerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProvedorShowDialog";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccione un Proveedor";
            this.Load += new System.EventHandler(this.ProvedorShowDialog_Load);
            this.ContainerForm.ResumeLayout(false);
            this.ContainerTileBar.ResumeLayout(false);
            this.ContainerProveedor.ResumeLayout(false);
            this.ContainerProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmBoxProveedores;
        private System.Windows.Forms.Label LblProveedor;
        private UserControlls.BotonRedondo BtnCalculadoraTotal;
        private UserControlls.SPanel ContainerForm;
        private FontAwesome.Sharp.IconButton BtnUser;
        private UserControlls.SPanel ContainerTileBar;
        private FontAwesome.Sharp.IconButton TitleBar;
        private System.Windows.Forms.GroupBox ContainerProveedor;
        private System.Windows.Forms.Button BtnProveedorAdd;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}