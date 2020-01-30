namespace ProjektSzyfryPlutka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVigener = new System.Windows.Forms.Button();
            this.buttonCezar = new System.Windows.Forms.Button();
            this.buttonSHA = new System.Windows.Forms.Button();
            this.buttonKoniec = new System.Windows.Forms.Button();
            this.buttonAES = new System.Windows.Forms.Button();
            this.buttonROT13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVigener
            // 
            this.buttonVigener.Location = new System.Drawing.Point(254, 156);
            this.buttonVigener.Name = "buttonVigener";
            this.buttonVigener.Size = new System.Drawing.Size(144, 85);
            this.buttonVigener.TabIndex = 0;
            this.buttonVigener.Text = "Szyfr Vigenera";
            this.buttonVigener.UseVisualStyleBackColor = true;
            this.buttonVigener.Click += new System.EventHandler(this.buttonVigener_Click);
            // 
            // buttonCezar
            // 
            this.buttonCezar.Location = new System.Drawing.Point(46, 156);
            this.buttonCezar.Name = "buttonCezar";
            this.buttonCezar.Size = new System.Drawing.Size(154, 85);
            this.buttonCezar.TabIndex = 1;
            this.buttonCezar.Text = "Szyfr Cezara";
            this.buttonCezar.UseVisualStyleBackColor = true;
            this.buttonCezar.Click += new System.EventHandler(this.buttonCezar_Click);
            // 
            // buttonSHA
            // 
            this.buttonSHA.Location = new System.Drawing.Point(46, 41);
            this.buttonSHA.Name = "buttonSHA";
            this.buttonSHA.Size = new System.Drawing.Size(154, 73);
            this.buttonSHA.TabIndex = 3;
            this.buttonSHA.Text = "SHA i MD5";
            this.buttonSHA.UseVisualStyleBackColor = true;
            this.buttonSHA.Click += new System.EventHandler(this.buttonSHA_Click);
            // 
            // buttonKoniec
            // 
            this.buttonKoniec.Location = new System.Drawing.Point(475, 321);
            this.buttonKoniec.Name = "buttonKoniec";
            this.buttonKoniec.Size = new System.Drawing.Size(116, 56);
            this.buttonKoniec.TabIndex = 4;
            this.buttonKoniec.Text = "Zakończ";
            this.buttonKoniec.UseVisualStyleBackColor = true;
            this.buttonKoniec.Click += new System.EventHandler(this.buttonKoniec_Click);
            // 
            // buttonAES
            // 
            this.buttonAES.Location = new System.Drawing.Point(254, 41);
            this.buttonAES.Name = "buttonAES";
            this.buttonAES.Size = new System.Drawing.Size(144, 73);
            this.buttonAES.TabIndex = 5;
            this.buttonAES.Text = "AES";
            this.buttonAES.UseVisualStyleBackColor = true;
            this.buttonAES.Click += new System.EventHandler(this.buttonAES_Click);
            // 
            // buttonROT13
            // 
            this.buttonROT13.Location = new System.Drawing.Point(438, 41);
            this.buttonROT13.Name = "buttonROT13";
            this.buttonROT13.Size = new System.Drawing.Size(127, 73);
            this.buttonROT13.TabIndex = 6;
            this.buttonROT13.Text = "ROT13";
            this.buttonROT13.UseVisualStyleBackColor = true;
            this.buttonROT13.Click += new System.EventHandler(this.buttonROT13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 418);
            this.Controls.Add(this.buttonROT13);
            this.Controls.Add(this.buttonAES);
            this.Controls.Add(this.buttonKoniec);
            this.Controls.Add(this.buttonSHA);
            this.Controls.Add(this.buttonCezar);
            this.Controls.Add(this.buttonVigener);
            this.Name = "Form1";
            this.Text = "Szyfry by Krystian Plutka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVigener;
        private System.Windows.Forms.Button buttonCezar;
        private System.Windows.Forms.Button buttonSHA;
        private System.Windows.Forms.Button buttonKoniec;
        private System.Windows.Forms.Button buttonAES;
        private System.Windows.Forms.Button buttonROT13;
    }
}

