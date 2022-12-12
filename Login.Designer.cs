
namespace MarDeCortezDsk
{
    partial class Login
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
            this.containerLogin = new System.Windows.Forms.Panel();
            this.lb_alert = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lklb_createacoount = new System.Windows.Forms.LinkLabel();
            this.bttn_login = new System.Windows.Forms.Button();
            this.txtBox_psswrd = new System.Windows.Forms.TextBox();
            this.txtBox_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.containerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // containerLogin
            // 
            this.containerLogin.AutoSize = true;
            this.containerLogin.BackColor = System.Drawing.Color.White;
            this.containerLogin.Controls.Add(this.lb_alert);
            this.containerLogin.Controls.Add(this.pictureBox1);
            this.containerLogin.Controls.Add(this.lklb_createacoount);
            this.containerLogin.Controls.Add(this.bttn_login);
            this.containerLogin.Controls.Add(this.txtBox_psswrd);
            this.containerLogin.Controls.Add(this.txtBox_user);
            this.containerLogin.Location = new System.Drawing.Point(45, 24);
            this.containerLogin.Margin = new System.Windows.Forms.Padding(2);
            this.containerLogin.Name = "containerLogin";
            this.containerLogin.Size = new System.Drawing.Size(856, 492);
            this.containerLogin.TabIndex = 0;
            this.containerLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.containerLogin_Paint);
            // 
            // lb_alert
            // 
            this.lb_alert.AutoSize = true;
            this.lb_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alert.ForeColor = System.Drawing.Color.Red;
            this.lb_alert.Location = new System.Drawing.Point(278, 417);
            this.lb_alert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_alert.Name = "lb_alert";
            this.lb_alert.Size = new System.Drawing.Size(311, 24);
            this.lb_alert.TabIndex = 6;
            this.lb_alert.Text = "El usuario o contraseña es icorrecto";
            this.lb_alert.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MarDeCortezDsk.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(352, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lklb_createacoount
            // 
            this.lklb_createacoount.AutoSize = true;
            this.lklb_createacoount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklb_createacoount.LinkColor = System.Drawing.Color.Black;
            this.lklb_createacoount.Location = new System.Drawing.Point(353, 411);
            this.lklb_createacoount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklb_createacoount.Name = "lklb_createacoount";
            this.lklb_createacoount.Size = new System.Drawing.Size(155, 29);
            this.lklb_createacoount.TabIndex = 5;
            this.lklb_createacoount.TabStop = true;
            this.lklb_createacoount.Text = "Crear Cuenta";
            // 
            // bttn_login
            // 
            this.bttn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_login.Location = new System.Drawing.Point(334, 336);
            this.bttn_login.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(180, 59);
            this.bttn_login.TabIndex = 4;
            this.bttn_login.Text = "Iniciar Sesion";
            this.bttn_login.UseVisualStyleBackColor = true;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // txtBox_psswrd
            // 
            this.txtBox_psswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_psswrd.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_psswrd.Location = new System.Drawing.Point(234, 265);
            this.txtBox_psswrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_psswrd.Name = "txtBox_psswrd";
            this.txtBox_psswrd.Size = new System.Drawing.Size(376, 44);
            this.txtBox_psswrd.TabIndex = 2;
            this.txtBox_psswrd.Text = "Contraseña";
            // 
            // txtBox_user
            // 
            this.txtBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_user.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_user.Location = new System.Drawing.Point(234, 187);
            this.txtBox_user.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_user.Name = "txtBox_user";
            this.txtBox_user.Size = new System.Drawing.Size(376, 44);
            this.txtBox_user.TabIndex = 0;
            this.txtBox_user.Text = "Usuario";
            this.txtBox_user.TextChanged += new System.EventHandler(this.txtBox_user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 532);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "@Create by Acosta/Badillo/Luna";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(941, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.containerLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.containerLogin.ResumeLayout(false);
            this.containerLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerLogin;
        private System.Windows.Forms.TextBox txtBox_user;
        private System.Windows.Forms.TextBox txtBox_psswrd;
        private System.Windows.Forms.Button bttn_login;
        private System.Windows.Forms.LinkLabel lklb_createacoount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_alert;
    }
}