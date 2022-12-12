
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.sPanel1 = new MarDeCortezDsk.UserControlls.SPanel();
            this.EyeButton = new FontAwesome.Sharp.IconButton();
            this.txtBox_psswrd = new CustomControls.RJControls.RJTextBox();
            this.txtBox_user = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.circularImagen1 = new MarDeCortezDsk.UserControlls.CircularImagen();
            this.label1 = new System.Windows.Forms.Label();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.EyeButton);
            this.sPanel1.Controls.Add(this.txtBox_psswrd);
            this.sPanel1.Controls.Add(this.txtBox_user);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.BtnAgregar);
            this.sPanel1.Controls.Add(this.circularImagen1);
            this.sPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(15, 15);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(327, 489);
            this.sPanel1.TabIndex = 3;
            this.sPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // EyeButton
            // 
            this.EyeButton.FlatAppearance.BorderSize = 0;
            this.EyeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EyeButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.EyeButton.IconColor = System.Drawing.Color.White;
            this.EyeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EyeButton.IconSize = 30;
            this.EyeButton.Location = new System.Drawing.Point(273, 323);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(39, 34);
            this.EyeButton.TabIndex = 43;
            this.EyeButton.UseVisualStyleBackColor = true;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // txtBox_psswrd
            // 
            this.txtBox_psswrd.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox_psswrd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txtBox_psswrd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.txtBox_psswrd.BorderRadius = 0;
            this.txtBox_psswrd.BorderSize = 2;
            this.txtBox_psswrd.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_psswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_psswrd.Location = new System.Drawing.Point(54, 321);
            this.txtBox_psswrd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_psswrd.Multiline = false;
            this.txtBox_psswrd.Name = "txtBox_psswrd";
            this.txtBox_psswrd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox_psswrd.PasswordChar = true;
            this.txtBox_psswrd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox_psswrd.PlaceholderText = "Contraseña";
            this.txtBox_psswrd.Size = new System.Drawing.Size(210, 36);
            this.txtBox_psswrd.TabIndex = 41;
            this.txtBox_psswrd.Texts = "";
            this.txtBox_psswrd.UnderlinedStyle = false;
            // 
            // txtBox_user
            // 
            this.txtBox_user.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox_user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.txtBox_user.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.txtBox_user.BorderRadius = 0;
            this.txtBox_user.BorderSize = 2;
            this.txtBox_user.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBox_user.Location = new System.Drawing.Point(54, 248);
            this.txtBox_user.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_user.Multiline = false;
            this.txtBox_user.Name = "txtBox_user";
            this.txtBox_user.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBox_user.PasswordChar = false;
            this.txtBox_user.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBox_user.PlaceholderText = "Usuario";
            this.txtBox_user.Size = new System.Drawing.Size(210, 36);
            this.txtBox_user.TabIndex = 40;
            this.txtBox_user.Texts = "";
            this.txtBox_user.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(51, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "________________________________";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAgregar.BorderRadius = 20;
            this.BtnAgregar.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(54, 394);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(220, 45);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Iniciar Sesion";
            this.BtnAgregar.TextColor = System.Drawing.Color.White;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            this.circularImagen1.Location = new System.Drawing.Point(79, 22);
            this.circularImagen1.Name = "circularImagen1";
            this.circularImagen1.Size = new System.Drawing.Size(159, 159);
            this.circularImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularImagen1.TabIndex = 7;
            this.circularImagen1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 509);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "@Create by Acosta/Badillo";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(357, 524);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Manager";
            this.Load += new System.EventHandler(this.Login_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControlls.BotonRedondo BtnAgregar;
        private UserControlls.SPanel sPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControlls.CircularImagen circularImagen1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtBox_psswrd;
        private CustomControls.RJControls.RJTextBox txtBox_user;
        private FontAwesome.Sharp.IconButton EyeButton;
    }
}