namespace Bioskop
{
    partial class Kasa
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
            this.label_kasa = new System.Windows.Forms.Label();
            this.dataGridView_Kasa = new System.Windows.Forms.DataGridView();
            this.label_film = new System.Windows.Forms.Label();
            this.comboBox_film = new System.Windows.Forms.ComboBox();
            this.label_prikazivanje = new System.Windows.Forms.Label();
            this.comboBox_prikazivanje = new System.Windows.Forms.ComboBox();
            this.label_broj_reda = new System.Windows.Forms.Label();
            this.comboBox_broj_reda = new System.Windows.Forms.ComboBox();
            this.label_broj_sedista = new System.Windows.Forms.Label();
            this.comboBox_broj_sedista = new System.Windows.Forms.ComboBox();
            this.button_prodaja = new System.Windows.Forms.Button();
            this.button_prikazi_sve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kasa)).BeginInit();
            this.SuspendLayout();
            // 
            // label_kasa
            // 
            this.label_kasa.AutoSize = true;
            this.label_kasa.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kasa.Location = new System.Drawing.Point(17, 14);
            this.label_kasa.Name = "label_kasa";
            this.label_kasa.Size = new System.Drawing.Size(98, 39);
            this.label_kasa.TabIndex = 13;
            this.label_kasa.Text = "Kasa";
            // 
            // dataGridView_Kasa
            // 
            this.dataGridView_Kasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kasa.Location = new System.Drawing.Point(24, 214);
            this.dataGridView_Kasa.Name = "dataGridView_Kasa";
            this.dataGridView_Kasa.Size = new System.Drawing.Size(717, 389);
            this.dataGridView_Kasa.TabIndex = 30;
            this.dataGridView_Kasa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Kasa_CellClick);
            // 
            // label_film
            // 
            this.label_film.AutoSize = true;
            this.label_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film.Location = new System.Drawing.Point(19, 65);
            this.label_film.Name = "label_film";
            this.label_film.Size = new System.Drawing.Size(139, 25);
            this.label_film.TabIndex = 31;
            this.label_film.Text = "Izaberite film:";
            // 
            // comboBox_film
            // 
            this.comboBox_film.FormattingEnabled = true;
            this.comboBox_film.Location = new System.Drawing.Point(164, 69);
            this.comboBox_film.Name = "comboBox_film";
            this.comboBox_film.Size = new System.Drawing.Size(121, 21);
            this.comboBox_film.TabIndex = 32;
            this.comboBox_film.SelectionChangeCommitted += new System.EventHandler(this.comboBox_film_SelectionChangeCommitted);
            // 
            // label_prikazivanje
            // 
            this.label_prikazivanje.AutoSize = true;
            this.label_prikazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prikazivanje.Location = new System.Drawing.Point(19, 102);
            this.label_prikazivanje.Name = "label_prikazivanje";
            this.label_prikazivanje.Size = new System.Drawing.Size(286, 25);
            this.label_prikazivanje.TabIndex = 33;
            this.label_prikazivanje.Text = "Izaberite vreme prikazivanja:";
            // 
            // comboBox_prikazivanje
            // 
            this.comboBox_prikazivanje.Enabled = false;
            this.comboBox_prikazivanje.FormattingEnabled = true;
            this.comboBox_prikazivanje.Location = new System.Drawing.Point(311, 106);
            this.comboBox_prikazivanje.Name = "comboBox_prikazivanje";
            this.comboBox_prikazivanje.Size = new System.Drawing.Size(121, 21);
            this.comboBox_prikazivanje.TabIndex = 34;
            this.comboBox_prikazivanje.SelectionChangeCommitted += new System.EventHandler(this.comboBox_prikazivanje_SelectionChangeCommitted);
            // 
            // label_broj_reda
            // 
            this.label_broj_reda.AutoSize = true;
            this.label_broj_reda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_broj_reda.Location = new System.Drawing.Point(19, 138);
            this.label_broj_reda.Name = "label_broj_reda";
            this.label_broj_reda.Size = new System.Drawing.Size(191, 25);
            this.label_broj_reda.TabIndex = 35;
            this.label_broj_reda.Text = "Izaberite broj reda:";
            // 
            // comboBox_broj_reda
            // 
            this.comboBox_broj_reda.Enabled = false;
            this.comboBox_broj_reda.FormattingEnabled = true;
            this.comboBox_broj_reda.Location = new System.Drawing.Point(216, 142);
            this.comboBox_broj_reda.Name = "comboBox_broj_reda";
            this.comboBox_broj_reda.Size = new System.Drawing.Size(121, 21);
            this.comboBox_broj_reda.TabIndex = 36;
            this.comboBox_broj_reda.SelectionChangeCommitted += new System.EventHandler(this.comboBox_broj_reda_SelectionChangeCommitted);
            // 
            // label_broj_sedista
            // 
            this.label_broj_sedista.AutoSize = true;
            this.label_broj_sedista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_broj_sedista.Location = new System.Drawing.Point(19, 174);
            this.label_broj_sedista.Name = "label_broj_sedista";
            this.label_broj_sedista.Size = new System.Drawing.Size(217, 25);
            this.label_broj_sedista.TabIndex = 37;
            this.label_broj_sedista.Text = "Izaberite broj sedista:";
            // 
            // comboBox_broj_sedista
            // 
            this.comboBox_broj_sedista.Enabled = false;
            this.comboBox_broj_sedista.FormattingEnabled = true;
            this.comboBox_broj_sedista.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_broj_sedista.Location = new System.Drawing.Point(242, 178);
            this.comboBox_broj_sedista.Name = "comboBox_broj_sedista";
            this.comboBox_broj_sedista.Size = new System.Drawing.Size(121, 21);
            this.comboBox_broj_sedista.TabIndex = 38;
            this.comboBox_broj_sedista.SelectionChangeCommitted += new System.EventHandler(this.comboBox_broj_sedista_SelectionChangeCommitted);
            // 
            // button_prodaja
            // 
            this.button_prodaja.Enabled = false;
            this.button_prodaja.Location = new System.Drawing.Point(558, 178);
            this.button_prodaja.Name = "button_prodaja";
            this.button_prodaja.Size = new System.Drawing.Size(75, 23);
            this.button_prodaja.TabIndex = 39;
            this.button_prodaja.Text = "Prodaja";
            this.button_prodaja.UseVisualStyleBackColor = true;
            this.button_prodaja.Click += new System.EventHandler(this.button_prodaja_Click);
            // 
            // button_prikazi_sve
            // 
            this.button_prikazi_sve.Enabled = false;
            this.button_prikazi_sve.Location = new System.Drawing.Point(442, 178);
            this.button_prikazi_sve.Name = "button_prikazi_sve";
            this.button_prikazi_sve.Size = new System.Drawing.Size(75, 23);
            this.button_prikazi_sve.TabIndex = 40;
            this.button_prikazi_sve.Text = "Prikazi sve";
            this.button_prikazi_sve.UseVisualStyleBackColor = true;
            this.button_prikazi_sve.Click += new System.EventHandler(this.button_prikazi_sve_Click);
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 624);
            this.Controls.Add(this.button_prikazi_sve);
            this.Controls.Add(this.button_prodaja);
            this.Controls.Add(this.comboBox_broj_sedista);
            this.Controls.Add(this.label_broj_sedista);
            this.Controls.Add(this.comboBox_broj_reda);
            this.Controls.Add(this.label_broj_reda);
            this.Controls.Add(this.comboBox_prikazivanje);
            this.Controls.Add(this.label_prikazivanje);
            this.Controls.Add(this.comboBox_film);
            this.Controls.Add(this.label_film);
            this.Controls.Add(this.dataGridView_Kasa);
            this.Controls.Add(this.label_kasa);
            this.Name = "Kasa";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_kasa;
        private System.Windows.Forms.DataGridView dataGridView_Kasa;
        private System.Windows.Forms.Label label_film;
        private System.Windows.Forms.ComboBox comboBox_film;
        private System.Windows.Forms.Label label_prikazivanje;
        private System.Windows.Forms.ComboBox comboBox_prikazivanje;
        private System.Windows.Forms.Label label_broj_reda;
        private System.Windows.Forms.ComboBox comboBox_broj_reda;
        private System.Windows.Forms.Label label_broj_sedista;
        private System.Windows.Forms.ComboBox comboBox_broj_sedista;
        private System.Windows.Forms.Button button_prodaja;
        private System.Windows.Forms.Button button_prikazi_sve;
    }
}