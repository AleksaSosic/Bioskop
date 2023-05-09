namespace Bioskop
{
    partial class Filmovi
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
            this.label_filmovi = new System.Windows.Forms.Label();
            this.dataGridView_filmovi = new System.Windows.Forms.DataGridView();
            this.label_naziv = new System.Windows.Forms.Label();
            this.label_trajanje = new System.Windows.Forms.Label();
            this.textBox_naziv = new System.Windows.Forms.TextBox();
            this.textBox_trajanje = new System.Windows.Forms.TextBox();
            this.button_unesi = new System.Windows.Forms.Button();
            this.button_izmeni = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_filmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label_filmovi
            // 
            this.label_filmovi.AutoSize = true;
            this.label_filmovi.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filmovi.Location = new System.Drawing.Point(17, 14);
            this.label_filmovi.Name = "label_filmovi";
            this.label_filmovi.Size = new System.Drawing.Size(143, 39);
            this.label_filmovi.TabIndex = 10;
            this.label_filmovi.Text = "Filmovi";
            // 
            // dataGridView_filmovi
            // 
            this.dataGridView_filmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_filmovi.Location = new System.Drawing.Point(25, 210);
            this.dataGridView_filmovi.Name = "dataGridView_filmovi";
            this.dataGridView_filmovi.Size = new System.Drawing.Size(478, 295);
            this.dataGridView_filmovi.TabIndex = 11;
            this.dataGridView_filmovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_filmovi_CellClick);
            // 
            // label_naziv
            // 
            this.label_naziv.AutoSize = true;
            this.label_naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_naziv.Location = new System.Drawing.Point(88, 77);
            this.label_naziv.Name = "label_naziv";
            this.label_naziv.Size = new System.Drawing.Size(199, 25);
            this.label_naziv.TabIndex = 12;
            this.label_naziv.Text = "Unesite naziv filma:";
            // 
            // label_trajanje
            // 
            this.label_trajanje.AutoSize = true;
            this.label_trajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trajanje.Location = new System.Drawing.Point(88, 122);
            this.label_trajanje.Name = "label_trajanje";
            this.label_trajanje.Size = new System.Drawing.Size(219, 25);
            this.label_trajanje.TabIndex = 13;
            this.label_trajanje.Text = "Unesite trajanje filma:";
            // 
            // textBox_naziv
            // 
            this.textBox_naziv.Location = new System.Drawing.Point(331, 82);
            this.textBox_naziv.Name = "textBox_naziv";
            this.textBox_naziv.Size = new System.Drawing.Size(100, 20);
            this.textBox_naziv.TabIndex = 14;
            // 
            // textBox_trajanje
            // 
            this.textBox_trajanje.Location = new System.Drawing.Point(331, 127);
            this.textBox_trajanje.Name = "textBox_trajanje";
            this.textBox_trajanje.Size = new System.Drawing.Size(100, 20);
            this.textBox_trajanje.TabIndex = 15;
            // 
            // button_unesi
            // 
            this.button_unesi.Location = new System.Drawing.Point(110, 170);
            this.button_unesi.Name = "button_unesi";
            this.button_unesi.Size = new System.Drawing.Size(75, 23);
            this.button_unesi.TabIndex = 16;
            this.button_unesi.Text = "Unesi";
            this.button_unesi.UseVisualStyleBackColor = true;
            this.button_unesi.Click += new System.EventHandler(this.button_unesi_Click);
            // 
            // button_izmeni
            // 
            this.button_izmeni.Location = new System.Drawing.Point(225, 170);
            this.button_izmeni.Name = "button_izmeni";
            this.button_izmeni.Size = new System.Drawing.Size(75, 23);
            this.button_izmeni.TabIndex = 17;
            this.button_izmeni.Text = "Izmeni";
            this.button_izmeni.UseVisualStyleBackColor = true;
            this.button_izmeni.Click += new System.EventHandler(this.button_izmeni_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(340, 170);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "Izbrisi";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Filmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 526);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_izmeni);
            this.Controls.Add(this.button_unesi);
            this.Controls.Add(this.textBox_trajanje);
            this.Controls.Add(this.textBox_naziv);
            this.Controls.Add(this.label_trajanje);
            this.Controls.Add(this.label_naziv);
            this.Controls.Add(this.dataGridView_filmovi);
            this.Controls.Add(this.label_filmovi);
            this.Name = "Filmovi";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.Filmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_filmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_filmovi;
        private System.Windows.Forms.DataGridView dataGridView_filmovi;
        private System.Windows.Forms.Label label_naziv;
        private System.Windows.Forms.Label label_trajanje;
        private System.Windows.Forms.TextBox textBox_naziv;
        private System.Windows.Forms.TextBox textBox_trajanje;
        private System.Windows.Forms.Button button_unesi;
        private System.Windows.Forms.Button button_izmeni;
        private System.Windows.Forms.Button button_delete;
    }
}