namespace MarDeCortezDsk.UserControlls.FichasAdmin
{
    partial class CalculadoraFichas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatagridFolios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CxU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnFichas = new FontAwesome.Sharp.IconButton();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.sPanel1 = new MarDeCortezDsk.UserControlls.SPanel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.botonRedondo2 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridFolios)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatagridFolios
            // 
            this.DatagridFolios.AllowUserToAddRows = false;
            this.DatagridFolios.AllowUserToResizeColumns = false;
            this.DatagridFolios.AllowUserToResizeRows = false;
            this.DatagridFolios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DatagridFolios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DatagridFolios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridFolios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridFolios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DatagridFolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridFolios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Kilos,
            this.Column3,
            this.CxU,
            this.Total,
            this.borrar});
            this.DatagridFolios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridFolios.DefaultCellStyle = dataGridViewCellStyle10;
            this.DatagridFolios.EnableHeadersVisualStyles = false;
            this.DatagridFolios.Location = new System.Drawing.Point(32, 134);
            this.DatagridFolios.Name = "DatagridFolios";
            this.DatagridFolios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridFolios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DatagridFolios.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DatagridFolios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DatagridFolios.RowTemplate.Height = 42;
            this.DatagridFolios.Size = new System.Drawing.Size(573, 340);
            this.DatagridFolios.TabIndex = 10;
            this.DatagridFolios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellContentClick);
            this.DatagridFolios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellDoubleClick);
            this.DatagridFolios.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ListaEntrada_CellStateChanged);
            this.DatagridFolios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEntrada_CellValueChanged);
            this.DatagridFolios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListaEntrada_KeyPress);
            this.DatagridFolios.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ListaEntrada_PreviewKeyDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Presentación";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // Kilos
            // 
            this.Kilos.HeaderText = "Kilos";
            this.Kilos.Name = "Kilos";
            this.Kilos.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // CxU
            // 
            this.CxU.HeaderText = "Costo";
            this.CxU.Name = "CxU";
            this.CxU.Width = 70;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 70;
            // 
            // borrar
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "Eliminar";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1);
            this.borrar.DefaultCellStyle = dataGridViewCellStyle9;
            this.borrar.HeaderText = "";
            this.borrar.Name = "borrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(721, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(754, 364);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(103, 40);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Confirmar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnFichas
            // 
            this.BtnFichas.BackColor = System.Drawing.Color.White;
            this.BtnFichas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFichas.FlatAppearance.BorderSize = 0;
            this.BtnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFichas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnFichas.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnFichas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnFichas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFichas.IconSize = 30;
            this.BtnFichas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFichas.Location = new System.Drawing.Point(633, 367);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(90, 35);
            this.BtnFichas.TabIndex = 30;
            this.BtnFichas.Text = "Cotizar";
            this.BtnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.IconSize = 35;
            this.TitleBar.Location = new System.Drawing.Point(32, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(298, 62);
            this.TitleBar.TabIndex = 35;
            this.TitleBar.Text = "Registro de folios";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TitleBar.UseVisualStyleBackColor = false;
            this.TitleBar.Click += new System.EventHandler(this.TitleBar_Click_1);
            this.TitleBar.MouseEnter += new System.EventHandler(this.TitleBar_MouseEnter);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(754, 17);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(103, 36);
            this.iconButton2.TabIndex = 37;
            this.iconButton2.Text = "Excel";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.LblTotal);
            this.sPanel1.Edge = 20;
            this.sPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sPanel1.Location = new System.Drawing.Point(631, 209);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(235, 105);
            this.sPanel1.TabIndex = 17;
            this.sPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(77, 34);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 26);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "0.00 $";
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
            this.botonRedondo1.Location = new System.Drawing.Point(739, 361);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(133, 45);
            this.botonRedondo1.TabIndex = 38;
            this.botonRedondo1.Text = "botonRedondo1";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            // 
            // botonRedondo2
            // 
            this.botonRedondo2.BackColor = System.Drawing.Color.White;
            this.botonRedondo2.BackgroundColor = System.Drawing.Color.White;
            this.botonRedondo2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo2.BorderRadius = 20;
            this.botonRedondo2.BorderSize = 0;
            this.botonRedondo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo2.FlatAppearance.BorderSize = 0;
            this.botonRedondo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo2.ForeColor = System.Drawing.Color.White;
            this.botonRedondo2.Location = new System.Drawing.Point(623, 361);
            this.botonRedondo2.Name = "botonRedondo2";
            this.botonRedondo2.Size = new System.Drawing.Size(110, 46);
            this.botonRedondo2.TabIndex = 39;
            this.botonRedondo2.Text = "botonRedondo2";
            this.botonRedondo2.TextColor = System.Drawing.Color.White;
            this.botonRedondo2.UseVisualStyleBackColor = false;
            // 
            // CalculadoraFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnFichas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatagridFolios);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.botonRedondo1);
            this.Controls.Add(this.botonRedondo2);
            this.Name = "CalculadoraFichas";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.CalculadoraFichas_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CalculadoraFichas_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridFolios)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagridFolios;
        private SPanel sPanel1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnFichas;
        private FontAwesome.Sharp.IconButton TitleBar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private BotonRedondo botonRedondo1;
        private BotonRedondo botonRedondo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CxU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
    }
}
