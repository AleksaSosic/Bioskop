using Bioskop.Konekcija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop
{
    public partial class Filmovi : Form
    {
        int trenutni_slog = -1;
        DataTable dt_Filmovi = new DataTable();
        public Filmovi()
        {
            InitializeComponent();
        }

        private void GridPopulate()
        {
            string naredba = "Select * from Film";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Filmovi = new DataTable();
            adapter.Fill(dt_Filmovi);
            dataGridView_filmovi.DataSource = dt_Filmovi;
            dataGridView_filmovi.AllowUserToAddRows = false;
        }

        private void Filmovi_Load(object sender, EventArgs e)
        {
            GridPopulate();
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "select id_uloga_radnik from Radnik ";
            naredba += "where email = '" + Form1.email + "'";
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            konekcija.Open();
            int uloga = (int)komanda.ExecuteScalar();
            konekcija.Close();
            if (uloga == 3)
            {
                textBox_naziv.Enabled = false;
                textBox_trajanje.Enabled = false;
                button_unesi.Enabled = false;
                button_izmeni.Enabled = false;
                button_delete.Enabled = false;
            }
            else
            {
                textBox_naziv.Text = dt_Filmovi.Rows[0]["naziv"].ToString();
                textBox_trajanje.Text = dt_Filmovi.Rows[0]["trajanje"].ToString();
            }
        }

        private void button_unesi_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "Insert into Film (naziv, trajanje) ";
            naredba += "Values('" + textBox_naziv.Text + "', '";
            naredba += textBox_trajanje.Text + "')";
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

        private void dataGridView_filmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trenutni_slog = (int) dataGridView_filmovi.CurrentRow.Cells[0].Value;
            if (trenutni_slog != -1)
            {
                textBox_naziv.Text = dataGridView_filmovi.CurrentRow.Cells[1].Value.ToString();
                textBox_trajanje.Text = dataGridView_filmovi.CurrentRow.Cells[2].Value.ToString();
            }
            else 
            {
                textBox_naziv.Text = "";
                textBox_trajanje.Text = "";
            }
        }

        private void button_izmeni_Click(object sender, EventArgs e)
        {
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            string naredba = "Update Film ";
            naredba += "Set naziv = '" + textBox_naziv.Text + "', ";
            naredba += "trajanje = '" + textBox_trajanje.Text + "' ";
            naredba += "where id_film = " + dataGridView_filmovi.CurrentRow.Cells[0].Value.ToString();
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
            string naredba = "Delete from Film ";
            naredba += "where id_film = " + dataGridView_filmovi.CurrentRow.Cells[0].Value.ToString();
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
