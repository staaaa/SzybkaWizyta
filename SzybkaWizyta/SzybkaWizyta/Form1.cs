using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            int pesel;
            string haslo;
            if(inputPesel.Text != "")
            {
                pesel = int.Parse(inputPesel.Text);
            }
            if(inputHaslo.Text != "")
            {
                haslo = inputHaslo.Text;
            }

            //sprawdzasz selectem czy taki uzytkownik istnieje, jesli cos sie zwroci to ustawiasz
            //userExists na true i elo
            //jesli nie to na false

            bool userExists = true;

            if (userExists)
            {
                labelNotExist.Text = "";
                //dane tego uzytkownika z bazy przypisujesz do klasy pacjent
                //przyklad
                Pacjent.imie = "es";
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
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
    }
}
