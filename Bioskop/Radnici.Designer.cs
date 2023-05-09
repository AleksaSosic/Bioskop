namespace Bioskop
{
    partial class Radnici
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
            this.label_radnici = new System.Windows.Forms.Label();
            this.dataGridView_radnici = new System.Windows.Forms.DataGridView();
            this.label_ime = new System.Windows.Forms.Label();
            this.label_prezime = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_uloga = new System.Windows.Forms.Label();
            this.comboBox_uloga = new System.Windows.Forms.ComboBox();
            this.textBox_ime = new System.Windows.Forms.TextBox();
            this.textBox_prezime = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_izmeni = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_radnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label_radnici
            // 
            this.label_radnici.AutoSize = true;
            this.label_radnici.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_radnici.Location = new System.Drawing.Point(17, 14);
            this.label_radnici.Name = "label_radnici";
            this.label_radnici.Size = new System.Drawing.Size(145, 39);
            this.label_radnici.TabIndex = 11;
            this.label_radnici.Text = "Radnici";
            // 
            // dataGridView_radnici
            // 
            this.dataGridView_radnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_radnici.Location = new System.Drawing.Point(25, 225);
            this.dataGridView_radnici.Name = "dataGridView_radnici";
            this.dataGridView_radnici.Size = new System.Drawing.Size(478, 295);
            this.dataGridView_radnici.TabIndex = 12;
            this.dataGridView_radnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_radnici_CellClick);
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ime.Location = new System.Drawing.Point(62, 62);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(208, 25);
            this.label_ime.TabIndex = 13;
            this.label_ime.Text = "Unesite ime radnika:";
            // 
            // label_prezime
            // 
            this.label_prezime.AutoSize = true;
            this.label_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prezime.Location = new System.Drawing.Point(62, 92);
            this.label_prezime.Name = "label_prezime";
            this.label_prezime.Size = new System.Drawing.Size(250, 25);
            this.label_prezime.TabIndex = 14;
            this.label_prezime.Text = "Unesite prezime radnika:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(62, 122);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(225, 25);
            this.label_email.TabIndex = 15;
            this.label_email.Text = "Unesite email radnika:";
            // 
            // label_uloga
            // 
            this.label_uloga.AutoSize = true;
            this.label_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uloga.Location = new System.Drawing.Point(62, 152);
            this.label_uloga.Name = "label_uloga";
            this.label_uloga.Size = new System.Drawing.Size(236, 25);
            this.label_uloga.TabIndex = 16;
            this.label_uloga.Text = "Izaberite ulogu radnika:";
            // 
            // comboBox_uloga
            // 
            this.comboBox_uloga.FormattingEnabled = true;
            this.comboBox_uloga.Location = new System.Drawing.Point(331, 156);
            this.comboBox_uloga.Name = "comboBox_uloga";
            this.comboBox_uloga.Size = new System.Drawing.Size(121, 21);
            this.comboBox_uloga.TabIndex = 17;
            // 
            // textBox_ime
            // 
            this.textBox_ime.Location = new System.Drawing.Point(331, 67);
            this.textBox_ime.Name = "textBox_ime";
            this.textBox_ime.Size = new System.Drawing.Size(121, 20);
            this.textBox_ime.TabIndex = 18;
            // 
            // textBox_prezime
            // 
            this.textBox_prezime.Location = new System.Drawing.Point(331, 97);
            this.textBox_prezime.Name = "textBox_prezime";
            this.textBox_prezime.Size = new System.Drawing.Size(121, 20);
            this.textBox_prezime.TabIndex = 19;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(331, 127);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(121, 20);
            this.textBox_email.TabIndex = 20;
            // 
            // button_izmeni
            // 
            this.button_izmeni.Location = new System.Drawing.Point(110, 190);
            this.button_izmeni.Name = "button_izmeni";
            this.button_izmeni.Size = new System.Drawing.Size(75, 23);
            this.button_izmeni.TabIndex = 22;
            this.button_izmeni.Text = "Izmeni";
            this.button_izmeni.UseVisualStyleBackColor = true;
            this.button_izmeni.Click += new System.EventHandler(this.button_izmeni_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(340, 190);
            this.button_delete.Name = "button_delete";
            this.button_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Izbrisi";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 541);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_izmeni);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_prezime);
            this.Controls.Add(this.textBox_ime);
            this.Controls.Add(this.comboBox_uloga);
            this.Controls.Add(this.label_uloga);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_prezime);
            this.Controls.Add(this.label_ime);
            this.Controls.Add(this.dataGridView_radnici);
            this.Controls.Add(this.label_radnici);
            this.Name = "Radnici";
            this.Text = "Radnici";
            this.Load += new System.EventHandler(this.Radnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_radnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_radnici;
        private System.Windows.Forms.DataGridView dataGridView_radnici;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Label label_prezime;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_uloga;
        private System.Windows.Forms.ComboBox comboBox_uloga;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.TextBox textBox_prezime;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_izmeni;
        private System.Windows.Forms.Button button_delete;
    }
}