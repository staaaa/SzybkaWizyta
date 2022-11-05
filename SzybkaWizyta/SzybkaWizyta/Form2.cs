using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SzybkaWizyta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = null;
            string nazwisko = null;
            int pesel = 0;
            string nrtele = null;
            string email = null;
            string haslo = null;

            if (inputImie.Text != "")
            {
                imie = inputImie.Text;
            }
            if (inputNazwisko.Text != "")
            {
                nazwisko = inputNazwisko.Text;
            }
            if (inputPesel.Text != "")
            {
                pesel = int.Parse(inputPesel.Text);
            }
            if (inputNrtele.Text != "")
            {
                nrtele = inputNrtele.Text;
            }
            if (inputEmail.Text != "")
            {
                email = inputEmail.Text;
            }
            if (inputHaslo.Text != "")
            {
                haslo = inputHaslo.Text;
            }
            DateTime dataUrodzenia = inputDataUro.Value;

            //request czy user o podanym peselu juz przypadkiem nie istnieje, jesli nie rejestrujesz

            bool userCreated = false;
            if (userCreated)
            {
                //Przypisanie danych do pacjenta w klasie
                Pacjent.imie = imie;
                Pacjent.nazwisko = nazwisko;
                Pacjent.pesel = pesel;
                Pacjent.data_urodzenia = dataUrodzenia;
                Pacjent.email = email;
                Pacjent.nrtelefonu = nrtele;

                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                labelNotExist.Text = "Konto o podanych danych już istnieje w bazie danych.";
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
