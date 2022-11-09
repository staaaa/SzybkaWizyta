using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SzybkaWizyta
{
    public partial class Form4 : Form
    {
        string[] godziny = { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00" };
        List<string> wszystkieGodziny = new List<string>();
        public Form4()
        {
            InitializeComponent();
            labelLekarz.Text = WybranyLekarz.imie + " " + WybranyLekarz.nazwisko;
            labelGodzina.Visible = false;
            godzinaPicker.Visible = false;
            wszystkieGodziny.AddRange(godziny);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labelGodzina.Visible = true;
            godzinaPicker.Visible = true;
            List<string> godzinyZajete = new List<string>();
            string data = dataWizyty.CustomFormat = "dd.MM.yyyy";
            Database database = new Database();
            string zapytanie = $"SELECT GodzinaWizyty FROM Wizyty WHERE DataWizyty = '{data}'";
            database.OpenConnection();
            SQLiteCommand zapytanieD = new SQLiteCommand(zapytanie, database.myconn);
            SQLiteDataReader wynikA = zapytanieD.ExecuteReader();
            if (wynikA.HasRows)
            {
                wynikA.Read();
                string zabranaData = wynikA["GodzinaWizyty"].ToString();
                godzinyZajete.Add(zabranaData);
            }
            wynikA.Close();
            database.CloseConnection();
            //leci request do bazy i pobieramy wszystkie godziny z danego dnia i przypisujesz do arraya

            for (int i = 0; i < wszystkieGodziny.Count; i++)
            {
                if (!godzinyZajete.Contains(wszystkieGodziny[i]))
                {
                    godzinaPicker.Items.Add(wszystkieGodziny[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = dataWizyty.Value.ToString();
            string godzina = godzinaPicker.SelectedItem.ToString();
            ////tu puszczasz zapytanie
            int pozycja = data.IndexOf(" ");
            string concat="";
            for (int i = 0; i < pozycja; i++)
            {
                concat += data[i];
            }
            string data1 = concat;
            Database databaseObj = new Database();
            string lekarz="";
            using (SQLiteConnection c = new SQLiteConnection(databaseObj.myconn))
            {
                c.Open();
                string sql = $"SELECT id FROM Lekarz WHERE Imie = '{WybranyLekarz.imie}' AND Nazwisko = '{WybranyLekarz.nazwisko}'";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader wynikD = cmd.ExecuteReader())
                    {
                        while (wynikD.Read())
                        {
                            string wybraneImie = wynikD["id"].ToString();
                            lekarz = wybraneImie;
                        }
                        wynikD.Close();
                    }
                }
            }


            using (SQLiteConnection c = new SQLiteConnection(databaseObj.myconn))
            {
                c.Open();
                string sql = "INSERT INTO Wizyty (`IdPacjenta`, `IdLekarza`,`GodzinaWizyty`,`DataWizyty`) VALUES (@IdPacjenta, @IdLekarza, @GodzinaWizyty, @DataWizyty)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.Parameters.AddWithValue("@IdPacjenta", Pacjent.pesel);
                    cmd.Parameters.AddWithValue("@IdLekarza", lekarz);
                    cmd.Parameters.AddWithValue("@GodzinaWizyty", godzina);
                    cmd.Parameters.AddWithValue("@DataWizyty", data1);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Pomyslnie dodano wizytę! ");
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }

}

