namespace MarDeCortezDsk.Views
{
    partial class Pruebas_de_metodos
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
            this.button1 = new System.Windows.Forms.Button();
            this.fichaCamaron = new MarDeCortezDsk.UserControlls.FichaCamaron();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fichaCamaron
            // 
            this.fichaCamaron.Almaecenaje = null;
            this.fichaCamaron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.fichaCamaron.KilosCantidadCamaron = 0;
            this.fichaCamaron.Location = new System.Drawing.Point(109, 130);
            this.fichaCamaron.MedidaCamaron = null;
            this.fichaCamaron.Name = "fichaCamaron";
            this.fichaCamaron.PresentacionCamaron = null;
            this.fichaCamaron.Proveedor = null;
            this.fichaCamaron.Size = new System.Drawing.Size(509, 350);
            this.fichaCamaron.TabIndex = 1;
            this.fichaCamaron.TipoCamaron = null;
            // 
            // Pruebas_de_metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 515);
            this.Controls.Add(this.fichaCamaron);
            this.Controls.Add(this.button1);
            this.Name = "Pruebas_de_metodos";
            this.Text = "Pruebas_de_metodos";
            this.Load += new System.EventHandler(this.Pruebas_de_metodos_Load);
            this.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.Pruebas_de_metodos_ChangeUICues);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UserControlls.FichaCamaron fichaCamaron;
    }
}