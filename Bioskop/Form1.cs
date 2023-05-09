using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Bioskop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_visibility_Click(object sender, EventArgs e)
        {
            if (textBox_sifra.PasswordChar == '*')
            {
                textBox_sifra.PasswordChar = '\0';
                button_visibility.Text = "O";
            }
            else
            {
                textBox_sifra.PasswordChar = '*';
                button_visibility.Text = "Ø";
            }
        }

        public static string email;

        public void button_log_in_Click(object sender, EventArgs e)
        {
            string naredba = "select sifra from Radnik ";
            naredba += "where email = '" + textBox_email.Text + "'";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            string tacna_sifra = "";
            try
            {
                konekcija.Open();
                tacna_sifra = (string)komanda.ExecuteScalar();
                konekcija.Close();
            }
            catch 
            {
                MessageBox.Show("Doslo je do greske, pokusajte ponovo.", "Greska");
                return;
            }
            if (textBox_sifra.Text == tacna_sifra)
            {
                email = textBox_email.Text;
                Pocetna nova = new Pocetna();
                nova.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Doslo je do greske, pokusajte ponovo.", "Greska");
            }
        }

        private void linkLabel_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp nova = new SignUp();
            nova.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["Master"].ConnectionString);
            string naredba = "CREATE DATABASE bioskop";
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch { }
            veza = new SqlConnection(ConfigurationManager.ConnectionStrings["Bioskop"].ConnectionString);
            naredba = "create table Uloga_Radnik(\r\nid_uloga_radnik Int Constraint PK_Uloga_Radnik Primary Key Identity(1, 1),\r\nnaziv Nvarchar(20)\r\n) \r\n\r\ncreate table Radnik(\r\nid_radnik Int Constraint PK_Radnik Primary Key Identity(1, 1),\r\nime Nvarchar(20),\r\nprezime Nvarchar(20),\r\nemail Nvarchar(50) Check (email Like '%_@_%._%'),\r\nsifra Nvarchar(50),\r\nid_uloga_radnik Int Constraint FK_Radnik_Uloga_Radnik Foreign Key References Uloga_Radnik(id_uloga_radnik)\r\n)\r\n\r\ndrop table Radnik\r\n\r\ncreate table Tip_Mesta(\r\nid_tip_mesta Int Constraint PK_Tip_Mesta Primary Key Identity(1, 1),\r\nnaziv Nvarchar(20),\r\npocetna_cena_mesta Decimal(10, 2)\r\n)\r\n\r\ncreate table Mesto(\r\nid_mesto Int Constraint PK_Mesto Primary Key Identity(1, 1),\r\nbroj_reda Int,\r\nbroj_sedista Int,\r\nid_tip_mesta Int Constraint FK_Mesto_Tip_Mesta Foreign Key References Tip_Mesta(id_tip_mesta),\r\nid_sala Int Constraint FK_Mesto_Sala Foreign Key References Sala(id_sala)\r\n)\r\n\r\ncreate table Sala(\r\nid_sala Int Constraint PK_Sala Primary Key Identity(1, 1),\r\nkapacitet Int,\r\nnaziv Nvarchar(20)\r\n)\r\n\r\ncreate table Tehnika(\r\nid_tehnika Int Constraint PK_Tehnika Primary Key Identity(1, 1),\r\nnaziv Nvarchar(20),\r\ndodatna_cena_tehnika Decimal(10, 2)\r\n)\r\n\r\ncreate table Repertoar(\r\nid_repertoar Int Constraint PK_Repertoar Primary Key Identity(1, 1),\r\nvreme_davanja Smalldatetime,\r\nkvota_naplacivanja Decimal(2, 1) Null,\r\nid_sala Int Constraint FK_Repertoar_Sala Foreign Key References Sala(id_sala),\r\nid_tehnika Int Constraint FK_Repertoar_Tehnika Foreign Key References Tehnika(id_tehnika),\r\nid_film Int Constraint FK_Repertoar_Film Foreign Key References Film(id_film),\r\n)\r\n\r\ncreate table Repertoar_Mesto(\r\nid_repertoar_mesto Int Constraint PK_Repertoar_Mesto Primary Key Identity(1, 1),\r\nstatus_mesta Nvarchar(20) Null,\r\nkonacna_cena Decimal(10, 2) Null,\r\nid_repertoar Int Constraint FK_Repertoar_Mesto_Repertoar Foreign Key References Repertoar(id_repertoar),\r\nid_mesto Int Constraint FK_Repertoar_Mesto_Mesto Foreign Key References Mesto(id_mesto)\r\n)\r\n\r\ncreate table Ocena(\r\nid_ocena Int Constraint PK_Ocena Primary Key Identity(1, 1),\r\nopis Nvarchar(200),\r\nbroj_zvezdica Int Check (broj_zvezdica <= 5 and broj_zvezdica >= 1)\r\n)\r\n\r\ncreate table Ocena_Film(\r\nid_ocena_film Int Constraint PK_Ocena_Film Primary Key Identity(1, 1),\r\nbroj_ocena Int,\r\nprosecna_ocena Decimal(3, 2),\r\nid_film Int Constraint FK_Ocena_Film_Film Foreign Key References Film(id_film),\r\nid_ocena Int Constraint FK_Ocena_Film_Ocena Foreign Key References Ocena(id_ocena)\r\n)\r\n\r\ncreate table Film(\r\nid_film Int Constraint PK_Film Primary Key Identity(1, 1),\r\nnaziv Nvarchar(50),\r\ntrajanje Time\r\n)\r\n\r\ncreate table Zanr(\r\nid_zanr Int Constraint PK_Zanr Primary Key Identity(1, 1),\r\nnaziv Nvarchar(20)\r\n)\r\n\r\ncreate table Zanr_Film(\r\nid_zanr_film Int Constraint PK_Zanr_Film Primary Key Identity(1, 1),\r\nid_film Int Constraint FK_Zanr_Film_Film Foreign Key References Film(id_film),\r\nid_zanr Int Constraint FK_Zanr_Film_Zanr Foreign Key References Zanr(id_zanr)\r\n)\r\n\r\ncreate table Osoba(\r\nid_osoba Int Constraint PK_Osoba Primary Key Identity(1, 1),\r\nime Nvarchar(20),\r\nprezime Nvarchar(20)\r\n)\r\n\r\ncreate table Osoba_Film(\r\nid_osoba_film Int Constraint PK_Osoba_Film Primary Key Identity(1, 1),\r\nuloga Nvarchar(20) Null,\r\nid_film Int Constraint FK_Osoba_Film_Film Foreign Key References Film(id_film),\r\nid_osoba Int Constraint FK_Osoba_Film_Osoba Foreign Key References Osoba(id_osoba)\r\n)";
            komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch { }
            naredba = "create trigger Generisi_Kvotu_Naplacivanja\r\non Repertoar\r\nafter insert, update\r\nas\r\nbegin\r\n\tdeclare @kvota as Decimal(2,1)\r\n\tSet @kvota = 0\r\n\tif (((select cast(vreme_davanja as time) from inserted) >= '12:00:00') and ((select cast(vreme_davanja as time) from inserted) <= '15:30:00')) \r\n\t\tSet @kvota = 0.8\r\n\telse\r\n\tbegin\r\n\t\tif (((select cast(vreme_davanja as time) from inserted) > '15:30:00') and ((select cast(vreme_davanja as time) from inserted) <= '19:00:00')) \r\n\t\tSet @kvota = 1.0\r\n\t\telse\r\n\t\tbegin\r\n\t\t\tif (((select cast(vreme_davanja as time) from inserted) > '19:00:00') and ((select cast(vreme_davanja as time) from inserted) <= '23:30:00')) \r\n\t\t\tSet @kvota = 1.2\r\n\t\tend\r\n\tend\r\n\tUpdate Repertoar\r\n\tSet kvota_naplacivanja = @kvota\r\n\twhere id_repertoar = (select id_repertoar from inserted)\r\nend;\r\n\r\ncreate trigger Repertoar_Mesto_Ins\r\non Repertoar_Mesto\r\nafter insert\r\nas \r\nbegin\r\n\r\n\r\n\tDeclare @cena as Decimal(10, 2)\r\n\tSet @cena = 0\r\n\tSet @cena =\r\n\t\t((select Tip_Mesta.pocetna_cena_mesta from Repertoar_Mesto\r\n\t\tJoin Mesto On Mesto.id_mesto = Repertoar_Mesto.id_mesto\r\n\t\tJoin Tip_Mesta On Tip_Mesta.id_tip_mesta = Mesto.id_tip_mesta\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)) +\r\n\t\t\r\n\t\t(select Tehnika.dodatna_cena_tehnika from Repertoar_Mesto\r\n\t\tJoin Repertoar On Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar\r\n\t\tJoin Tehnika On Tehnika.id_tehnika = Repertoar.id_tehnika\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted))) * \r\n\t\t\r\n\t\t(select Repertoar.kvota_naplacivanja from Repertoar_Mesto\r\n\t\tJoin Repertoar On Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted))\r\n\r\n\tUpdate Repertoar_Mesto\r\n\tSet konacna_cena = @cena\r\n\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)\r\n\r\n\r\n\tUpdate Repertoar_Mesto\r\n\tSet status_mesta = 'slobodan'\r\n\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)\r\n\r\n\r\n\tif ((select id_sala from Repertoar\r\n\t\tJoin Repertoar_Mesto On Repertoar.id_repertoar = Repertoar_Mesto.id_repertoar\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)) !=\r\n\t\t(select id_sala from Mesto\r\n\t\tJoin Repertoar_Mesto On Mesto.id_mesto = Repertoar_Mesto.id_mesto\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)))\r\n\t\tbegin\r\n\t\t\tDelete Repertoar_Mesto\r\n\t\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)\r\n\t\tend\r\n\r\n\r\nend;\r\n\r\ncreate trigger Repertoar_Mesto_Upd\r\non Repertoar_Mesto\r\nafter update\r\nas \r\nbegin\r\n\r\n\r\n\tDeclare @cena as Decimal(10, 2)\r\n\tSet @cena = 0\r\n\tSet @cena =\r\n\t\t((select Tip_Mesta.pocetna_cena_mesta from Repertoar_Mesto\r\n\t\tJoin Mesto On Mesto.id_mesto = Repertoar_Mesto.id_mesto\r\n\t\tJoin Tip_Mesta On Tip_Mesta.id_tip_mesta = Mesto.id_tip_mesta\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)) +\r\n\t\t\r\n\t\t(select Tehnika.dodatna_cena_tehnika from Repertoar_Mesto\r\n\t\tJoin Repertoar On Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar\r\n\t\tJoin Tehnika On Tehnika.id_tehnika = Repertoar.id_tehnika\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted))) * \r\n\t\t\r\n\t\t(select Repertoar.kvota_naplacivanja from Repertoar_Mesto\r\n\t\tJoin Repertoar On Repertoar_Mesto.id_repertoar = Repertoar.id_repertoar\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted))\r\n\r\n\tUpdate Repertoar_Mesto\r\n\tSet konacna_cena = @cena\r\n\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)\r\n\r\n\r\n\tif ((select id_sala from Repertoar\r\n\t\tJoin Repertoar_Mesto On Repertoar.id_repertoar = Repertoar_Mesto.id_repertoar\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)) !=\r\n\t\t(select id_sala from Mesto\r\n\t\tJoin Repertoar_Mesto On Mesto.id_mesto = Repertoar_Mesto.id_mesto\r\n\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from inserted)))\r\n\t\tbegin\r\n\t\t\tUpdate Repertoar_Mesto\r\n\t\t\tSet id_mesto = (select id_mesto from deleted)\r\n\t\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from deleted)\r\n\r\n\t\t\tUpdate Repertoar_Mesto\r\n\t\t\tSet id_repertoar = (select id_repertoar from deleted)\r\n\t\t\twhere id_repertoar_mesto = (select id_repertoar_mesto from deleted)\r\n\t\tend\r\n\r\n\r\nend;\r\n\r\ncreate trigger Generisanje_Repertoar_Mesto\r\non Repertoar\r\nafter insert\r\nas\r\nbegin\r\n\tDeclare @sala as int = (select id_sala from inserted)\r\n\tDeclare @repertoar as int = (select id_repertoar from inserted)\r\n\tDeclare @do as int = (select Sum(kapacitet) from Sala where id_sala < (@sala + 1));\r\n\tDeclare @i as int = (select Sum(kapacitet) from Sala where id_sala < @sala);\r\n\tWhile @i < @do\r\n\tbegin\r\n\t\tSet @i = @i + 1\r\n\t\tInsert Into Repertoar_Mesto (id_repertoar, id_mesto)\r\n\t\tValues (@repertoar, @i)\r\n\tend\r\nend;\r\n\r\ncreate trigger Obrisi_Repertoar_Mesto\r\non Repertoar\r\nafter delete\r\nas\r\nbegin\r\n\tDeclare @repertoar as int = (select id_repertoar from deleted)\r\n\tdelete Repertoar_Mesto\r\n\twhere id_repertoar = @repertoar\r\nend;";
            komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch { }


        }
    }
}
