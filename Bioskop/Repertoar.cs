using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop
{
    public partial class Repertoar : Form
    {

        DataTable dt_Repertoar = new DataTable();
        DataTable dt_Film = new DataTable();
        DataTable dt_Vreme = new DataTable();
        DataTable dt_Sala = new DataTable();
        DataTable dt_Tehnika = new DataTable();
        //bool unos = false;
        public Repertoar()
        {
            InitializeComponent();
        }

        private void GridPopulate()
        {
            string naredba = "Select Mesto.id_mesto, Mesto.broj_reda, Mesto.broj_sedista, Tip_Mesta.naziv, Repertoar_Mesto.konacna_cena, Repertoar_Mesto.status_mesta from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "Join Mesto on Repertoar_Mesto.id_mesto = Mesto.id_mesto ";
            naredba += "Join Tip_Mesta on Tip_Mesta.id_tip_mesta = Mesto.id_tip_mesta ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "' and ";
            naredba += "status_mesta = 'slobodno'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Repertoar = new DataTable();
            adapter.Fill(dt_Repertoar);
            dataGridView_Repertoar.DataSource = dt_Repertoar;
            //dataGridView_filmovi.Columns["id_radnik"].Visible = false;
            dataGridView_Repertoar.AllowUserToAddRows = false;
        }

        private void FilmPopulate()
        { 
            string naredba = "Select id_film, naziv from Film";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Film = new DataTable();
            adapter.Fill(dt_Film);
            comboBox_film.DataSource = dt_Film;
            comboBox_film.ValueMember = "id_film";
            comboBox_film.DisplayMember = "naziv";
            comboBox_film.Text = "";
        }

        private void VremePopulate()
        {
            string naredba = "Select vreme_davanja from Repertoar ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Vreme = new DataTable();
            adapter.Fill(dt_Vreme);
            comboBox_prikazivanje.DataSource = dt_Vreme;
            comboBox_prikazivanje.ValueMember = "vreme_davanja";
        }

        private void SalaPopulate()
        {
            string naredba = "Select Repertoar.id_sala, Sala.naziv from Repertoar ";
            naredba += "Join Sala on Sala.id_sala = Repertoar.id_sala ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Sala = new DataTable();
            adapter.Fill(dt_Sala);
            comboBox_sala.DataSource = dt_Sala;
            comboBox_sala.ValueMember = "id_sala";
            comboBox_sala.DisplayMember = "naziv";
        }

        private void UnesiSalaPopulate()
        {
            string naredba = "Select id_sala, naziv from Sala";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Sala = new DataTable();
            adapter.Fill(dt_Sala);
            comboBox_sala.DataSource = dt_Sala;
            comboBox_sala.ValueMember = "id_sala";
            comboBox_sala.DisplayMember = "naziv";
            comboBox_sala.Text = "";
        }

        private void TehnikaPopulate()
        {
            string naredba = "Select Repertoar.id_tehnika, Tehnika.naziv from Repertoar ";
            naredba += "Join Tehnika on Tehnika.id_tehnika = Repertoar.id_tehnika ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Tehnika = new DataTable();
            adapter.Fill(dt_Tehnika);
            comboBox_tehnika.DataSource = dt_Tehnika;
            comboBox_tehnika.ValueMember = "id_tehnika";
            comboBox_tehnika.DisplayMember = "naziv";
        }

        private void UnesiTehnikaPopulate()
        {
            string naredba = "Select id_tehnika, naziv from Tehnika";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Tehnika = new DataTable();
            adapter.Fill(dt_Tehnika);
            comboBox_tehnika.DataSource = dt_Tehnika;
            comboBox_tehnika.ValueMember = "id_tehnika";
            comboBox_tehnika.DisplayMember = "naziv";
            comboBox_tehnika.Text = "";
        }

        private void IzmeniStatusMesta(int slog)
        {
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "Update Repertoar_Mesto ";
            naredba += "Set status_mesta = 'rezervisano' ";
            naredba += "where id_mesto = '" + slog.ToString() + "' and ";
            naredba += "id_repertoar = (select id_repertoar from Repertoar ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "')";
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message, "Doslo je do greske, proverite unete podatke opet.");
            }
        }

        private void Repertoar_Load(object sender, EventArgs e)
        {
            FilmPopulate();
        }

        private void comboBox_film_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = true;
            dateTimePicker_unos.Enabled = false;
            textBox_unos.Enabled = false;
            comboBox_sala.Enabled = false;
            comboBox_tehnika.Enabled = false;
            button_unesi.Enabled = false;
            button_rezervisi.Enabled = false;
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "select id_uloga_radnik from Radnik ";
            naredba += "where email = '" + Form1.email + "'";
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            konekcija.Open();
            int uloga = (int)komanda.ExecuteScalar();
            konekcija.Close();
            if (uloga != 3)
            {
                button_unos.Enabled = true;
            }
            dt_Repertoar = new DataTable();
            dataGridView_Repertoar.DataSource = dt_Repertoar;
            textBox_unos.Text = "";
            comboBox_sala.Text = "";
            comboBox_tehnika.Text = "";
            comboBox_prikazivanje.Text = "";
            //unos = false;
            VremePopulate();
        }

        private void button_unos_Click(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = false;
            dateTimePicker_unos.Enabled = true;
            textBox_unos.Enabled = true;
            comboBox_sala.Enabled = false;
            comboBox_tehnika.Enabled = false;
            button_unesi.Enabled = false;
            button_rezervisi.Enabled = false;
            dt_Repertoar = new DataTable();
            dataGridView_Repertoar.DataSource = dt_Repertoar;
            comboBox_prikazivanje.Text = "";
            textBox_unos.Text = "";
            comboBox_sala.Text = "";
            comboBox_tehnika.Text = "";
        }

        private void comboBox_prikazivanje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_prikazivanje.Text == "")
            {
                /*unos = true;
                comboBox_film.Enabled = true;
                comboBox_prikazivanje.Enabled = true;
                dateTimePicker_unos.Enabled = true;
                textBox_unos.Enabled = true;
                comboBox_sala.Enabled = false;
                comboBox_tehnika.Enabled = false;
                button_unesi.Enabled = false;
                button_rezervisi.Enabled = false;*/
            }
            else
            {
                comboBox_film.Enabled = true;
                comboBox_prikazivanje.Enabled = true;
                dateTimePicker_unos.Enabled = false;
                textBox_unos.Enabled = false;
                comboBox_sala.Enabled = false;
                comboBox_tehnika.Enabled = false;
                button_unesi.Enabled = false;
                button_rezervisi.Enabled = false;
                textBox_unos.Text = "";
                SalaPopulate();
                TehnikaPopulate();
                GridPopulate();
            }
        }

        private void dateTimePicker_unos_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_unos.Text != "" && textBox_unos.Text != "")
            {
                comboBox_film.Enabled = true;
                comboBox_prikazivanje.Enabled = true;
                dateTimePicker_unos.Enabled = true;
                textBox_unos.Enabled = true;
                comboBox_sala.Enabled = true;
                comboBox_tehnika.Enabled = false;
                button_unesi.Enabled = false;
                button_rezervisi.Enabled = false;
                comboBox_sala.Text = "";
                comboBox_tehnika.Text = "";
                UnesiSalaPopulate();
            }
        }

        private void textBox_unos_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_unos.Text != "" && textBox_unos.Text != "")
            {
                comboBox_film.Enabled = true;
                comboBox_prikazivanje.Enabled = true;
                dateTimePicker_unos.Enabled = true;
                textBox_unos.Enabled = true;
                comboBox_sala.Enabled = true;
                comboBox_tehnika.Enabled = false;
                button_unesi.Enabled = false;
                button_rezervisi.Enabled = false;
                comboBox_sala.Text = "";
                comboBox_tehnika.Text = "";
                UnesiSalaPopulate();
            }
        }

        private void comboBox_sala_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = true;
            dateTimePicker_unos.Enabled = true;
            textBox_unos.Enabled = true;
            comboBox_sala.Enabled = true;
            comboBox_tehnika.Enabled = true;
            button_unesi.Enabled = false;
            button_rezervisi.Enabled = false;
            comboBox_tehnika.Text = "";
            UnesiTehnikaPopulate();
        }

        private void comboBox_tehnika_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = true;
            dateTimePicker_unos.Enabled = true;
            textBox_unos.Enabled = true;
            comboBox_sala.Enabled = true;
            comboBox_tehnika.Enabled = true;
            button_unesi.Enabled = true;
            button_rezervisi.Enabled = false;
        }

        private void button_unesi_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "Insert into Repertoar (vreme_davanja, id_sala, id_tehnika, id_film) ";
            naredba += "Values('" + dateTimePicker_unos.Value.ToString("yyyy-MM-dd") + " " + textBox_unos.Text + "', '";
            naredba += comboBox_sala.SelectedValue.ToString() + "', '";
            naredba += comboBox_tehnika.SelectedValue.ToString() + "', '";
            naredba += comboBox_film.SelectedValue.ToString() + "')";
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                comboBox_film.Enabled = true;
                comboBox_prikazivanje.Enabled = false;
                dateTimePicker_unos.Enabled = false;
                textBox_unos.Enabled = false;
                comboBox_sala.Enabled = false;
                comboBox_tehnika.Enabled = false;
                button_unesi.Enabled = false;
                button_rezervisi.Enabled = false;
                button_unos.Enabled = true;
                comboBox_prikazivanje.Text = "";
                textBox_unos.Text = "";
                comboBox_sala.Text = "";
                comboBox_tehnika.Text = "";
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message, "Doslo je do greske, proverite unete podatke opet.");
            }
        }

        private void dataGridView_Repertoar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_rezervisi.Enabled = true;
        }

        private void button_rezervisi_Click(object sender, EventArgs e)
        {
            int trenutni_slog = (int) dataGridView_Repertoar.CurrentRow.Cells[0].Value;
            IzmeniStatusMesta(trenutni_slog);
            GridPopulate();
        }
    }
}