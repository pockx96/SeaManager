﻿namespace MarDeCortezDsk.UserControlls
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
            this.TxtboxCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmBoxPresentacion = new System.Windows.Forms.ComboBox();
            this.CmBoxProducto = new System.Windows.Forms.ComboBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblPresentacion = new System.Windows.Forms.Label();
            this.PescadoContainer.SuspendLayout();
            this.DatosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtboxCantidad)).BeginInit();
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
            this.DatosGroupBox.Controls.Add(this.TxtboxCantidad);
            this.DatosGroupBox.Controls.Add(this.label2);
            this.DatosGroupBox.Controls.Add(this.label1);
            this.DatosGroupBox.Controls.Add(this.label3);
            this.DatosGroupBox.Controls.Add(this.CmBoxPresentacion);
            this.DatosGroupBox.Controls.Add(this.CmBoxProducto);
            this.DatosGroupBox.Controls.Add(this.LblCantidad);
            this.DatosGroupBox.Controls.Add(this.LblProducto);
            this.DatosGroupBox.Controls.Add(this.LblPresentacion);
            this.DatosGroupBox.Location = new System.Drawing.Point(119, 0);
            this.DatosGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.DatosGroupBox.Name = "DatosGroupBox";
            this.DatosGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.DatosGroupBox.Size = new System.Drawing.Size(271, 342);
            this.DatosGroupBox.TabIndex = 23;
            this.DatosGroupBox.TabStop = false;
            // 
            // TxtboxCantidad
            // 
            this.TxtboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtboxCantidad.Location = new System.Drawing.Point(24, 225);
            this.TxtboxCantidad.Name = "TxtboxCantidad";
            this.TxtboxCantidad.Size = new System.Drawing.Size(120, 22);
            this.TxtboxCantidad.TabIndex = 32;
            this.TxtboxCantidad.ValueChanged += new System.EventHandler(this.TxtboxCantidad_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "________________________________";
            // 
            // CmBoxPresentacion
            // 
            this.CmBoxPresentacion.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.CmBoxPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.CmBoxPresentacion.FormattingEnabled = true;
            this.CmBoxPresentacion.Location = new System.Drawing.Point(24, 142);
            this.CmBoxPresentacion.Name = "CmBoxPresentacion";
            this.CmBoxPresentacion.Size = new System.Drawing.Size(162, 23);
            this.CmBoxPresentacion.TabIndex = 17;
            this.CmBoxPresentacion.SelectedIndexChanged += new System.EventHandler(this.CmBoxPresentacion_SelectedIndexChanged);
            // 
            // CmBoxProducto
            // 
            this.CmBoxProducto.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.CmBoxProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.CmBoxProducto.FormattingEnabled = true;
            this.CmBoxProducto.Location = new System.Drawing.Point(24, 52);
            this.CmBoxProducto.Name = "CmBoxProducto";
            this.CmBoxProducto.Size = new System.Drawing.Size(162, 23);
            this.CmBoxProducto.TabIndex = 14;
            this.CmBoxProducto.SelectedIndexChanged += new System.EventHandler(this.CmBoxProducto_SelectedIndexChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold);
            this.LblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCantidad.Location = new System.Drawing.Point(18, 189);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(83, 17);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.LblProducto.Location = new System.Drawing.Point(18, 15);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(85, 17);
            this.LblProducto.TabIndex = 13;
            this.LblProducto.Text = "Producto:";
            // 
            // LblPresentacion
            // 
            this.LblPresentacion.AutoSize = true;
            this.LblPresentacion.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold);
            this.LblPresentacion.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPresentacion.Location = new System.Drawing.Point(18, 109);
            this.LblPresentacion.Name = "LblPresentacion";
            this.LblPresentacion.Size = new System.Drawing.Size(115, 17);
            this.LblPresentacion.TabIndex = 4;
            this.LblPresentacion.Text = "Presentación:";
            // 
            // OtrosFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PescadoContainer);
            this.Name = "OtrosFicha";
            this.Size = new System.Drawing.Size(486, 350);
            this.Load += new System.EventHandler(this.OtrosFicha_Load);
            this.PescadoContainer.ResumeLayout(false);
            this.DatosGroupBox.ResumeLayout(false);
            this.DatosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtboxCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PescadoContainer;
        private System.Windows.Forms.GroupBox DatosGroupBox;
        private System.Windows.Forms.ComboBox CmBoxPresentacion;
        private System.Windows.Forms.ComboBox CmBoxProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TxtboxCantidad;
    }
}
