namespace MarDeCortezDsk.Views
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.BtnFichas = new FontAwesome.Sharp.IconButton();
            this.BtnInventario = new FontAwesome.Sharp.IconButton();
            this.BtnUser = new FontAwesome.Sharp.IconButton();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.BtnProducto = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnAjustes = new FontAwesome.Sharp.IconButton();
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
            // BtnFichas
            // 
            this.BtnFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnFichas.FlatAppearance.BorderSize = 0;
            this.BtnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFichas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFichas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.BtnFichas.IconColor = System.Drawing.Color.White;
            this.BtnFichas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFichas.Location = new System.Drawing.Point(11, 3);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(140, 64);
            this.BtnFichas.TabIndex = 6;
            this.BtnFichas.Text = "Folios";
            this.BtnFichas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            this.BtnFichas.MouseHover += new System.EventHandler(this.BtnFichas_MouseHover);
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
            this.BtnInventario.Location = new System.Drawing.Point(11, 73);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(140, 64);
            this.BtnInventario.TabIndex = 7;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            this.BtnInventario.MouseHover += new System.EventHandler(this.BtnInventario_MouseHover);
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUser.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnUser.IconColor = System.Drawing.Color.White;
            this.BtnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUser.Location = new System.Drawing.Point(13, 384);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(140, 64);
            this.BtnUser.TabIndex = 9;
            this.BtnUser.Text = "Sesión";
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            this.BtnUser.MouseHover += new System.EventHandler(this.BtnUser_MouseHover);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuContainer.Controls.Add(this.BtnProducto);
            this.MenuContainer.Controls.Add(this.iconButton1);
            this.MenuContainer.Controls.Add(this.BtnAjustes);
            this.MenuContainer.Controls.Add(this.BtnUser);
            this.MenuContainer.Controls.Add(this.BtnInventario);
            this.MenuContainer.Controls.Add(this.BtnFichas);
            this.MenuContainer.Location = new System.Drawing.Point(0, 132);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(154, 448);
            this.MenuContainer.TabIndex = 13;
            this.MenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuContainer_Paint);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnProducto.FlatAppearance.BorderSize = 0;
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProducto.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.BtnProducto.IconColor = System.Drawing.Color.White;
            this.BtnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProducto.Location = new System.Drawing.Point(3, 311);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(156, 64);
            this.BtnProducto.TabIndex = 12;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 230);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(156, 64);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Proveedores";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAjustes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAjustes.IconColor = System.Drawing.Color.White;
            this.BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAjustes.Location = new System.Drawing.Point(12, 149);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Size = new System.Drawing.Size(140, 64);
            this.BtnAjustes.TabIndex = 10;
            this.BtnAjustes.Text = "Usuarios";
            this.BtnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjustes.UseVisualStyleBackColor = false;
            this.BtnAjustes.Click += new System.EventHandler(this.BtnAjustes_Click_1);
            // 
            // ContainerTileBar
            // 
            this.ContainerTileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
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
            this.RelogContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RelogContainer.Location = new System.Drawing.Point(558, 18);
            this.RelogContainer.Name = "RelogContainer";
            this.RelogContainer.Size = new System.Drawing.Size(155, 38);
            this.RelogContainer.TabIndex = 16;
            // 
            // CalendarioContainer
            // 
            this.CalendarioContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CalendarioContainer.Fecha = "28-11-2022";
            this.CalendarioContainer.Location = new System.Drawing.Point(732, 24);
            this.CalendarioContainer.Name = "CalendarioContainer";
            this.CalendarioContainer.Size = new System.Drawing.Size(131, 31);
            this.CalendarioContainer.TabIndex = 15;
            // 
            // TitleUsuario
            // 
            this.TitleUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
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
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
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
            // MenuAdmin
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
            this.Name = "MenuAdmin";
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
        private FontAwesome.Sharp.IconButton BtnFichas;
        private FontAwesome.Sharp.IconButton BtnInventario;
        private FontAwesome.Sharp.IconButton BtnUser;
        private System.Windows.Forms.Panel MenuContainer;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnAjustes;
        private UserControlls.SPanel ContainerTileBar;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Panel ContainerComponents;
        private UserControlls.Relog RelogContainer;
        private UserControlls.Calendario CalendarioContainer;
        private UserControlls.BarraUsuario TitleUsuario;
        private FontAwesome.Sharp.IconButton BtnProducto;
    }
}