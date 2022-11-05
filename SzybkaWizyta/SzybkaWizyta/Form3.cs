using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SzybkaWizyta
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //W TYM MIEJSCU MUSISZ ZAŁADOWAĆ LISTE WSZYSTKICH SPECJALIZACJI LEKARSKICH W BAZIE DO COMBOBOXA
            //SELECT DISTINCT SPECJALIZACJA
            //I TA CALA LISTE WPIERDALASZ W TAKI SPOSÓB
            //comboBox1.Items.Add();
        }

        //EVENT PO WYBRANIU SPECJALIZACJI
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iloscLekarzyZWybranaSpecjalizacją = 9;
            //TU UTWORZYSZ JAKAS LISTE Z TYMI WSZYSTKIMI LEKARZAMI.
            //list lekarze

            //ta petla bedzie generowac kontrolki na zywo w zaleznosci od ilosci znalezionch lekarzy z dana specjalizacja.
            int positionX = 190;
            int positionY = 150;
            for(int i = 0; i < iloscLekarzyZWybranaSpecjalizacją; i++)
            {
                Label label = new Label();
                label.Name = "Lekarz_" + i;
                label.Size = new Size(200, 25);

                //W TYM MIEJSCU DO TEXTU LABELA PRZYPISUJESZ IMIE I NAZWISKO DOKTORKA
                label.Text = "JANUSZ KOWALSKI";
                label.Location = new Point(positionX,positionY);
                Controls.Add(label);

                RadioButton radio = new RadioButton();

                positionX += 243;
                if(positionX > 900)
                {
                    positionX = 190;
                    positionY += 50;
                }
            }
        }
    }
}
