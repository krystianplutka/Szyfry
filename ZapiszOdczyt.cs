using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSzyfryPlutka
{
    class ZapiszOdczyt
    {
        public string Odczyt()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            return fileContent;
        }

        public void Zapisz(string tekst)
        {

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {


                File.WriteAllText(dialog.FileName, tekst);






            }
        }
    }
}
