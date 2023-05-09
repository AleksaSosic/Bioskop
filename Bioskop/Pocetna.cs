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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            /*string naredba = "select id_uloga_radnik from Radnik ";
            naredba += "where email = '" + Form1.email + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            konekcija.Open();
            int uloga = (int) komanda.ExecuteScalar();
            konekcija.Close();
            if (uloga == 2)
            {
            }
            else if (uloga == 3)
            {
            }*/
        }

        private void filmoviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filmovi nova = new Filmovi();
            nova.ShowDialog();
        }

        private void filmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repertoar nova = new Repertoar();
            nova.ShowDialog();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasa nova = new Kasa();
            nova.ShowDialog();
        }

        private void radniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radnici nova = new Radnici();
            nova.ShowDialog();
        }

        private void istorijatRacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstorijatRacuna nova = new IstorijatRacuna();
            nova.ShowDialog();
        }
    }
}