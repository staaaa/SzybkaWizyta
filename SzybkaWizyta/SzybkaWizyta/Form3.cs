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
    public partial class Form3 : Form
    {
        int test = 0;
        List<Label> allLabels = new List<Label>();
        public Form3()
        {
            InitializeComponent();
        }

        //EVENT PO WYBRANIU SPECJALIZACJI
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TU UTWORZYSZ JAKAS LISTE Z TYMI WSZYSTKIMI LEKARZAMI.
            //list lekarze
            List<string> lekarze = new List<string>();
            lekarze.Add("konrad wandtke");
            lekarze.Add("konrad debil");
            lekarze.Add("kewin patelczyk");
            lekarze.Add("kamil klawikowski");
            lekarze.Add("stanislaw bozych");

            //ta petla odpowiada za usuwanie starych labeli przy zmianie specjalizacji
            if (allLabels.Count != 0)
            {
                for (int j = 0; j < allLabels.Count; j++)
                {
                    allLabels[j].Hide();
                }
                allLabels.Clear();
            }
            int iloscLekarzyZWybranaSpecjalizacją = lekarze.Count;
            int positionX = 190;
            int positionY = 150;
            //ta petla bedzie generowac kontrolki na zywo w zaleznosci od ilosci znalezionch lekarzy z dana specjalizacja.
            for (int i = 0; i < iloscLekarzyZWybranaSpecjalizacją; i++)
            {
                Label label = new Label();
                allLabels.Add(label);
                label.Name = "Lekarz_" + i;
                label.Size = new Size(200, 25);

                label.Text = lekarze[i];
                label.Location = new Point(positionX,positionY);
                Controls.Add(label);
                label.Click += delegate 
                {
                    //wybierz z bazy lekarza o imieniu i nazwisku takim jak tresc labela
                    //przypisz jego dane do WybranyLekarz
                    //WybranyLekarz.id = cos tam i tak dalej wiadomo
                    string[] dane = label.Text.Split(' ');
                    WybranyLekarz.imie = dane[0];
                    WybranyLekarz.nazwisko = dane[1];
                    Form4 f4 = new Form4();
                    Hide();
                    f4.ShowDialog();
                };

                positionX += 243;
                if(positionX > 900)
                {
                    positionX = 190;
                    positionY += 50;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Database databaseObj = new Database();
            databaseObj.OpenConnection();
            string zapytanieSpec = "SELECT DISTINCT(Specjalizacja) AS spec FROM Lekarz";
            SQLiteCommand zapytanieA = new SQLiteCommand(zapytanieSpec, databaseObj.myconn);
            SQLiteDataReader wynikA = zapytanieA.ExecuteReader();
            if (wynikA.HasRows)
            {
                wynikA.Read();
                comboBox1.Items.Add(wynikA["spec"]);
            }
            wynikA.Dispose();

            databaseObj.CloseConnection();
        }
    }
}
