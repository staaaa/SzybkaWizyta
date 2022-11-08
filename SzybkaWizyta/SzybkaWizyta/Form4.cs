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
            //string data = dataWizyty.CustomFormat = "dd.MM.yyyy";
            //Database database = new Database();
            //string zapytanie = $"SELECT GodzinaWizyty FROM Wizyty WHERE DataWizyty = '{data}'";
            //database.OpenConnection();
            //SQLiteCommand zapytanieD = new SQLiteCommand(zapytanie, database.myconn);
            //SQLiteDataReader wynikA = zapytanieD.ExecuteReader();
            //if (wynikA.HasRows)
            //{
            //    wynikA.Read();
            //    string zabranaData = wynikA["GodzinaWizyty"].ToString();
            //    godzinyZajete.Add(zabranaData);
            //}
            //wynikA.Close();
            //database.CloseConnection();
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
            DateTime data = dataWizyty.Value;
            string godzina = godzinaPicker.SelectedItem.ToString();
            //tu puszczasz zapytanie
            MessageBox.Show("Zostałes zarejestrowany do:\r"
                + WybranyLekarz.imie + " "
                + WybranyLekarz.nazwisko +
                "\rdnia " + data +
                "\ro godzinie: " + godzina, "Udało się!");
            Database database = new Database();
            database.OpenConnection();
            string zapytanie = "INSERT INTO Pacjent (`pesel`) VALUES (@pesel)";
            SQLiteCommand cmd = new SQLiteCommand(zapytanie, database.myconn);
            cmd.Parameters.AddWithValue("@pesel", 101);
            try
            {
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show("Uzytkownik dodany pomyslnie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //string query = "INSERT INTO Wizyty (`IdWizyty`, `IdPacjenta`,`IdLekarza`,`GodzinaWizyty`,`DataWizyty`) VALUES (@Id, @IdPacjenta, @IdLekarza, @GodzinaWizyty, @DataWizyty)";
            //SQLiteCommand mycommand = new SQLiteCommand(query, database.myconn);


            //string data1 = dataWizyty.CustomFormat = "dd.MM.yyyy";

            //mycommand.Parameters.AddWithValue("@Id", 1);
            //mycommand.Parameters.AddWithValue("@IdPacjenta", Pacjent.pesel);
            //mycommand.Parameters.AddWithValue("@IdLekarza", WybranyLekarz.id);
            //mycommand.Parameters.AddWithValue("@GodzinaWizyty", godzinaPicker.SelectedItem.ToString());
            //mycommand.Parameters.AddWithValue("@DataWizyty", data1);
            //var result = mycommand.ExecuteNonQuery();
            database.CloseConnection();

            MessageBox.Show("Pomyslnie dodano wizytę! ");
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void godzinaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
