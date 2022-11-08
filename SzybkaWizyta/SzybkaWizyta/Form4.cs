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
            //labelLekarz.Text = WybranyLekarz.imie + " " + WybranyLekarz.nazwisko;
            //labelGodzina.Visible = false;
            //godzinaPicker.Visible = false;
            //wszystkieGodziny.AddRange(godziny);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //labelGodzina.Visible = true;
            //godzinaPicker.Visible = true;
            //List<string> godzinyZajete = new List<string>();
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
            ////leci request do bazy i pobieramy wszystkie godziny z danego dnia i przypisujesz do arraya

            //for (int i = 0; i < wszystkieGodziny.Count; i++)
            //{
            //    if (!godzinyZajete.Contains(wszystkieGodziny[i]))
            //    {
            //        godzinaPicker.Items.Add(wszystkieGodziny[i]);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime data = dataWizyty.Value;
            //string godzina = godzinaPicker.SelectedItem.ToString();
            //////tu puszczasz zapytanie
            //MessageBox.Show("Zostałes zarejestrowany do:\r"
            //    + WybranyLekarz.imie + " "
            //    + WybranyLekarz.nazwisko +
            //    "\rdnia " + data +
            //    "\ro godzinie: " + godzina, "Udało się!");

            //string data1 = dataWizyty.CustomFormat = "dd.MM.yyyy";
            //Database databaseObj = new Database();
            //using (SQLiteConnection c = new SQLiteConnection(databaseObj.myconn))
            //{
            //    c.Open();
            //    string sql = "INSERT INTO Wizyty (`IdPacjenta`, `IdLekarza`,`GodzinaWizyty`,`DataWizyty`) VALUES (@IdPacjenta, @IdLekarza, @GodzinaWizyty, @DataWizyty)";
            //    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
            //    {
            //        cmd.Parameters.AddWithValue("@IdPacjenta", Pacjent.pesel);
            //        cmd.Parameters.AddWithValue("@IdLekarza", WybranyLekarz.id);
            //        cmd.Parameters.AddWithValue("@GodzinaWizyty", godzina);
            //        cmd.Parameters.AddWithValue("@DataWizyty", data1);
            //        cmd.ExecuteNonQuery();
            //    }
            //}

            //MessageBox.Show("Pomyslnie dodano wizytę! ");
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Database databaseObj = new Database();
            using (SQLiteConnection c = new SQLiteConnection(databaseObj.myconn))
            {
                c.Open();
                string sql = "INSERT INTO Pacjent (Pesel, Imie, Nazwisko, Haslo, DataUro, Email, NrTel) VALUES (@p,@i,@n,@h,@d,@e,@nr)";
                //"INSERT INTO Pacjent (`Pesel`, `Imie`,`Nazwisko`,`Haslo`,`DataUro`,`Email`,`NrTel`) VALUES (@Pesel, @Imie, @Nazwisko, @Haslo, @DataUro,@Email,@NrTel)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.Parameters.AddWithValue("p", 1234576);
                    cmd.Parameters.AddWithValue("i", "kewin");
                    cmd.Parameters.AddWithValue("n", "pat");
                    cmd.Parameters.AddWithValue("h", "xyz");
                    cmd.Parameters.AddWithValue("d", "111");
                    cmd.Parameters.AddWithValue("e", "cos@wp.pl");
                    cmd.Parameters.AddWithValue("nr", 1234);
                    cmd.Prepare();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                }
            }
        }
        //Database database = new Database();
        //database.OpenConnection();
        //string zapytanie = "INSERT INTO Pacjent (`Pesel`, `Imie`,`Nazwisko`,`Haslo`,`DataUro`,`Email`,`NrTel`) VALUES (@Pesel, @Imie, @Nazwisko, @Haslo, @DataUro,@Email,@NrTel)";
        //SQLiteCommand cmd = new SQLiteCommand(zapytanie, database.myconn);
        //cmd.Parameters.AddWithValue("@Pesel", 123);
        //cmd.Parameters.AddWithValue("@Imie", "kewin");
        //cmd.Parameters.AddWithValue("@Nazwisko", "pat");
        //cmd.Parameters.AddWithValue("@Haslo", "xyz");
        //cmd.Parameters.AddWithValue("@DataUro", "111");
        //cmd.Parameters.AddWithValue("@Email", "cos@wp.pl");
        //cmd.Parameters.AddWithValue("@NrTel", 1234);
        //try
        //{
        //    var result = cmd.ExecuteNonQuery();
        //    MessageBox.Show("Uzytkownik dodany pomyslnie");
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
        //database.CloseConnection();
    }

}

