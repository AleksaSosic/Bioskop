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
    public partial class SignUp : Form
    {
        public SignUp()
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

        private void button_sign_up_Click(object sender, EventArgs e)
        {
            int provera = 0;
            string naredba = "Insert Into Radnik Values('";
            naredba += textBox_ime.Text + "', '";
            naredba += textBox_prezime.Text + "', '";
            naredba += textBox_email.Text + "', '";
            naredba += textBox_sifra.Text + "', ";
            naredba += 3 + ")";
            SqlConnection konekcija = Konekcija.Konekcija.KonektujSe();
            SqlCommand komanda = new SqlCommand(naredba, konekcija);
            string naredba1 = "select COUNT(*) from Radnik ";
            naredba1 += "where email = '" + textBox_email.Text + "'";
            SqlCommand komanda1 = new SqlCommand(naredba1, konekcija);
            konekcija.Open();
            provera = (int) komanda1.ExecuteScalar();
            konekcija.Close();
            if (provera == 0)
            {
                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    konekcija.Close();
                    this.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message, "Doslo je do greske, proverite unete podatke opet.");
                }
            }
            else
            {
                MessageBox.Show("Doslo je do greske, uneti mejl vec postoji, proverite unete podatke opet.", "Greska");
            }
        }
    }
}
