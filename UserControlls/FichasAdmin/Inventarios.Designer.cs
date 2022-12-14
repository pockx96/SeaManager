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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.CmboxProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DatagridInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Producto,
            this.Presentación,
            this.Cantidad,
            this.Kilos});
            this.DatagridInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridInventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.DatagridInventario.EnableHeadersVisualStyles = false;
            this.DatagridInventario.Location = new System.Drawing.Point(72, 89);
            this.DatagridInventario.Name = "DatagridInventario";
            this.DatagridInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DatagridInventario.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DatagridInventario.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            this.TxtBoxSearch.Location = new System.Drawing.Point(112, 26);
            this.TxtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxSearch.Multiline = false;
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxSearch.PasswordChar = false;
            this.TxtBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxSearch.PlaceholderText = "";
            this.TxtBoxSearch.Size = new System.Drawing.Size(339, 31);
            this.TxtBoxSearch.TabIndex = 23;
            this.TxtBoxSearch.Texts = "";
            this.TxtBoxSearch.UnderlinedStyle = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
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
            this.iconButton3.Location = new System.Drawing.Point(14, 384);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(103, 36);
            this.iconButton3.TabIndex = 39;
            this.iconButton3.Text = "Excel";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // BtnBitacora
            // 
            this.BtnBitacora.BackColor = System.Drawing.Color.Transparent;
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
            this.BtnBitacora.Location = new System.Drawing.Point(146, 384);
            this.BtnBitacora.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBitacora.Name = "BtnBitacora";
            this.BtnBitacora.Size = new System.Drawing.Size(126, 36);
            this.BtnBitacora.TabIndex = 40;
            this.BtnBitacora.Text = "Bitacora";
            this.BtnBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBitacora.UseVisualStyleBackColor = false;
            this.BtnBitacora.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(556, 107);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(120, 40);
            this.iconButton2.TabIndex = 41;
            this.iconButton2.Text = "Salidas";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_2);
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
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(531, 104);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(160, 45);
            this.botonRedondo1.TabIndex = 42;
            this.botonRedondo1.Text = "botonRedondo1";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // CmboxProveedor
            // 
            this.CmboxProveedor.FormattingEnabled = true;
            this.CmboxProveedor.Location = new System.Drawing.Point(546, 35);
            this.CmboxProveedor.Name = "CmboxProveedor";
            this.CmboxProveedor.Size = new System.Drawing.Size(121, 21);
            this.CmboxProveedor.TabIndex = 43;
            this.CmboxProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.CmboxProveedor);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.botonRedondo1);
            this.Controls.Add(this.BtnBitacora);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.DatagridInventario);
            this.Controls.Add(this.BtnSearch);
            this.Name = "Inventarios";
            this.Size = new System.Drawing.Size(691, 440);
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridInventario)).EndInit();
            this.ResumeLayout(false);

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
        private FontAwesome.Sharp.IconButton iconButton2;
        private BotonRedondo botonRedondo1;
        private System.Windows.Forms.ComboBox CmboxProveedor;
    }
}
