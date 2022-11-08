using System;
using System.Collections.Generic;
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
            //leci request do bazy i pobieramy wszystkie godziny z danego dnia i przypisujesz do arraya
            List<string> godzinyZajete = new List<string>();
            godzinyZajete.Add("11:30");
            godzinyZajete.Add("12:30");
            godzinyZajete.Add("13:30");
            godzinyZajete.Add("14:30");
            for(int i = 0; i < wszystkieGodziny.Count; i++)
            {
                if (!godzinyZajete.Contains(wszystkieGodziny[i]))
                {
                    godzinaPicker.Items.Add(wszystkieGodziny[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zbieramy dane odnosnie dnia i godziny i dodajemy do wizyt, mamy pacjenata z logowania w klasie
            //pacjent.cs, a lekarza z klasy wybranylekarz.cs wiec nie powinienes miec problemu.
            DateTime data = dataWizyty.Value;
            string godzina = godzinaPicker.SelectedItem.ToString();
            //tu puszczasz zapytanie
            MessageBox.Show("Zostałes zarejestrowany do:\r" 
                + WybranyLekarz.imie + " " 
                + WybranyLekarz.nazwisko + 
                "\rdnia " + data + 
                "\ro godzinie: "+godzina, "Udało się!");
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
