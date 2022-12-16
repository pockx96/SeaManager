namespace MarDeCortezDsk.Views
{
    partial class MenuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUser));
            this.BtnFolios = new FontAwesome.Sharp.IconButton();
            this.BtnInventario = new FontAwesome.Sharp.IconButton();
            this.BtnSesion = new FontAwesome.Sharp.IconButton();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.BtnOtros = new System.Windows.Forms.Button();
            this.BtnCamaron = new System.Windows.Forms.Button();
            this.BtnPescado = new System.Windows.Forms.Button();
            this.BtnNuevoFolio = new FontAwesome.Sharp.IconButton();
            this.BtnTienda = new FontAwesome.Sharp.IconButton();
            this.BtnProveedor = new FontAwesome.Sharp.IconButton();
            this.ContainerTileBar = new MarDeCortezDsk.UserControlls.SPanel();
            this.RelogContainer = new MarDeCortezDsk.UserControlls.Relog();
            this.CalendarioContainer = new MarDeCortezDsk.UserControlls.Calendario();
            this.TitleUsuario = new MarDeCortezDsk.UserControlls.BarraUsuario();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.PanelForm = new MarDeCortezDsk.UserControlls.SPanel();
            this.ContainerComponents = new System.Windows.Forms.Panel();
            this.circularImagen1 = new MarDeCortezDsk.UserControlls.CircularImagen();
            this.MenuContainer.SuspendLayout();
            this.ContainerTileBar.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFolios
            // 
            this.BtnFolios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnFolios.FlatAppearance.BorderSize = 0;
            this.BtnFolios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFolios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFolios.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFolios.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.BtnFolios.IconColor = System.Drawing.Color.White;
            this.BtnFolios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFolios.Location = new System.Drawing.Point(2, 3);
            this.BtnFolios.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFolios.Name = "BtnFolios";
            this.BtnFolios.Size = new System.Drawing.Size(151, 64);
            this.BtnFolios.TabIndex = 6;
            this.BtnFolios.Text = "Folios";
            this.BtnFolios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFolios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFolios.UseVisualStyleBackColor = false;
            this.BtnFolios.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtnInventario.IconColor = System.Drawing.Color.White;
            this.BtnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInventario.Location = new System.Drawing.Point(6, 231);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(148, 64);
            this.BtnInventario.TabIndex = 7;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnSesion
            // 
            this.BtnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnSesion.FlatAppearance.BorderSize = 0;
            this.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnSesion.IconColor = System.Drawing.Color.White;
            this.BtnSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSesion.Location = new System.Drawing.Point(0, 384);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.Size = new System.Drawing.Size(153, 64);
            this.BtnSesion.TabIndex = 9;
            this.BtnSesion.Text = "Cerrar sesión";
            this.BtnSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSesion.UseVisualStyleBackColor = false;
            this.BtnSesion.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuContainer.Controls.Add(this.BtnNuevoFolio);
            this.MenuContainer.Controls.Add(this.BtnOtros);
            this.MenuContainer.Controls.Add(this.BtnPescado);
            this.MenuContainer.Controls.Add(this.BtnCamaron);
            this.MenuContainer.Controls.Add(this.BtnTienda);
            this.MenuContainer.Controls.Add(this.BtnProveedor);
            this.MenuContainer.Controls.Add(this.BtnSesion);
            this.MenuContainer.Controls.Add(this.BtnInventario);
            this.MenuContainer.Controls.Add(this.BtnFolios);
            this.MenuContainer.Location = new System.Drawing.Point(0, 132);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(154, 448);
            this.MenuContainer.TabIndex = 13;
            // 
            // BtnOtros
            // 
            this.BtnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnOtros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOtros.FlatAppearance.BorderSize = 0;
            this.BtnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOtros.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOtros.Image = global::MarDeCortezDsk.Properties.Resources.seashell;
            this.BtnOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOtros.Location = new System.Drawing.Point(5, 322);
            this.BtnOtros.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOtros.Name = "BtnOtros";
            this.BtnOtros.Size = new System.Drawing.Size(151, 64);
            this.BtnOtros.TabIndex = 7;
            this.BtnOtros.Text = "   Otros";
            this.BtnOtros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOtros.UseVisualStyleBackColor = false;
            this.BtnOtros.Visible = false;
            this.BtnOtros.Click += new System.EventHandler(this.BtnOtros_Click);
            // 
            // BtnCamaron
            // 
            this.BtnCamaron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnCamaron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCamaron.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCamaron.FlatAppearance.BorderSize = 0;
            this.BtnCamaron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCamaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCamaron.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCamaron.Image = global::MarDeCortezDsk.Properties.Resources.shrimp_white;
            this.BtnCamaron.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCamaron.Location = new System.Drawing.Point(9, 258);
            this.BtnCamaron.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCamaron.Name = "BtnCamaron";
            this.BtnCamaron.Size = new System.Drawing.Size(151, 64);
            this.BtnCamaron.TabIndex = 5;
            this.BtnCamaron.Text = "   Camarón";
            this.BtnCamaron.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCamaron.UseVisualStyleBackColor = false;
            this.BtnCamaron.Visible = false;
            this.BtnCamaron.Click += new System.EventHandler(this.BtnCamaron_Click);
            // 
            // BtnPescado
            // 
            this.BtnPescado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnPescado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPescado.FlatAppearance.BorderSize = 0;
            this.BtnPescado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPescado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPescado.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPescado.Image = global::MarDeCortezDsk.Properties.Resources.fish_white;
            this.BtnPescado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPescado.Location = new System.Drawing.Point(6, 286);
            this.BtnPescado.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPescado.Name = "BtnPescado";
            this.BtnPescado.Size = new System.Drawing.Size(151, 64);
            this.BtnPescado.TabIndex = 6;
            this.BtnPescado.Text = "   Pescado";
            this.BtnPescado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPescado.UseVisualStyleBackColor = false;
            this.BtnPescado.Visible = false;
            this.BtnPescado.Click += new System.EventHandler(this.BtnPescado_Click);
            // 
            // BtnNuevoFolio
            // 
            this.BtnNuevoFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNuevoFolio.FlatAppearance.BorderSize = 0;
            this.BtnNuevoFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnNuevoFolio.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnNuevoFolio.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnNuevoFolio.IconColor = System.Drawing.Color.White;
            this.BtnNuevoFolio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevoFolio.Location = new System.Drawing.Point(2, 73);
            this.BtnNuevoFolio.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevoFolio.Name = "BtnNuevoFolio";
            this.BtnNuevoFolio.Size = new System.Drawing.Size(151, 64);
            this.BtnNuevoFolio.TabIndex = 13;
            this.BtnNuevoFolio.Text = "Nuevo folio";
            this.BtnNuevoFolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoFolio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevoFolio.UseVisualStyleBackColor = false;
            this.BtnNuevoFolio.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // BtnTienda
            // 
            this.BtnTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnTienda.FlatAppearance.BorderSize = 0;
            this.BtnTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnTienda.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnTienda.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.BtnTienda.IconColor = System.Drawing.Color.White;
            this.BtnTienda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTienda.Location = new System.Drawing.Point(2, 151);
            this.BtnTienda.Margin = new System.Windows.Forms.Padding(0);
            this.BtnTienda.Name = "BtnTienda";
            this.BtnTienda.Size = new System.Drawing.Size(151, 64);
            this.BtnTienda.TabIndex = 12;
            this.BtnTienda.Text = "Tienda";
            this.BtnTienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTienda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTienda.UseVisualStyleBackColor = false;
            this.BtnTienda.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProveedor.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.BtnProveedor.IconColor = System.Drawing.Color.White;
            this.BtnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProveedor.Location = new System.Drawing.Point(3, 301);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(154, 64);
            this.BtnProveedor.TabIndex = 11;
            this.BtnProveedor.Text = "Proveedores";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedor.UseVisualStyleBackColor = false;
            this.BtnProveedor.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // ContainerTileBar
            // 
            this.ContainerTileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ContainerTileBar.BorderColor = System.Drawing.Color.White;
            this.ContainerTileBar.Controls.Add(this.RelogContainer);
            this.ContainerTileBar.Controls.Add(this.CalendarioContainer);
            this.ContainerTileBar.Controls.Add(this.TitleUsuario);
            this.ContainerTileBar.Controls.Add(this.BtnBack);
            this.ContainerTileBar.Edge = 20;
            this.ContainerTileBar.Location = new System.Drawing.Point(159, 12);
            this.ContainerTileBar.Name = "ContainerTileBar";
            this.ContainerTileBar.Size = new System.Drawing.Size(876, 72);
            this.ContainerTileBar.TabIndex = 28;
            // 
            // RelogContainer
            // 
            this.RelogContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.RelogContainer.Location = new System.Drawing.Point(558, 18);
            this.RelogContainer.Name = "RelogContainer";
            this.RelogContainer.Size = new System.Drawing.Size(155, 38);
            this.RelogContainer.TabIndex = 16;
            // 
            // CalendarioContainer
            // 
            this.CalendarioContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.CalendarioContainer.Fecha = "15-12-2022";
            this.CalendarioContainer.Location = new System.Drawing.Point(732, 24);
            this.CalendarioContainer.Name = "CalendarioContainer";
            this.CalendarioContainer.Size = new System.Drawing.Size(131, 31);
            this.CalendarioContainer.TabIndex = 15;
            // 
            // TitleUsuario
            // 
            this.TitleUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.TitleUsuario.Location = new System.Drawing.Point(54, 22);
            this.TitleUsuario.Name = "TitleUsuario";
            this.TitleUsuario.Size = new System.Drawing.Size(131, 31);
            this.TitleUsuario.TabIndex = 14;
            // 
            // BtnBack
            // 
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.Location = new System.Drawing.Point(3, 18);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(40, 43);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PanelForm.BorderColor = System.Drawing.Color.White;
            this.PanelForm.Controls.Add(this.ContainerComponents);
            this.PanelForm.Edge = 20;
            this.PanelForm.Location = new System.Drawing.Point(159, 56);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Padding = new System.Windows.Forms.Padding(160, 15, 160, 0);
            this.PanelForm.Size = new System.Drawing.Size(876, 532);
            this.PanelForm.TabIndex = 14;
            // 
            // ContainerComponents
            // 
            this.ContainerComponents.Location = new System.Drawing.Point(0, 34);
            this.ContainerComponents.Name = "ContainerComponents";
            this.ContainerComponents.Size = new System.Drawing.Size(876, 500);
            this.ContainerComponents.TabIndex = 11;
            // 
            // circularImagen1
            // 
            this.circularImagen1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularImagen1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularImagen1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularImagen1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularImagen1.BorderSize = 2;
            this.circularImagen1.GradientAngle = 50F;
            this.circularImagen1.Image = global::MarDeCortezDsk.Properties.Resources.MicrosoftTeams_image;
            this.circularImagen1.Location = new System.Drawing.Point(12, 12);
            this.circularImagen1.Name = "circularImagen1";
            this.circularImagen1.Size = new System.Drawing.Size(113, 113);
            this.circularImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularImagen1.TabIndex = 11;
            this.circularImagen1.TabStop = false;
            // 
            // MenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.ContainerTileBar);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.circularImagen1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Manager";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.Move += new System.EventHandler(this.MenuAdmin_Move);
            this.MenuContainer.ResumeLayout(false);
            this.ContainerTileBar.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlls.CircularImagen circularImagen1;
        private UserControlls.BotonRedondo BtnCalculadoraCancelar;
        private UserControlls.SPanel PanelForm;
        private FontAwesome.Sharp.IconButton BtnFolios;
        private FontAwesome.Sharp.IconButton BtnInventario;
        private FontAwesome.Sharp.IconButton BtnSesion;
        private System.Windows.Forms.Panel MenuContainer;
        private FontAwesome.Sharp.IconButton BtnProveedor;
        private UserControlls.SPanel ContainerTileBar;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Panel ContainerComponents;
        private UserControlls.Relog RelogContainer;
        private UserControlls.Calendario CalendarioContainer;
        private UserControlls.BarraUsuario TitleUsuario;
        private FontAwesome.Sharp.IconButton BtnNuevoFolio;
        private FontAwesome.Sharp.IconButton BtnTienda;
        private System.Windows.Forms.Button BtnCamaron;
        private System.Windows.Forms.Button BtnPescado;
        private System.Windows.Forms.Button BtnOtros;
    }
}