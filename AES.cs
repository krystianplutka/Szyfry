using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ProjektSzyfryPlutka
{
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();
        }

        private string tekst = "";
        private string szyfr = "";

        private byte[] szyfrBytes;
        private string odszyfrowany = "";
        SzyfrAES szyfrAES = new SzyfrAES();
        ZapiszOdczyt zapiszOdczyt = new ZapiszOdczyt();






        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }



        private void AES_Load(object sender, EventArgs e)
        {

        }




        private void radioButtonWygenerowany_CheckedChanged(object sender, EventArgs e)
        {

            textBoxZaszyfrowany.Text = szyfr;
        }

       

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            radioButtonWygenerowany.Enabled = true;
            buttonOdszyfruj.Enabled = true;
            /* try {

                 klucz = Encoding.UTF8.GetBytes(textBoxKlucz.Text);
             }
             catch (FormatException s) {
                 MessageBox.Show("Podaj liczbę z zakresu od 0 do 255");
             }
             */
            tekst = textBoxTekst.Text;
            using (Aes myAes = Aes.Create())
            {
                szyfrBytes = szyfrAES.EncryptStringToBytes_Aes(tekst, myAes.Key, myAes.IV);
                szyfr = System.Text.Encoding.UTF8.GetString(szyfrBytes);
                textBoxTekstZaszyfrowany.Text = szyfr;

                odszyfrowany = szyfrAES.DecryptStringFromBytes_Aes(szyfrBytes, myAes.Key, myAes.IV);

            }



        }

        private void buttonOdszyfruj_Click(object sender, EventArgs e)
        {
            if (radioButtonWygenerowany.Checked)
            {
                textBoxOdszyfrowany.Enabled = true;
                textBoxOdszyfrowany.Text = odszyfrowany;
            }


        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {

            this.Hide();
            AES aes = new AES();

            aes.Show();
        }

       

        

        private void buttonOdczyt_Click(object sender, EventArgs e)
        {
            textBoxTekst.Text = zapiszOdczyt.Odczyt();
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
