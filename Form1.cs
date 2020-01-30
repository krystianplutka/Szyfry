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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SzyfrROT13 szyfrROT = new SzyfrROT13();
            string szyfr = szyfrROT.ROT13("siema");
            Console.WriteLine(szyfr);
            string odszyfr = szyfrROT.ROT13(szyfr);
            Console.WriteLine(odszyfr);

        }

        private void buttonCezar_Click(object sender, EventArgs e)
        {
            Cezar cezar = new Cezar();
            cezar.Show();
            this.Hide();
        }

        private void buttonVigener_Click(object sender, EventArgs e)
        {
            Vigener vigener = new Vigener();
            vigener.Show();
            this.Hide();
        }

        

        private void buttonSHA_Click(object sender, EventArgs e)
        {
            SHAMD5 sha = new SHAMD5();
            sha.Show();
            this.Hide();
        }

        private void buttonAES_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            aes.Show();
            this.Hide();
      
        }

        private void buttonROT13_Click(object sender, EventArgs e)
        {
            ROT13 rOT13 = new ROT13();
            rOT13.Show();
            this.Hide();
        }
    }
}
