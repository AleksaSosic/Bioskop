namespace Bioskop
{
    partial class Repertoar
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
            this.label_repertoar = new System.Windows.Forms.Label();
            this.comboBox_film = new System.Windows.Forms.ComboBox();
            this.label_film = new System.Windows.Forms.Label();
            this.label_prikazivanje = new System.Windows.Forms.Label();
            this.comboBox_prikazivanje = new System.Windows.Forms.ComboBox();
            this.label_unos = new System.Windows.Forms.Label();
            this.dateTimePicker_unos = new System.Windows.Forms.DateTimePicker();
            this.label_datum = new System.Windows.Forms.Label();
            this.textBox_unos = new System.Windows.Forms.TextBox();
            this.label_vreme = new System.Windows.Forms.Label();
            this.label_sala = new System.Windows.Forms.Label();
            this.comboBox_sala = new System.Windows.Forms.ComboBox();
            this.label_tehnika = new System.Windows.Forms.Label();
            this.comboBox_tehnika = new System.Windows.Forms.ComboBox();
            this.dataGridView_Repertoar = new System.Windows.Forms.DataGridView();
            this.button_unesi = new System.Windows.Forms.Button();
            this.button_rezervisi = new System.Windows.Forms.Button();
            this.button_unos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repertoar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_repertoar
            // 
            this.label_repertoar.AutoSize = true;
            this.label_repertoar.Font = new System.Drawing.Font("News701 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_repertoar.Location = new System.Drawing.Point(17, 14);
            this.label_repertoar.Name = "label_repertoar";
            this.label_repertoar.Size = new System.Drawing.Size(186, 39);
            this.label_repertoar.TabIndex = 12;
            this.label_repertoar.Text = "Repertoar";
            // 
            // comboBox_film
            // 
            this.comboBox_film.FormattingEnabled = true;
            this.comboBox_film.Location = new System.Drawing.Point(175, 72);
            this.comboBox_film.Name = "comboBox_film";
            this.comboBox_film.Size = new System.Drawing.Size(121, 21);
            this.comboBox_film.TabIndex = 13;
            this.comboBox_film.SelectionChangeCommitted += new System.EventHandler(this.comboBox_film_SelectionChangeCommitted);
            // 
            // label_film
            // 
            this.label_film.AutoSize = true;
            this.label_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film.Location = new System.Drawing.Point(30, 70);
            this.label_film.Name = "label_film";
            this.label_film.Size = new System.Drawing.Size(139, 25);
            this.label_film.TabIndex = 17;
            this.label_film.Text = "Izaberite film:";
            // 
            // label_prikazivanje
            // 
            this.label_prikazivanje.AutoSize = true;
            this.label_prikazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prikazivanje.Location = new System.Drawing.Point(330, 70);
            this.label_prikazivanje.Name = "label_prikazivanje";
            this.label_prikazivanje.Size = new System.Drawing.Size(286, 25);
            this.label_prikazivanje.TabIndex = 18;
            this.label_prikazivanje.Text = "Izaberite vreme prikazivanja:";
            // 
            // comboBox_prikazivanje
            // 
            this.comboBox_prikazivanje.Enabled = false;
            this.comboBox_prikazivanje.FormattingEnabled = true;
            this.comboBox_prikazivanje.Location = new System.Drawing.Point(620, 72);
            this.comboBox_prikazivanje.Name = "comboBox_prikazivanje";
            this.comboBox_prikazivanje.Size = new System.Drawing.Size(121, 21);
            this.comboBox_prikazivanje.TabIndex = 19;
            this.comboBox_prikazivanje.SelectionChangeCommitted += new System.EventHandler(this.comboBox_prikazivanje_SelectionChangeCommitted);
            // 
            // label_unos
            // 
            this.label_unos.AutoSize = true;
            this.label_unos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unos.Location = new System.Drawing.Point(331, 125);
            this.label_unos.Name = "label_unos";
            this.label_unos.Size = new System.Drawing.Size(79, 20);
            this.label_unos.TabIndex = 20;
            this.label_unos.Text = "(za unos):";
            // 
            // dateTimePicker_unos
            // 
            this.dateTimePicker_unos.Enabled = false;
            this.dateTimePicker_unos.Location = new System.Drawing.Point(422, 125);
            this.dateTimePicker_unos.Name = "dateTimePicker_unos";
            this.dateTimePicker_unos.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_unos.TabIndex = 21;
            this.dateTimePicker_unos.ValueChanged += new System.EventHandler(this.dateTimePicker_unos_ValueChanged);
            // 
            // label_datum
            // 
            this.label_datum.AutoSize = true;
            this.label_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datum.Location = new System.Drawing.Point(477, 105);
            this.label_datum.Name = "label_datum";
            this.label_datum.Size = new System.Drawing.Size(54, 20);
            this.label_datum.TabIndex = 22;
            this.label_datum.Text = "datum";
            // 
            // textBox_unos
            // 
            this.textBox_unos.Enabled = false;
            this.textBox_unos.Location = new System.Drawing.Point(641, 125);
            this.textBox_unos.Name = "textBox_unos";
            this.textBox_unos.Size = new System.Drawing.Size(100, 20);
            this.textBox_unos.TabIndex = 23;
            this.textBox_unos.TextChanged += new System.EventHandler(this.textBox_unos_TextChanged);
            // 
            // label_vreme
            // 
            this.label_vreme.AutoSize = true;
            this.label_vreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vreme.Location = new System.Drawing.Point(665, 105);
            this.label_vreme.Name = "label_vreme";
            this.label_vreme.Size = new System.Drawing.Size(52, 20);
            this.label_vreme.TabIndex = 24;
            this.label_vreme.Text = "vreme";
            // 
            // label_sala
            // 
            this.label_sala.AutoSize = true;
            this.label_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sala.Location = new System.Drawing.Point(30, 122);
            this.label_sala.Name = "label_sala";
            this.label_sala.Size = new System.Drawing.Size(146, 25);
            this.label_sala.TabIndex = 25;
            this.label_sala.Text = "Izaberite salu:";
            // 
            // comboBox_sala
            // 
            this.comboBox_sala.Enabled = false;
            this.comboBox_sala.FormattingEnabled = true;
            this.comboBox_sala.Location = new System.Drawing.Point(182, 124);
            this.comboBox_sala.Name = "comboBox_sala";
            this.comboBox_sala.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sala.TabIndex = 26;
            this.comboBox_sala.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sala_SelectionChangeCommitted);
            // 
            // label_tehnika
            // 
            this.label_tehnika.AutoSize = true;
            this.label_tehnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tehnika.Location = new System.Drawing.Point(30, 170);
            this.label_tehnika.Name = "label_tehnika";
            this.label_tehnika.Size = new System.Drawing.Size(176, 25);
            this.label_tehnika.TabIndex = 27;
            this.label_tehnika.Text = "Izaberite tehniku:";
            // 
            // comboBox_tehnika
            // 
            this.comboBox_tehnika.Enabled = false;
            this.comboBox_tehnika.FormattingEnabled = true;
            this.comboBox_tehnika.Location = new System.Drawing.Point(212, 174);
            this.comboBox_tehnika.Name = "comboBox_tehnika";
            this.comboBox_tehnika.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tehnika.TabIndex = 28;
            this.comboBox_tehnika.SelectionChangeCommitted += new System.EventHandler(this.comboBox_tehnika_SelectionChangeCommitted);
            // 
            // dataGridView_Repertoar
            // 
            this.dataGridView_Repertoar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Repertoar.Location = new System.Drawing.Point(24, 214);
            this.dataGridView_Repertoar.Name = "dataGridView_Repertoar";
            this.dataGridView_Repertoar.Size = new System.Drawing.Size(717, 389);
            this.dataGridView_Repertoar.TabIndex = 29;
            this.dataGridView_Repertoar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Repertoar_CellClick);
            // 
            // button_unesi
            // 
            this.button_unesi.Enabled = false;
            this.button_unesi.Location = new System.Drawing.Point(422, 174);
            this.button_unesi.Name = "button_unesi";
            this.button_unesi.Size = new System.Drawing.Size(75, 23);
            this.button_unesi.TabIndex = 30;
            this.button_unesi.Text = "Unesi";
            this.button_unesi.UseVisualStyleBackColor = true;
            this.button_unesi.Click += new System.EventHandler(this.button_unesi_Click);
            // 
            // button_rezervisi
            // 
            this.button_rezervisi.Enabled = false;
            this.button_rezervisi.Location = new System.Drawing.Point(547, 174);
            this.button_rezervisi.Name = "button_rezervisi";
            this.button_rezervisi.Size = new System.Drawing.Size(75, 23);
            this.button_rezervisi.TabIndex = 31;
            this.button_rezervisi.Text = "Rezervisi";
            this.button_rezervisi.UseVisualStyleBackColor = true;
            this.button_rezervisi.Click += new System.EventHandler(this.button_rezervisi_Click);
            // 
            // button_unos
            // 
            this.button_unos.Enabled = false;
            this.button_unos.Location = new System.Drawing.Point(643, 43);
            this.button_unos.Name = "button_unos";
            this.button_unos.Size = new System.Drawing.Size(75, 23);
            this.button_unos.TabIndex = 33;
            this.button_unos.Text = "Unos";
            this.button_unos.UseVisualStyleBackColor = true;
            this.button_unos.Click += new System.EventHandler(this.button_unos_Click);
            // 
            // Repertoar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 624);
            this.Controls.Add(this.button_unos);
            this.Controls.Add(this.button_rezervisi);
            this.Controls.Add(this.button_unesi);
            this.Controls.Add(this.dataGridView_Repertoar);
            this.Controls.Add(this.comboBox_tehnika);
            this.Controls.Add(this.label_tehnika);
            this.Controls.Add(this.comboBox_sala);
            this.Controls.Add(this.label_sala);
            this.Controls.Add(this.label_vreme);
            this.Controls.Add(this.textBox_unos);
            this.Controls.Add(this.label_datum);
            this.Controls.Add(this.dateTimePicker_unos);
            this.Controls.Add(this.label_unos);
            this.Controls.Add(this.comboBox_prikazivanje);
            this.Controls.Add(this.label_prikazivanje);
            this.Controls.Add(this.label_film);
            this.Controls.Add(this.comboBox_film);
            this.Controls.Add(this.label_repertoar);
            this.Name = "Repertoar";
            this.Text = "Repertoar";
            this.Load += new System.EventHandler(this.Repertoar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Repertoar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_repertoar;
        private System.Windows.Forms.ComboBox comboBox_film;
        private System.Windows.Forms.Label label_film;
        private System.Windows.Forms.Label label_prikazivanje;
        private System.Windows.Forms.ComboBox comboBox_prikazivanje;
        private System.Windows.Forms.Label label_unos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_unos;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.TextBox textBox_unos;
        private System.Windows.Forms.Label label_vreme;
        private System.Windows.Forms.Label label_sala;
        private System.Windows.Forms.ComboBox comboBox_sala;
        private System.Windows.Forms.Label label_tehnika;
        private System.Windows.Forms.ComboBox comboBox_tehnika;
        private System.Windows.Forms.DataGridView dataGridView_Repertoar;
        private System.Windows.Forms.Button button_unesi;
        private System.Windows.Forms.Button button_rezervisi;
        private System.Windows.Forms.Button button_unos;
    }
}