using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSzyfryPlutka
{
    public partial class Vigener : Form
    {
        public Vigener()
        {
            InitializeComponent();
        }

        private string tekst = "";
        private string szyfr = "";

        private string klucz;
        SzyfrVigenere szyfrVigenere = new SzyfrVigenere();
        ZapiszOdczyt zapiszOdczyt = new ZapiszOdczyt();

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vigener vigener = new Vigener();

            vigener.Show();
        }



        private void buttonOdszyfruj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKluczOD.Text))
            {
                MessageBox.Show("Wprowadź klucz!");
            }
            else
            {
                szyfr = textBoxZaszyfrowany.Text;
                klucz = textBoxKluczOD.Text;
                tekst = szyfrVigenere.decryptByteVigenere(szyfr, klucz);
                textBoxOdszyfrowany.Text = tekst;
            }

        }



        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKluczSZ.Text))
            {
                MessageBox.Show("Wprowadź klucz!");
            }
            else
            {
                tekst = textBoxTekst.Text;
                klucz = textBoxKluczSZ.Text;
                szyfr = szyfrVigenere.encryptByteVigenere(tekst, klucz);
                textBoxTekstZaszyfrowany.Text = szyfr;
            }
        }

        private void textBoxKluczOD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vigener_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonWygenerowany_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Text = textBoxTekstZaszyfrowany.Text;
            textBoxKluczOD.Text = textBoxKluczSZ.Text;
            textBoxOdszyfrowany.Text = "";
        }

        private void radioButtonWlasny_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Text = "";
            textBoxKluczOD.Text = "";
            textBoxOdszyfrowany.Text = "";
        }

        private void buttonOdczyt_Click(object sender, EventArgs e)
        {
            textBoxTekst.Text = zapiszOdczyt.Odczyt();
        }

        private void buttonOdczytOdszyfrowanie_Click(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Text = zapiszOdczyt.Odczyt();
        }

        private void buttonZapiszOdszyfrowany_Click(object sender, EventArgs e)
        {
            zapiszOdczyt.Zapisz(textBoxOdszyfrowany.Text);
        }

        private void buttonZapiszZaszyfrowany_Click(object sender, EventArgs e)
        {
            zapiszOdczyt.Zapisz(textBoxTekstZaszyfrowany.Text);
        }
    }
}
