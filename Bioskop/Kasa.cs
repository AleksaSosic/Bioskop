using Bioskop.Konekcija;
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
    public partial class Kasa : Form
    {
        DataTable dt_Kasa = new DataTable();
        DataTable dt_Film = new DataTable();
        DataTable dt_Vreme = new DataTable();
        DataTable dt_Red = new DataTable();
        DataTable dt_BrojSedista = new DataTable();
        private void GridPopulate()
        {
            string naredba = "Select Mesto.id_mesto, Film.naziv 'film naziv', Film.trajanje, Mesto.broj_reda, Mesto.broj_sedista, Tip_Mesta.naziv 'tip naziv', Repertoar_Mesto.konacna_cena, Repertoar_Mesto.status_mesta, Repertoar.vreme_davanja from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "Join Mesto on Repertoar_Mesto.id_mesto = Mesto.id_mesto ";
            naredba += "Join Tip_Mesta on Tip_Mesta.id_tip_mesta = Mesto.id_tip_mesta ";
            naredba += "Join Film on Film.id_film = Repertoar.id_film ";
            naredba += "where status_mesta = 'rezervisano'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Kasa = new DataTable();
            adapter.Fill(dt_Kasa);
            dataGridView_Kasa.DataSource = dt_Kasa;
            //dataGridView_filmovi.Columns["id_radnik"].Visible = false;
            dataGridView_Kasa.AllowUserToAddRows = false;
        }

        private void GridPretraga()
        {
            string naredba = "Select Mesto.id_mesto, Film.naziv 'film naziv', Film.trajanje, Mesto.broj_reda, Mesto.broj_sedista, Tip_Mesta.naziv 'tip naziv', Repertoar_Mesto.konacna_cena, Repertoar_Mesto.status_mesta, Repertoar.vreme_davanja from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "Join Mesto on Repertoar_Mesto.id_mesto = Mesto.id_mesto ";
            naredba += "Join Tip_Mesta on Tip_Mesta.id_tip_mesta = Mesto.id_tip_mesta ";
            naredba += "Join Film on Film.id_film = Repertoar.id_film ";
            naredba += "where status_mesta = 'rezervisano' and ";
            naredba += "broj_reda = '" + comboBox_broj_reda.SelectedValue + "' and ";
            naredba += "broj_sedista = '" + comboBox_broj_sedista.SelectedValue + "' and ";
            naredba += "Film.id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Kasa = new DataTable();
            adapter.Fill(dt_Kasa);
            dataGridView_Kasa.DataSource = dt_Kasa;
            //dataGridView_filmovi.Columns["id_radnik"].Visible = false;
            dataGridView_Kasa.AllowUserToAddRows = false;
        }

        private void FilmPopulate()
        {
            string naredba = "Select Distinct Film.id_film, Film.naziv from Film ";
            naredba += "Join Repertoar on Repertoar.id_film = Film.id_film ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "where status_mesta = 'rezervisano'";
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
            string naredba = "Select Distinct vreme_davanja from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "status_mesta = 'rezervisano'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Vreme = new DataTable();
            adapter.Fill(dt_Vreme);
            comboBox_prikazivanje.DataSource = dt_Vreme;
            comboBox_prikazivanje.ValueMember = "vreme_davanja";
            comboBox_prikazivanje.Text = "";
        }

        private void RedPopulate()
        {
            string naredba = "Select Distinct broj_reda from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "Join Mesto on Repertoar_Mesto.id_mesto = Mesto.id_mesto ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "' and ";
            naredba += "status_mesta = 'rezervisano'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Red = new DataTable();
            adapter.Fill(dt_Red);
            comboBox_broj_reda.DataSource = dt_Red;
            comboBox_broj_reda.ValueMember = "broj_reda";
            comboBox_broj_reda.Text = "";
        }

        private void BrojSedistaPopulate()
        {
            string naredba = "Select Distinct broj_sedista from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "Join Mesto on Repertoar_Mesto.id_mesto = Mesto.id_mesto ";
            naredba += "where id_film = '" + comboBox_film.SelectedValue.ToString() + "' and ";
            naredba += "vreme_davanja = '" + comboBox_prikazivanje.SelectedValue.ToString() + "' and ";
            naredba += "broj_reda = '" + comboBox_broj_reda.SelectedValue.ToString() + "' and ";
            naredba += "status_mesta = 'rezervisano'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_BrojSedista = new DataTable();
            adapter.Fill(dt_BrojSedista);
            comboBox_broj_sedista.DataSource = dt_BrojSedista;
            comboBox_broj_sedista.ValueMember = "broj_sedista";
            comboBox_broj_sedista.Text = "";
        }

        public Kasa()
        {
            InitializeComponent();
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            GridPopulate();
            FilmPopulate();
        }

        private void comboBox_film_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = true;
            comboBox_broj_reda.Enabled = false;
            comboBox_broj_sedista.Enabled = false;
            button_prikazi_sve.Enabled = false;
            button_prodaja.Enabled = false;
            comboBox_broj_reda.Text = "";
            comboBox_broj_sedista.Text = "";
            VremePopulate();
        }

        private void comboBox_prikazivanje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = true;
            comboBox_broj_reda.Enabled = true;
            comboBox_broj_sedista.Enabled = false;
            button_prikazi_sve.Enabled = false;
            button_prodaja.Enabled = false;
            comboBox_broj_sedista.Text = "";
            RedPopulate();
        }

        private void comboBox_broj_reda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = true;
            comboBox_broj_reda.Enabled = true;
            comboBox_broj_sedista.Enabled = true;
            button_prikazi_sve.Enabled = false;
            button_prodaja.Enabled = false;
            BrojSedistaPopulate();
        }

        private void comboBox_broj_sedista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button_prikazi_sve.Enabled = true;
            button_prodaja.Enabled = false;
            GridPretraga();
        }

        private void button_prikazi_sve_Click(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = false;
            comboBox_broj_reda.Enabled = false;
            comboBox_broj_sedista.Enabled = false;
            button_prikazi_sve.Enabled = false;
            button_prodaja.Enabled = false;
            comboBox_film.Text = "";
            comboBox_prikazivanje.Text = "";
            comboBox_broj_reda.Text = "";
            comboBox_broj_sedista.Text = "";
            GridPopulate();
        }

        private void button_prodaja_Click(object sender, EventArgs e)
        {
            comboBox_film.Enabled = true;
            comboBox_prikazivanje.Enabled = false;
            comboBox_broj_reda.Enabled = false;
            comboBox_broj_sedista.Enabled = false;
            button_prikazi_sve.Enabled = false;
            button_prodaja.Enabled = false;
            string naredba = "Update Repertoar_Mesto ";
            naredba += "Set status_mesta = 'prodato' ";
            naredba += "where id_repertoar = ";
            naredba += "(Select id_repertoar from Repertoar ";
            naredba += "where vreme_davanja = '" + dataGridView_Kasa.CurrentRow.Cells[8].Value.ToString() + "') and ";
            naredba += "id_mesto = '" + dataGridView_Kasa.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                comboBox_film.Enabled = true;
                comboBox_prikazivanje.Enabled = false;
                comboBox_broj_reda.Enabled = false;
                comboBox_broj_sedista.Enabled = false;
                button_prikazi_sve.Enabled = false;
                button_prodaja.Enabled = false;
                comboBox_film.Text = "";
                comboBox_prikazivanje.Text = "";
                comboBox_broj_reda.Text = "";
                comboBox_broj_sedista.Text = "";
                GridPopulate();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message, "Doslo je do greske, proverite unete podatke opet.");
            }
        }

        private void dataGridView_Kasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_prodaja.Enabled = true;
        }
    }
}
