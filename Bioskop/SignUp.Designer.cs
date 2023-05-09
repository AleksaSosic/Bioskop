namespace Bioskop
{
    partial class SignUp
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
            this.label_ime = new System.Windows.Forms.Label();
            this.label_prezime = new System.Windows.Forms.Label();
            this.textBox_ime = new System.Windows.Forms.TextBox();
            this.textBox_prezime = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_sifra = new System.Windows.Forms.TextBox();
            this.label_bioskop = new System.Windows.Forms.Label();
            this.button_sign_up = new System.Windows.Forms.Button();
            this.button_visibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(40, 170);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(148, 25);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Unesite email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(40, 215);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(138, 25);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Unesite sifru:";
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ime.Location = new System.Drawing.Point(40, 80);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(131, 25);
            this.label_ime.TabIndex = 5;
            this.label_ime.Text = "Unesite ime:";
            // 
            // label_prezime
            // 
            this.label_prezime.AutoSize = true;
            this.label_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prezime.Location = new System.Drawing.Point(40, 125);
            this.label_prezime.Name = "label_prezime";
            this.label_prezime.Size = new System.Drawing.Size(173, 25);
            this.label_prezime.TabIndex = 6;
            this.label_prezime.Text = "Unesite prezime:";
            // 
            // textBox_ime
            // 
            this.textBox_ime.Location = new System.Drawing.Point(230, 85);
            this.textBox_ime.Name = "textBox_ime";
            this.textBox_ime.Size = new System.Drawing.Size(100, 20);
            this.textBox_ime.TabIndex = 7;
            // 
            // textBox_prezime
            // 
            this.textBox_prezime.Location = new System.Drawing.Point(230, 130);
            this.textBox_prezime.Name = "textBox_prezime";
            this.textBox_prezime.Size = new System.Drawing.Size(100, 20);
            this.textBox_prezime.TabIndex = 8;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(230, 175);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 9;
            // 
            // textBox_sifra
            // 
            this.textBox_sifra.Location = new System.Drawing.Point(230, 220);
            this.textBox_sifra.Name = "textBox_sifra";
            this.textBox_sifra.PasswordChar = '*';
            this.textBox_sifra.Size = new System.Drawing.Size(100, 20);
            this.textBox_sifra.TabIndex = 10;
            // 
            // label_bioskop
            // 
            this.label_bioskop.AutoSize = true;
            this.label_bioskop.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bioskop.Location = new System.Drawing.Point(17, 14);
            this.label_bioskop.Name = "label_bioskop";
            this.label_bioskop.Size = new System.Drawing.Size(153, 39);
            this.label_bioskop.TabIndex = 11;
            this.label_bioskop.Text = "Bioskop";
            // 
            // button_sign_up
            // 
            this.button_sign_up.Location = new System.Drawing.Point(243, 252);
            this.button_sign_up.Name = "button_sign_up";
            this.button_sign_up.Size = new System.Drawing.Size(75, 38);
            this.button_sign_up.TabIndex = 12;
            this.button_sign_up.Text = "Napravi nalog";
            this.button_sign_up.UseVisualStyleBackColor = true;
            this.button_sign_up.Click += new System.EventHandler(this.button_sign_up_Click);
            // 
            // button_visibility
            // 
            this.button_visibility.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_visibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_visibility.ImageKey = "(none)";
            this.button_visibility.Location = new System.Drawing.Point(337, 217);
            this.button_visibility.Name = "button_visibility";
            this.button_visibility.Size = new System.Drawing.Size(26, 26);
            this.button_visibility.TabIndex = 13;
            this.button_visibility.Text = "Ø";
            this.button_visibility.UseVisualStyleBackColor = false;
            this.button_visibility.Click += new System.EventHandler(this.button_visibility_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 321);
            this.Controls.Add(this.button_visibility);
            this.Controls.Add(this.button_sign_up);
            this.Controls.Add(this.label_bioskop);
            this.Controls.Add(this.textBox_sifra);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_prezime);
            this.Controls.Add(this.textBox_ime);
            this.Controls.Add(this.label_prezime);
            this.Controls.Add(this.label_ime);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Label label_prezime;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.TextBox textBox_prezime;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_sifra;
        private System.Windows.Forms.Label label_bioskop;
        private System.Windows.Forms.Button button_sign_up;
        private System.Windows.Forms.Button button_visibility;
    }
}