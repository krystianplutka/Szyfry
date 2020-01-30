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
    public partial class Cezar : Form
    {
        public Cezar()
        {
            InitializeComponent();
        }
        private string tekst = "";
        private string szyfr = "";
        ZapiszOdczyt zapiszOdczyt = new ZapiszOdczyt();

        private int przesuniecie;
        SzyfrCezar szyfrCezar = new SzyfrCezar();

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cezar cezar = new Cezar();

            cezar.Show();
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrzesuniecie.Text))
            {
                MessageBox.Show("Wprowadź klucz!");
            }
            else
            {
                try
                {
                    

                    tekst = textBoxTekst.Text;
                    przesuniecie = Convert.ToInt16(textBoxPrzesuniecie.Text);
                    szyfr = szyfrCezar.SzyfrujCezar(tekst, przesuniecie);
                    textBoxTekstZaszyfrowany.Text = szyfr;
                }
                catch (System.FormatException s)
                {
                    MessageBox.Show("Podaj liczbę !");
                }
            }

        }



        private void Cezar_Load(object sender, EventArgs e)
        {

        }

        private void buttonZapiszZaszyfrowany_Click(object sender, EventArgs e)
        {
            zapiszOdczyt.Zapisz(textBoxTekstZaszyfrowany.Text);
        }

        private void buttonOdczyt_Click(object sender, EventArgs e)
        {
            textBoxTekst.Text = zapiszOdczyt.Odczyt();
        }
    }
}
