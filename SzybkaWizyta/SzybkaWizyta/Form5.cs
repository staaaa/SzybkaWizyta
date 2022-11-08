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
            //wizyty.Add("10:00 - konrad wandtke");
            //wizyty.Add("11:00 - kewin patelczyk");
            //wizyty.Add("11:30 - laura szpicruta");
            //wizyty.Add("12:00 - maciej boryna"); - Maciej Boryna i szpicruta w łeb
            Database database = new Database();
            string zapytanieWizyty = "SELECT GodzinaWizyty, imie, nazwisko FROM Wizyty INNER JOIN Pacjent ON Pacjent.Id = Wizyty.IdWizyty";
            SQLiteCommand zapytanieA = new SQLiteCommand(zapytanieWizyty, database.myconn);
            database.OpenConnection();
            SQLiteDataReader wynikW = zapytanieA.ExecuteReader();
            if(wynikW.HasRows)
            {
                wynikW.Read();
                string godzina = wynikW["GodzinaWizyty"].ToString();
                string imie = wynikW["imie"].ToString();
                string nazwisko = wynikW["nazwisko"].ToString();
                string concat = godzina + " - " + imie + " " + nazwisko;
                wizyty.Add(concat);
            }wynikW.Close();


            database.CloseConnection();

            //ta petla odpowiada za usuwanie starych labeli przy zmianie specjalizacji
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
