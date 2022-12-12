namespace MarDeCortezDsk.UserControlls
{
    partial class PescadoFicha
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
            this.PescadoContainer = new System.Windows.Forms.Panel();
            this.DatosGroupBox = new System.Windows.Forms.GroupBox();
            this.CmBoxPreEntero = new System.Windows.Forms.ComboBox();
            this.CmBoxPreEmpaquetado = new System.Windows.Forms.ComboBox();
            this.RBtnEmpaquetado = new System.Windows.Forms.RadioButton();
            this.CmBoxEntero = new System.Windows.Forms.ComboBox();
            this.CmBoxPaquete = new System.Windows.Forms.ComboBox();
            this.RbtnEntero = new System.Windows.Forms.RadioButton();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtboxCantidad = new System.Windows.Forms.TextBox();
            this.LblPresentacion = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PescadoContainer.SuspendLayout();
            this.DatosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PescadoContainer
            // 
            this.PescadoContainer.Controls.Add(this.DatosGroupBox);
            this.PescadoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PescadoContainer.Location = new System.Drawing.Point(0, 0);
            this.PescadoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PescadoContainer.Name = "PescadoContainer";
            this.PescadoContainer.Size = new System.Drawing.Size(486, 350);
            this.PescadoContainer.TabIndex = 3;
            this.PescadoContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PescadoContainer_Paint);
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.CmBoxPreEntero);
            this.DatosGroupBox.Controls.Add(this.label3);
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.CmBoxEntero);
            this.DatosGroupBox.Controls.Add(this.CmBoxPreEmpaquetado);
            this.DatosGroupBox.Controls.Add(this.RBtnEmpaquetado);
            this.DatosGroupBox.Controls.Add(this.CmBoxPaquete);
            this.DatosGroupBox.Controls.Add(this.RbtnEntero);
            this.DatosGroupBox.Controls.Add(this.LblCantidad);
            this.DatosGroupBox.Controls.Add(this.LblProducto);
            this.DatosGroupBox.Controls.Add(this.TxtboxCantidad);
            this.DatosGroupBox.Controls.Add(this.LblPresentacion);
            this.DatosGroupBox.Controls.Add(this.LblTipo);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DatosGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.DatosGroupBox.Location = new System.Drawing.Point(119, 3);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(271, 342);
            this.DatosGroupBox.TabIndex = 23;
            this.DatosGroupBox.TabStop = false;
            this.DatosGroupBox.Enter += new System.EventHandler(this.DatosGroupBox_Enter);
            // 
            // CmBoxPreEntero
            // 
            this.CmBoxPreEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxPreEntero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.CmBoxPreEntero.FormattingEnabled = true;
            this.CmBoxPreEntero.Items.AddRange(new object[] {
            "Para el disco",
            "100 - 500 Mgr",
            "500 - 800 Mgr",
            "800 - 1.2 Kg",
            "1.2 - 1.5 Kg",
            "1.5 - 2 Kg",
            "3 - 4 Kg",
            "5 Kg",
            "6 kg",
            "7 Kg",
            "8 Kg",
            "9 Kg",
            "10 Kg"});
            this.CmBoxPreEntero.Location = new System.Drawing.Point(214, 272);
            this.CmBoxPreEntero.Name = "CmBoxPreEntero";
            this.CmBoxPreEntero.Size = new System.Drawing.Size(162, 24);
            this.CmBoxPreEntero.TabIndex = 18;
            // 
            // CmBoxPreEmpaquetado
            // 
            this.CmBoxPreEmpaquetado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxPreEmpaquetado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.CmBoxPreEmpaquetado.FormattingEnabled = true;
            this.CmBoxPreEmpaquetado.Items.AddRange(new object[] {
            "Dos kilos",
            "Cinco kilos",
            "Diez Kilos",
            "Al Vacio"});
            this.CmBoxPreEmpaquetado.Location = new System.Drawing.Point(24, 208);
            this.CmBoxPreEmpaquetado.Name = "CmBoxPreEmpaquetado";
            this.CmBoxPreEmpaquetado.Size = new System.Drawing.Size(162, 24);
            this.CmBoxPreEmpaquetado.TabIndex = 17;
            // 
            // RBtnEmpaquetado
            // 
            this.RBtnEmpaquetado.AutoSize = true;
            this.RBtnEmpaquetado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RBtnEmpaquetado.Location = new System.Drawing.Point(111, 57);
            this.RBtnEmpaquetado.Name = "RBtnEmpaquetado";
            this.RBtnEmpaquetado.Size = new System.Drawing.Size(128, 24);
            this.RBtnEmpaquetado.TabIndex = 16;
            this.RBtnEmpaquetado.Text = "Empaquetado";
            this.RBtnEmpaquetado.UseVisualStyleBackColor = true;
            this.RBtnEmpaquetado.CheckedChanged += new System.EventHandler(this.RBtnEmpaquetado_CheckedChanged);
            // 
            // CmBoxEntero
            // 
            this.CmBoxEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxEntero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.CmBoxEntero.FormattingEnabled = true;
            this.CmBoxEntero.Items.AddRange(new object[] {
            "Palometa",
            "Curvina",
            "Pampano",
            "Mojarra",
            "Extranjero",
            "Pargo",
            "Baqueta",
            "Baya",
            "Botete"});
            this.CmBoxEntero.Location = new System.Drawing.Point(205, 208);
            this.CmBoxEntero.Name = "CmBoxEntero";
            this.CmBoxEntero.Size = new System.Drawing.Size(162, 24);
            this.CmBoxEntero.TabIndex = 15;
            // 
            // CmBoxPaquete
            // 
            this.CmBoxPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBoxPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.CmBoxPaquete.FormattingEnabled = true;
            this.CmBoxPaquete.Items.AddRange(new object[] {
            "Lenguado",
            "Manta",
            "Cazon",
            "Cochito",
            "Cochito Picado",
            "Atun",
            "Malin Ahumado",
            "Atun Aumado",
            "Merluza",
            "Guitarra",
            "Angelito",
            "Baya",
            "Jurel",
            "Bass"});
            this.CmBoxPaquete.Location = new System.Drawing.Point(24, 132);
            this.CmBoxPaquete.Name = "CmBoxPaquete";
            this.CmBoxPaquete.Size = new System.Drawing.Size(162, 24);
            this.CmBoxPaquete.TabIndex = 14;
            this.CmBoxPaquete.SelectedIndexChanged += new System.EventHandler(this.CmBoxPaquete_SelectedIndexChanged);
            // 
            // RbtnEntero
            // 
            this.RbtnEntero.AutoSize = true;
            this.RbtnEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RbtnEntero.Location = new System.Drawing.Point(24, 57);
            this.RbtnEntero.Name = "RbtnEntero";
            this.RbtnEntero.Size = new System.Drawing.Size(75, 24);
            this.RbtnEntero.TabIndex = 11;
            this.RbtnEntero.Text = "Entero";
            this.RbtnEntero.UseVisualStyleBackColor = true;
            this.RbtnEntero.CheckedChanged += new System.EventHandler(this.RbtnEntero_CheckedChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblCantidad.Location = new System.Drawing.Point(20, 272);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(86, 20);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblProducto.Location = new System.Drawing.Point(20, 109);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(86, 20);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Text = "Producto:";
            this.LblProducto.Click += new System.EventHandler(this.LblProducto_Click);
            // 
            // TxtboxCantidad
            // 
            this.TxtboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(102)))));
            this.TxtboxCantidad.Location = new System.Drawing.Point(24, 295);
            this.TxtboxCantidad.Name = "TxtboxCantidad";
            this.TxtboxCantidad.Size = new System.Drawing.Size(162, 22);
            this.TxtboxCantidad.TabIndex = 5;
            // 
            // LblPresentacion
            // 
            this.LblPresentacion.AutoSize = true;
            this.LblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblPresentacion.Location = new System.Drawing.Point(20, 183);
            this.LblPresentacion.Name = "LblPresentacion";
            this.LblPresentacion.Size = new System.Drawing.Size(119, 20);
            this.LblPresentacion.TabIndex = 4;
            this.LblPresentacion.Text = "Presentacion:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblTipo.Location = new System.Drawing.Point(20, 22);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(142, 20);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo de Pescado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "_________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "_________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "_________________________________";
            // 
            // PescadoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.PescadoContainer);
            this.Name = "PescadoFicha";
            this.Size = new System.Drawing.Size(486, 350);
            this.PescadoContainer.ResumeLayout(false);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PescadoContainer;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtboxCantidad;
        private System.Windows.Forms.Label LblPresentacion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.RadioButton RbtnEntero;
        private System.Windows.Forms.ComboBox CmBoxEntero;
        private System.Windows.Forms.ComboBox CmBoxPaquete;
        private System.Windows.Forms.RadioButton RBtnEmpaquetado;
        private System.Windows.Forms.ComboBox CmBoxPreEntero;
        private System.Windows.Forms.ComboBox CmBoxPreEmpaquetado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
