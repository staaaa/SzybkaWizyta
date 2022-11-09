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
    public partial class Form5 : Form
    {
        List<Label> allLabels = new List<Label>();
        public Form5()
        {
            InitializeComponent();
        }

        private void dataWizyty_ValueChanged(object sender, EventArgs e)
        {
            //TU UTWORZYSZ JAKAS LISTE ZE WSZYSTKIMI WIZYTAMI.
            //lista wizyt
            List<string> wizyty = new List<string>();
            string data = dataWizyty.Value.ToString();
            int pozycja = data.IndexOf(" ");
            string concat1 = "";
            for (int i = 0; i < pozycja; i++)
            {
                concat1 += data[i];
            }
            string data1 = concat1;
            Database database = new Database();
            string lekarz = "";
            using (SQLiteConnection c = new SQLiteConnection(database.myconn))
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




            string zapytanieWizyty = $"SELECT GodzinaWizyty, imie, nazwisko FROM Wizyty INNER JOIN Pacjent ON Pacjent.Pesel = Wizyty.IdPacjenta WHERE DataWizyty = '{data1}' AND IdLekarza = '{lekarz}'";
            SQLiteCommand zapytanieA = new SQLiteCommand(zapytanieWizyty, database.myconn);
            database.OpenConnection();
            SQLiteDataReader wynikW = zapytanieA.ExecuteReader();
            while(wynikW.Read())
            {
                string godzina = wynikW["GodzinaWizyty"].ToString();
                string imie = wynikW["imie"].ToString();
                string nazwisko = wynikW["nazwisko"].ToString();
                string concat = godzina + " - " + imie + " " + nazwisko;
                wizyty.Add(concat);
            }wynikW.Close();


            database.CloseConnection();

            if (allLabels.Count != 0)
            {
                for (int j = 0; j < allLabels.Count; j++)
                {
                    allLabels[j].Hide();
                }
                allLabels.Clear();
            }
            int iloscWizyt = wizyty.Count;
            int positionX = 130;
            int positionY = 250;
            //ta petla bedzie generowac kontrolki na zywo w zaleznosci od ilosci znalezionch wizyt z danego dnia.
            for (int i = 0; i < iloscWizyt; i++)
            {
                Label label = new Label();
                allLabels.Add(label);
                label.Name = "Lekarz_" + i;
                label.Size = new Size(200, 25);

                label.Text = wizyty[i];
                label.Location = new Point(positionX, positionY);
                Controls.Add(label);

                positionY += 50;
                if(positionY > 850)
                {
                    positionY = 250;
                    positionX += 100;
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
