using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzybkaWizyta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int pesel=0;
            string haslo="";
            if(inputPesel.Text != "")
            {
                pesel = int.Parse(inputPesel.Text);
            }
            if(inputHaslo.Text != "")
            {
                haslo = inputHaslo.Text;
            }
            Database databaseObj = new Database();
            string zapytanieUser = $"SELECT * FROM Pacjent WHERE pesel={pesel} AND haslo = '{haslo}'";
            string zapytanieLekarz = $"SELECT * FROM Lekarz WHERE Id={pesel} AND haslo = '{haslo}'";
            SQLiteCommand zapytanieU = new SQLiteCommand(zapytanieUser , databaseObj.myconn);
            SQLiteCommand zapytanieL = new SQLiteCommand(zapytanieLekarz , databaseObj.myconn);
            databaseObj.OpenConnection();
            SQLiteDataReader wynikU = zapytanieU.ExecuteReader();
            SQLiteDataReader wynikL = zapytanieL.ExecuteReader();
            bool userExists = false;
            bool isLekarz = false;
            if (wynikU.HasRows)
            {
                userExists = true;
                
            }
            if (wynikL.HasRows)
            {
                isLekarz = true;
            }

            databaseObj.CloseConnection();
            

            if (userExists)
            {
                labelNotExist.Text = "";
                //dane tego uzytkownika z bazy przypisujesz do klasy pacjent
                //przyklad
                wynikU.Read();
                string imie = wynikU["Imie"].ToString();
                string pesel1 = wynikU["Pesel"].ToString();
                string nazwisko = wynikU["Nazwisko"].ToString();
                string dataUro = wynikU["DataUro"].ToString();
                string email = wynikU["Email"].ToString();
                string nrTel = wynikU["NrTel"].ToString();
                Pacjent.imie = imie;
                Pacjent.pesel = Int64.Parse(pesel1);
                Pacjent.nazwisko = nazwisko;
                Pacjent.data_urodzenia = dataUro;
                Pacjent.email = email;
                Pacjent.nrtelefonu = nrTel;
                wynikU.Close();
                wynikL.Close();
                Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            wynikU.Close();
            wynikL.Close();
            if (isLekarz)
            {
                Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            else
            {
                labelNotExist.Text = "Konto o podanych danych nie istnieje.";
            }
            
            
        }

        private void labelRejestracja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
