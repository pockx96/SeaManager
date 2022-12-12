namespace MarDeCortezDsk.UserControlls
{
    partial class OtrosFicha
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
            this.CmBoxPresentacion = new System.Windows.Forms.ComboBox();
            this.CmBoxProducto = new System.Windows.Forms.ComboBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtboxCantidad = new System.Windows.Forms.TextBox();
            this.LblPresentacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PescadoContainer.SuspendLayout();
            this.DatosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PescadoContainer
            // 
            this.PescadoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PescadoContainer.Controls.Add(this.DatosGroupBox);
            this.PescadoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PescadoContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.PescadoContainer.Location = new System.Drawing.Point(0, 0);
            this.PescadoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PescadoContainer.Name = "PescadoContainer";
            this.PescadoContainer.Size = new System.Drawing.Size(486, 350);
            this.PescadoContainer.TabIndex = 4;
            this.PescadoContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PescadoContainer_Paint);
            // 
            // DatosGroupBox
            // 
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Controls.Add(this.label3);
            this.DatosGroupBox.Controls.Add(this.CmBoxPresentacion);
            this.DatosGroupBox.Controls.Add(this.CmBoxProducto);
            this.DatosGroupBox.Controls.Add(this.LblCantidad);
            this.DatosGroupBox.Controls.Add(this.LblProducto);
            this.DatosGroupBox.Controls.Add(this.TxtboxCantidad);
            this.DatosGroupBox.Controls.Add(this.LblPresentacion);
            this.DatosGroupBox.Location = new System.Drawing.Point(130, 3);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Size = new System.Drawing.Size(240, 342);
            this.DatosGroupBox.TabIndex = 23;
            this.DatosGroupBox.TabStop = false;
            // 
            // CmBoxPresentacion
            // 
            this.CmBoxPresentacion.FormattingEnabled = true;
            this.CmBoxPresentacion.Items.AddRange(new object[] {
            "SUELTO",
            "KILO",
            "MARQUETA DOS KILOS",
            "MARQUETA CINCO KILOS",
            "MARQUETA DIEZ KILOS"});
            this.CmBoxPresentacion.Location = new System.Drawing.Point(25, 148);
            this.CmBoxPresentacion.Name = "CmBoxPresentacion";
            this.CmBoxPresentacion.Size = new System.Drawing.Size(162, 21);
            this.CmBoxPresentacion.TabIndex = 17;
            // 
            // CmBoxProducto
            // 
            this.CmBoxProducto.FormattingEnabled = true;
            this.CmBoxProducto.Items.AddRange(new object[] {
            "PULPO CAMPECHANO -1",
            "PULPO CAMPECHANO 1-2 ",
            "PULPO CAMPECHANO 2-4 ",
            "PULPO CAMPECHANO 4-6 ",
            "PULPO REGIONAL CHICO ",
            "PULPO REGIONAL 1-2 ",
            "PULPO REGIONAL 2-4 ",
            "PULPO REGIONAL 4-6",
            "CALAMAR",
            "CALAMAR LIMPIO REGIONAL",
            "CALAMAR VAINA LIMPIO",
            "CALAMAR AROS LIMPIO",
            "TENTACULO DE CALAMAR",
            "CALLO CATARINA",
            "CALLO ARBOL",
            "CALLO CONCHA ESPINA",
            "CALLO ESCARLOPA",
            "CALLO RINON",
            "CALLO HACHA",
            "CARACOL CHINO",
            "CARACOL BURRO",
            "CARACOL DE UÑA"});
            this.CmBoxProducto.Location = new System.Drawing.Point(25, 65);
            this.CmBoxProducto.Name = "CmBoxProducto";
            this.CmBoxProducto.Size = new System.Drawing.Size(162, 21);
            this.CmBoxProducto.TabIndex = 14;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCantidad.Location = new System.Drawing.Point(21, 209);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(86, 20);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.LblProducto.Location = new System.Drawing.Point(21, 42);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(86, 20);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Text = "Producto:";
            // 
            // TxtboxCantidad
            // 
            this.TxtboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCantidad.Location = new System.Drawing.Point(25, 232);
            this.TxtboxCantidad.Name = "TxtboxCantidad";
            this.TxtboxCantidad.Size = new System.Drawing.Size(162, 29);
            this.TxtboxCantidad.TabIndex = 5;
            // 
            // LblPresentacion
            // 
            this.LblPresentacion.AutoSize = true;
            this.LblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPresentacion.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPresentacion.Location = new System.Drawing.Point(21, 125);
            this.LblPresentacion.Name = "LblPresentacion";
            this.LblPresentacion.Size = new System.Drawing.Size(119, 20);
            this.LblPresentacion.TabIndex = 4;
            this.LblPresentacion.Text = "Presentacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "________________________________";
            // 
            // OtrosFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PescadoContainer);
            this.Name = "OtrosFicha";
            this.Size = new System.Drawing.Size(486, 350);
            this.PescadoContainer.ResumeLayout(false);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PescadoContainer;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.ComboBox CmBoxPresentacion;
        private System.Windows.Forms.ComboBox CmBoxProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtboxCantidad;
        private System.Windows.Forms.Label LblPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
