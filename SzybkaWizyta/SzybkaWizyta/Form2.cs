using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SzybkaWizyta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            string imie = null;
            string nazwisko = null;
            long pesel = 0;
            string nrtele = null;
            string email = null;
            string haslo = null;

            if (inputImie.Text != "")
            {
                imie = inputImie.Text;
            }
            if (inputNazwisko.Text != "")
            {
                nazwisko = inputNazwisko.Text;
            }
            if (inputPesel.Text != "")
            {
                pesel = Int64.Parse(inputPesel.Text);
            }
            if (inputNrtele.Text != "")
            {
                nrtele = inputNrtele.Text;
            }
            if (inputEmail.Text != "")
            {
                email = inputEmail.Text;
            }
            if (inputHaslo.Text != "")
            {
                haslo = inputHaslo.Text;
            }
            DateTime dataUrodzenia = inputDataUro.Value;
            database.OpenConnection();
            string zapytanie = "INSERT INTO Pacjent (`Pesel`, `Imie`,`Nazwisko`,`Haslo`,`DataUro`,`Email`,`NrTel`) VALUES (@Pesel, @Imie, @Nazwisko, @Haslo, @DataUro,@Email,@NrTel)";
            SQLiteCommand cmd = new SQLiteCommand(zapytanie, database.myconn);
            cmd.Parameters.AddWithValue("@Pesel", pesel);
            cmd.Parameters.AddWithValue("@Imie", imie);
            cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
            cmd.Parameters.AddWithValue("@Haslo", haslo);
            cmd.Parameters.AddWithValue("@DataUro", dataUrodzenia.ToString());
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@NrTel", nrtele);
            try
            {
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Uzytkownik dodany pomyslnie");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool userCreated = true;
            database.CloseConnection();
            if (userCreated)
            {
                //Przypisanie danych do pacjenta w klasie
                Pacjent.imie = imie;
                Pacjent.nazwisko = nazwisko;
                Pacjent.pesel = pesel;
                Pacjent.data_urodzenia = dataUrodzenia.ToString();
                Pacjent.email = email;
                Pacjent.nrtelefonu = nrtele;

                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
