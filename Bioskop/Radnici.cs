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
    public partial class Radnici : Form
    {
        DataTable dt_Radnici = new DataTable();
        DataTable dt_Uloga = new DataTable();
        int trenutni_slog = 0;
        public Radnici()
        {
            InitializeComponent();
        }

        private void GridPopulate()
        {
            string naredba = "select id_radnik, ime, prezime, email, naziv 'uloga' from Radnik "; 
            naredba += "Join Uloga_Radnik on Radnik.id_uloga_radnik = Uloga_Radnik.id_uloga_radnik";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Radnici = new DataTable();
            adapter.Fill(dt_Radnici);
            dataGridView_radnici.DataSource = dt_Radnici;
            //dataGridView_filmovi.Columns["id_radnik"].Visible = false;
            dataGridView_radnici.AllowUserToAddRows = false;
        }

        private void UlogaPopulate()
        {
            string naredba = "Select * from Uloga_Radnik ";
            naredba += "where id_uloga_radnik != 1";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            adapter.Fill(dt_Uloga);
            comboBox_uloga.DataSource = dt_Uloga;
            comboBox_uloga.ValueMember = "id_uloga_radnik";
            comboBox_uloga.DisplayMember = "naziv";
        }

        private void Radnici_Load(object sender, EventArgs e)
        {
            GridPopulate();
            UlogaPopulate();
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "select id_uloga_radnik from Radnik ";
            naredba += "where email = '" + Form1.email + "'";
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            konekcija.Open();
            int uloga = (int)komanda.ExecuteScalar();
            konekcija.Close();
            if (uloga == 1)
            {
                textBox_ime.Text = dt_Radnici.Rows[0]["ime"].ToString();
                textBox_prezime.Text = dt_Radnici.Rows[0]["prezime"].ToString();
                textBox_email.Text = dt_Radnici.Rows[0]["email"].ToString();
                comboBox_uloga.Text = dt_Radnici.Rows[0]["uloga"].ToString(); ;
            }
            else
            {
                textBox_ime.Enabled = false;
                textBox_prezime.Enabled = false;
                textBox_email.Enabled = false;
                comboBox_uloga.Enabled = false;
            }
        }

        private void dataGridView_radnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trenutni_slog = (int)dataGridView_radnici.CurrentRow.Index;
            if (trenutni_slog != -1)
            {
                textBox_ime.Text = dataGridView_radnici.CurrentRow.Cells[1].Value.ToString();
                textBox_prezime.Text = dataGridView_radnici.CurrentRow.Cells[2].Value.ToString();
                textBox_email.Text = dataGridView_radnici.CurrentRow.Cells[3].Value.ToString();
                comboBox_uloga.Text = dataGridView_radnici.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                textBox_ime.Text = "";
                textBox_prezime.Text = "";
                textBox_email.Text = "";
                comboBox_uloga.Text = "";
            }
        }

        private void button_izmeni_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "Update Radnik ";
            naredba += "Set ime = '" + textBox_ime.Text + "', ";
            naredba += "prezime = '" + textBox_prezime.Text + "', ";
            naredba += "email = '" + textBox_email.Text + "', ";
            naredba += "id_uloga_radnik = '" + comboBox_uloga.SelectedValue + "' ";
            naredba += "where id_radnik = " + dataGridView_radnici.CurrentRow.Cells[0].Value.ToString();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                GridPopulate();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message, "Doslo je do greske, proverite unete podatke opet.");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "Delete from Radnik ";
            naredba += "where id_radnik = '" + dataGridView_radnici.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                GridPopulate();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message, "Doslo je do greske, proverite unete podatke opet.");
            }
        }
    }
}
