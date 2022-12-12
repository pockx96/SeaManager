namespace MarDeCortezDsk.UserControlls.CamaronFicha
{
    partial class PresentacionCamaron
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
            this.MedidasGroupBox = new System.Windows.Forms.GroupBox();
            this.lb_ttltTip = new System.Windows.Forms.Label();
            this.BtnMaqueta2k = new System.Windows.Forms.Button();
            this.BtnMaqueta5k = new System.Windows.Forms.Button();
            this.BtnVacio = new System.Windows.Forms.Button();
            this.BtnKileado = new System.Windows.Forms.Button();
            this.MedidasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedidasGroupBox
            // 
            this.MedidasGroupBox.Controls.Add(this.BtnVacio);
            this.MedidasGroupBox.Controls.Add(this.BtnKileado);
            this.MedidasGroupBox.Controls.Add(this.BtnMaqueta5k);
            this.MedidasGroupBox.Controls.Add(this.lb_ttltTip);
            this.MedidasGroupBox.Controls.Add(this.BtnMaqueta2k);
            this.MedidasGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedidasGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MedidasGroupBox.Name = "MedidasGroupBox";
            this.MedidasGroupBox.Size = new System.Drawing.Size(187, 229);
            this.MedidasGroupBox.TabIndex = 17;
            this.MedidasGroupBox.TabStop = false;
            this.MedidasGroupBox.Enter += new System.EventHandler(this.MedidasGroupBox_Enter_1);
            // 
            // lb_ttltTip
            // 
            this.lb_ttltTip.AutoSize = true;
            this.lb_ttltTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ttltTip.Location = new System.Drawing.Point(32, 16);
            this.lb_ttltTip.Name = "lb_ttltTip";
            this.lb_ttltTip.Size = new System.Drawing.Size(125, 18);
            this.lb_ttltTip.TabIndex = 3;
            this.lb_ttltTip.Text = "Presentaciones";
            // 
            // BtnMaqueta2k
            // 
            this.BtnMaqueta2k.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaqueta2k.Location = new System.Drawing.Point(13, 50);
            this.BtnMaqueta2k.Name = "BtnMaqueta2k";
            this.BtnMaqueta2k.Size = new System.Drawing.Size(74, 48);
            this.BtnMaqueta2k.TabIndex = 0;
            this.BtnMaqueta2k.Text = "Maqueta (2kg)";
            this.BtnMaqueta2k.UseVisualStyleBackColor = true;
            this.BtnMaqueta2k.Click += new System.EventHandler(this.bttn_cntntMedida1_Click);
            // 
            // BtnMaqueta5k
            // 
            this.BtnMaqueta5k.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaqueta5k.Location = new System.Drawing.Point(103, 50);
            this.BtnMaqueta5k.Name = "BtnMaqueta5k";
            this.BtnMaqueta5k.Size = new System.Drawing.Size(74, 48);
            this.BtnMaqueta5k.TabIndex = 4;
            this.BtnMaqueta5k.Text = "Maqueta (5kg)";
            this.BtnMaqueta5k.UseVisualStyleBackColor = true;
            this.BtnMaqueta5k.Click += new System.EventHandler(this.BtnMaqueta5k_Click);
            // 
            // BtnVacio
            // 
            this.BtnVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVacio.Location = new System.Drawing.Point(103, 117);
            this.BtnVacio.Name = "BtnVacio";
            this.BtnVacio.Size = new System.Drawing.Size(74, 48);
            this.BtnVacio.TabIndex = 6;
            this.BtnVacio.Text = "Al Vacio";
            this.BtnVacio.UseVisualStyleBackColor = true;
            this.BtnVacio.Click += new System.EventHandler(this.BtnVacio_Click);
            // 
            // BtnKileado
            // 
            this.BtnKileado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKileado.Location = new System.Drawing.Point(13, 117);
            this.BtnKileado.Name = "BtnKileado";
            this.BtnKileado.Size = new System.Drawing.Size(74, 48);
            this.BtnKileado.TabIndex = 5;
            this.BtnKileado.Text = "Kileado";
            this.BtnKileado.UseVisualStyleBackColor = true;
            this.BtnKileado.Click += new System.EventHandler(this.BtnKileado_Click);
            // 
            // PresentacionCamaron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MedidasGroupBox);
            this.Name = "PresentacionCamaron";
            this.Size = new System.Drawing.Size(187, 229);
            this.MedidasGroupBox.ResumeLayout(false);
            this.MedidasGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MedidasGroupBox;
        private System.Windows.Forms.Label lb_ttltTip;
        private System.Windows.Forms.Button BtnMaqueta2k;
        private System.Windows.Forms.Button BtnVacio;
        private System.Windows.Forms.Button BtnKileado;
        private System.Windows.Forms.Button BtnMaqueta5k;
    }
}
