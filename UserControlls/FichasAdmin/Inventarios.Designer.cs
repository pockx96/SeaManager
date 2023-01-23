namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class Inventarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.DatagridInventario = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxSearch = new CustomControls.RJControls.RJTextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.BtnBitacora = new FontAwesome.Sharp.IconButton();
            this.BtnSalidas = new FontAwesome.Sharp.IconButton();
            this.BackgroundSalidas = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.CmboxProveedor = new System.Windows.Forms.ComboBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.btnTienda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.Color.White;
            this.BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearch.IconSize = 30;
            this.BtnSearch.Location = new System.Drawing.Point(458, 23);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(35, 34);
            this.BtnSearch.TabIndex = 28;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DatagridInventario
            // 
            this.DatagridInventario.AllowUserToAddRows = false;
            this.DatagridInventario.AllowUserToResizeColumns = false;
            this.DatagridInventario.AllowUserToResizeRows = false;
            this.DatagridInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DatagridInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DatagridInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Producto,
            this.Presentación,
            this.Cantidad,
            this.Kilos});
            this.DatagridInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridInventario.EnableHeadersVisualStyles = false;
            this.DatagridInventario.Location = new System.Drawing.Point(78, 97);
            this.DatagridInventario.Name = "DatagridInventario";
            this.DatagridInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridInventario.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DatagridInventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridInventario.RowTemplate.Height = 34;
            this.DatagridInventario.Size = new System.Drawing.Size(443, 283);
            this.DatagridInventario.TabIndex = 27;
            this.DatagridInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridInventario_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 120;
            // 
            // Presentación
            // 
            this.Presentación.HeaderText = "Presentación";
            this.Presentación.Name = "Presentación";
            this.Presentación.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 85;
            // 
            // Kilos
            // 
            this.Kilos.HeaderText = "Kilos";
            this.Kilos.Name = "Kilos";
            this.Kilos.Width = 85;
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxSearch.BorderRadius = 0;
            this.TxtBoxSearch.BorderSize = 2;
            this.TxtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxSearch.Location = new System.Drawing.Point(78, 26);
            this.TxtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxSearch.Multiline = false;
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxSearch.PasswordChar = false;
            this.TxtBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxSearch.PlaceholderText = "";
            this.TxtBoxSearch.Size = new System.Drawing.Size(373, 31);
            this.TxtBoxSearch.TabIndex = 23;
            this.TxtBoxSearch.Texts = "";
            this.TxtBoxSearch.UnderlinedStyle = false;
            this.TxtBoxSearch._TextChanged += new System.EventHandler(this.TxtBoxSearch__TextChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButton3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(60, 452);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(103, 36);
            this.iconButton3.TabIndex = 39;
            this.iconButton3.Text = "Excel";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            this.iconButton3.MouseHover += new System.EventHandler(this.iconButton3_MouseHover);
            // 
            // BtnBitacora
            // 
            this.BtnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BtnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBitacora.FlatAppearance.BorderSize = 0;
            this.BtnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBitacora.ForeColor = System.Drawing.Color.White;
            this.BtnBitacora.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.BtnBitacora.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBitacora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBitacora.IconSize = 30;
            this.BtnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBitacora.Location = new System.Drawing.Point(198, 452);
            this.BtnBitacora.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBitacora.Name = "BtnBitacora";
            this.BtnBitacora.Size = new System.Drawing.Size(126, 36);
            this.BtnBitacora.TabIndex = 40;
            this.BtnBitacora.Text = "Bitacora";
            this.BtnBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBitacora.UseVisualStyleBackColor = false;
            this.BtnBitacora.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // BtnSalidas
            // 
            this.BtnSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalidas.FlatAppearance.BorderSize = 0;
            this.BtnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSalidas.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.BtnSalidas.IconColor = System.Drawing.Color.White;
            this.BtnSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalidas.IconSize = 40;
            this.BtnSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalidas.Location = new System.Drawing.Point(626, 310);
            this.BtnSalidas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSalidas.Name = "BtnSalidas";
            this.BtnSalidas.Size = new System.Drawing.Size(214, 48);
            this.BtnSalidas.TabIndex = 41;
            this.BtnSalidas.Text = "Salida de producto";
            this.BtnSalidas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSalidas.UseVisualStyleBackColor = false;
            this.BtnSalidas.Click += new System.EventHandler(this.iconButton2_Click_2);
            this.BtnSalidas.MouseEnter += new System.EventHandler(this.BtnSalidas_MouseEnter);
            this.BtnSalidas.MouseHover += new System.EventHandler(this.BtnSalidas_MouseHover);
            // 
            // BackgroundSalidas
            // 
            this.BackgroundSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BackgroundSalidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BackgroundSalidas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BackgroundSalidas.BorderRadius = 20;
            this.BackgroundSalidas.BorderSize = 0;
            this.BackgroundSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackgroundSalidas.FlatAppearance.BorderSize = 0;
            this.BackgroundSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundSalidas.ForeColor = System.Drawing.Color.White;
            this.BackgroundSalidas.Location = new System.Drawing.Point(612, 305);
            this.BackgroundSalidas.Name = "BackgroundSalidas";
            this.BackgroundSalidas.Size = new System.Drawing.Size(242, 57);
            this.BackgroundSalidas.TabIndex = 42;
            this.BackgroundSalidas.TextColor = System.Drawing.Color.White;
            this.BackgroundSalidas.UseVisualStyleBackColor = false;
            this.BackgroundSalidas.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // CmboxProveedor
            // 
            this.CmboxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboxProveedor.FormattingEnabled = true;
            this.CmboxProveedor.Location = new System.Drawing.Point(472, 36);
            this.CmboxProveedor.Name = "CmboxProveedor";
            this.CmboxProveedor.Size = new System.Drawing.Size(121, 24);
            this.CmboxProveedor.TabIndex = 43;
            this.CmboxProveedor.Visible = false;
            this.CmboxProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.LblProveedor.Location = new System.Drawing.Point(478, 13);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(98, 20);
            this.LblProveedor.TabIndex = 44;
            this.LblProveedor.Text = "Proveedores";
            this.LblProveedor.Visible = false;
            // 
            // btnTienda
            // 
            this.btnTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTienda.FlatAppearance.BorderSize = 0;
            this.btnTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienda.ForeColor = System.Drawing.Color.White;
            this.btnTienda.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTienda.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTienda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTienda.IconSize = 30;
            this.btnTienda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTienda.Location = new System.Drawing.Point(728, 21);
            this.btnTienda.Margin = new System.Windows.Forms.Padding(0);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(126, 36);
            this.btnTienda.TabIndex = 45;
            this.btnTienda.Text = "Tienda";
            this.btnTienda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTienda.UseVisualStyleBackColor = false;
            this.btnTienda.Click += new System.EventHandler(this.iconButton1_Click_1);
            this.btnTienda.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.btnTienda.MouseHover += new System.EventHandler(this.btnTienda_MouseHover);
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.CmboxProveedor);
            this.Controls.Add(this.BtnSalidas);
            this.Controls.Add(this.BackgroundSalidas);
            this.Controls.Add(this.BtnBitacora);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.DatagridInventario);
            this.Controls.Add(this.BtnSearch);
            this.Name = "Inventarios";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJTextBox TxtBoxSearch;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private System.Windows.Forms.DataGridView DatagridInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilos;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton BtnBitacora;
        private FontAwesome.Sharp.IconButton BtnSalidas;
        private BotonRedondo BackgroundSalidas;
        private System.Windows.Forms.ComboBox CmboxProveedor;
        private System.Windows.Forms.Label LblProveedor;
        private FontAwesome.Sharp.IconButton btnTienda;
    }
}
