namespace Bioskop
{
    partial class Form1
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
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_sifra = new System.Windows.Forms.TextBox();
            this.label_bioskop = new System.Windows.Forms.Label();
            this.button_log_in = new System.Windows.Forms.Button();
            this.label_nemate_nalog = new System.Windows.Forms.Label();
            this.linkLabel_sign_up = new System.Windows.Forms.LinkLabel();
            this.button_visibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(39, 79);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(148, 25);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Unesite email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(39, 124);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(138, 25);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Unesite sifru:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(229, 84);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_sifra
            // 
            this.textBox_sifra.Location = new System.Drawing.Point(229, 129);
            this.textBox_sifra.Name = "textBox_sifra";
            this.textBox_sifra.PasswordChar = '*';
            this.textBox_sifra.Size = new System.Drawing.Size(100, 20);
            this.textBox_sifra.TabIndex = 7;
            // 
            // label_bioskop
            // 
            this.label_bioskop.AutoSize = true;
            this.label_bioskop.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bioskop.Location = new System.Drawing.Point(17, 14);
            this.label_bioskop.Name = "label_bioskop";
            this.label_bioskop.Size = new System.Drawing.Size(153, 39);
            this.label_bioskop.TabIndex = 8;
            this.label_bioskop.Text = "Bioskop";
            // 
            // button_log_in
            // 
            this.button_log_in.Location = new System.Drawing.Point(243, 169);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(75, 23);
            this.button_log_in.TabIndex = 9;
            this.button_log_in.Text = "Ulogujte se";
            this.button_log_in.UseVisualStyleBackColor = true;
            this.button_log_in.Click += new System.EventHandler(this.button_log_in_Click);
            // 
            // label_nemate_nalog
            // 
            this.label_nemate_nalog.AutoSize = true;
            this.label_nemate_nalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nemate_nalog.Location = new System.Drawing.Point(231, 195);
            this.label_nemate_nalog.Name = "label_nemate_nalog";
            this.label_nemate_nalog.Size = new System.Drawing.Size(99, 16);
            this.label_nemate_nalog.TabIndex = 10;
            this.label_nemate_nalog.Text = "Nemate nalog?";
            // 
            // linkLabel_sign_up
            // 
            this.linkLabel_sign_up.AutoSize = true;
            this.linkLabel_sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_sign_up.Location = new System.Drawing.Point(231, 214);
            this.linkLabel_sign_up.Name = "linkLabel_sign_up";
            this.linkLabel_sign_up.Size = new System.Drawing.Size(94, 16);
            this.linkLabel_sign_up.TabIndex = 11;
            this.linkLabel_sign_up.TabStop = true;
            this.linkLabel_sign_up.Text = "Naprative novi";
            this.linkLabel_sign_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_sign_up_LinkClicked);
            // 
            // button_visibility
            // 
            this.button_visibility.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_visibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_visibility.ImageKey = "(none)";
            this.button_visibility.Location = new System.Drawing.Point(338, 126);
            this.button_visibility.Name = "button_visibility";
            this.button_visibility.Size = new System.Drawing.Size(26, 26);
            this.button_visibility.TabIndex = 12;
            this.button_visibility.Text = "Ø";
            this.button_visibility.UseVisualStyleBackColor = false;
            this.button_visibility.Click += new System.EventHandler(this.button_visibility_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 269);
            this.Controls.Add(this.button_visibility);
            this.Controls.Add(this.linkLabel_sign_up);
            this.Controls.Add(this.label_nemate_nalog);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.label_bioskop);
            this.Controls.Add(this.textBox_sifra);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Name = "Form1";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_sifra;
        private System.Windows.Forms.Label label_bioskop;
        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.Label label_nemate_nalog;
        private System.Windows.Forms.LinkLabel linkLabel_sign_up;
        private System.Windows.Forms.Button button_visibility;
        public System.Windows.Forms.TextBox textBox_email;
    }
}

