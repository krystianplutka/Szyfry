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
    public partial class ROT13 : Form
    {
        public ROT13()
        {
            InitializeComponent();
        }
        private string tekst = "";
        private string szyfr = "";
        SzyfrROT13 szyfrROT13 = new SzyfrROT13();
        ZapiszOdczyt zapiszOdczyt = new ZapiszOdczyt();

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ROT13 rOT13 = new ROT13();

            rOT13.Show();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void radioButtonWygenerowany_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Text = textBoxTekstZaszyfrowany.Text;
           
            textBoxOdszyfrowany.Text = "";
        }

        private void radioButtonWlasny_CheckedChanged(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Text = "";
            
            textBoxOdszyfrowany.Text = "";
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            tekst = textBoxTekst.Text;

            szyfr = szyfrROT13.ROT13(tekst);
            textBoxTekstZaszyfrowany.Text = szyfr;
        }

        private void buttonOdszyfruj_Click(object sender, EventArgs e)
        {
            szyfr = textBoxZaszyfrowany.Text;

            tekst = szyfrROT13.ROT13(szyfr);
            textBoxOdszyfrowany.Text = tekst;
        }

        private void ROT13_Load(object sender, EventArgs e)
        {

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
