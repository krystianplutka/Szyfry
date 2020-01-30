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
    public partial class SHAMD5 : Form
    {
        public SHAMD5()
        {
            InitializeComponent();
        }
        private string wybor = "nic";
        private string haslo = "";
        private string szyfr = "";
        private string hasloponownie = "";
        private string szyfrponownie="";
        ClsCrypto clsCrypto = new ClsCrypto();
        ZapiszOdczyt zapiszOdczyt = new ZapiszOdczyt();

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void SHA_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonSHA1_CheckedChanged(object sender, EventArgs e)
        {
            wybor = "SHA1";
            buttonSzyfruj.Enabled = true;
            textBoxHasloZaszyfrowane.Text = "";
            
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            haslo = textBoxHaslo.Text;
            if (!String.Equals(haslo, ""))
            {
                switch (wybor)
                {
                    case "SHA1":
                        szyfr = clsCrypto.sha1encrypt(haslo);

                        break;
                    case "SHA256":
                        szyfr = clsCrypto.sha256encrypt(haslo);
                        break;
                    case "SHA384":
                        szyfr = clsCrypto.sha384encrypt(haslo);
                        break;
                    case "SHA512":
                        szyfr = clsCrypto.sha512encrypt(haslo);
                        break;
                    case "MD5":
                        szyfr = clsCrypto.md5encrypt(haslo);
                        break;

                }
                
                textBoxHasloZaszyfrowane.Text = szyfr;
                buttonPorownaj.Enabled = true;
            }
            else { MessageBox.Show("Wpisz hasło!"); }

           
        }

        private void radioButtonSHA256_CheckedChanged(object sender, EventArgs e)
        {
            wybor = "SHA256";
            buttonSzyfruj.Enabled = true;
            textBoxHasloZaszyfrowane.Text = "";
        }

        private void radioButtonSHA384_CheckedChanged(object sender, EventArgs e)
        {
            wybor = "SHA384";
            buttonSzyfruj.Enabled = true;
            textBoxHasloZaszyfrowane.Text = "";
        }

        private void radioButtonSHA512_CheckedChanged(object sender, EventArgs e)
        {
            wybor = "SHA512";
            buttonSzyfruj.Enabled = true;
            textBoxHasloZaszyfrowane.Text = "";
        }

        private void buttonPorownaj_Click(object sender, EventArgs e)
        {
            hasloponownie = textBoxHasloPonownie.Text;
            switch (wybor)
            {
                case "SHA1":
                    szyfrponownie = clsCrypto.sha1encrypt(hasloponownie);
                    break;
                case "SHA256":
                    szyfrponownie = clsCrypto.sha256encrypt(hasloponownie);
                    break;
                case "SHA384":
                    szyfrponownie = clsCrypto.sha384encrypt(hasloponownie);
                    break;
                case "SHA512":
                    szyfrponownie = clsCrypto.sha512encrypt(hasloponownie);
                    break;
                case "MD5":
                    szyfrponownie = clsCrypto.md5encrypt(hasloponownie);
                    break;
            }
                
            
            Boolean poprawnosc = string.Equals(szyfr, szyfrponownie);
            if(poprawnosc == true)
            {
                MessageBox.Show("Hasło poprawne");
            }
            else
            {
                MessageBox.Show("Hasło niepoprawne !");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            wybor = "MD5";
            buttonSzyfruj.Enabled = true;
            textBoxHasloZaszyfrowane.Text = "";
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            this.Hide();
            SHAMD5 sHAMD5 = new SHAMD5();

            sHAMD5.Show();
        }

        private void buttonZapiszZaszyfrowany_Click(object sender, EventArgs e)
        {
            zapiszOdczyt.Zapisz(textBoxHasloZaszyfrowane.Text);
        }

        private void buttonOdczyt_Click(object sender, EventArgs e)
        {
            textBoxHaslo.Text = zapiszOdczyt.Odczyt();
        }
    }
}
