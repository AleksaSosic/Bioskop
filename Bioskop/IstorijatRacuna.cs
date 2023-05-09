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
    public partial class IstorijatRacuna : Form
    {
        DataTable dt_Istorijat = new DataTable();
        private void GridPopulate()
        {
            string naredba = "Select Mesto.id_mesto, Film.naziv, Film.trajanje, Mesto.broj_reda, Mesto.broj_sedista, Tip_Mesta.naziv, Repertoar_Mesto.konacna_cena, Repertoar_Mesto.status_mesta, Repertoar.vreme_davanja from Repertoar ";
            naredba += "Join Repertoar_Mesto on Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar ";
            naredba += "Join Mesto on Repertoar_Mesto.id_mesto = Mesto.id_mesto ";
            naredba += "Join Tip_Mesta on Tip_Mesta.id_tip_mesta = Mesto.id_tip_mesta ";
            naredba += "Join Film on Film.id_film = Repertoar.id_film ";
            naredba += "where status_mesta = 'prodato'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, konekcija);
            dt_Istorijat = new DataTable();
            adapter.Fill(dt_Istorijat);
            dataGridView_istorijat.DataSource = dt_Istorijat;
            //dataGridView_filmovi.Columns["id_radnik"].Visible = false;
            dataGridView_istorijat.AllowUserToAddRows = false;
        }

        public IstorijatRacuna()
        {
            InitializeComponent();
        }

        private void IstorijatRacuna_Load(object sender, EventArgs e)
        {
            GridPopulate();
        }
    }
}
