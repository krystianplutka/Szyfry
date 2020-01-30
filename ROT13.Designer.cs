namespace ProjektSzyfryPlutka
{
    partial class ROT13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonWygenerowany = new System.Windows.Forms.RadioButton();
            this.radioButtonWlasny = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOdszyfrowany = new System.Windows.Forms.TextBox();
            this.textBoxZaszyfrowany = new System.Windows.Forms.TextBox();
            this.buttonOdszyfruj = new System.Windows.Forms.Button();
            this.textBoxTekstZaszyfrowany = new System.Windows.Forms.TextBox();
            this.textBoxTekst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSzyfruj = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonZapiszOdszyfrowany = new System.Windows.Forms.Button();
            this.buttonZapiszZaszyfrowany = new System.Windows.Forms.Button();
            this.buttonOdczytOdszyfrowanie = new System.Windows.Forms.Button();
            this.buttonOdczyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonWygenerowany
            // 
            this.radioButtonWygenerowany.AutoSize = true;
            this.radioButtonWygenerowany.Location = new System.Drawing.Point(38, 285);
            this.radioButtonWygenerowany.Name = "radioButtonWygenerowany";
            this.radioButtonWygenerowany.Size = new System.Drawing.Size(125, 17);
            this.radioButtonWygenerowany.TabIndex = 72;
            this.radioButtonWygenerowany.TabStop = true;
            this.radioButtonWygenerowany.Text = "Szyfr Wygenerowany";
            this.radioButtonWygenerowany.UseVisualStyleBackColor = true;
            this.radioButtonWygenerowany.CheckedChanged += new System.EventHandler(this.radioButtonWygenerowany_CheckedChanged);
            // 
            // radioButtonWlasny
            // 
            this.radioButtonWlasny.AutoSize = true;
            this.radioButtonWlasny.Location = new System.Drawing.Point(38, 308);
            this.radioButtonWlasny.Name = "radioButtonWlasny";
            this.radioButtonWlasny.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWlasny.TabIndex = 71;
            this.radioButtonWlasny.TabStop = true;
            this.radioButtonWlasny.Text = "Własny";
            this.radioButtonWlasny.UseVisualStyleBackColor = true;
            this.radioButtonWlasny.CheckedChanged += new System.EventHandler(this.radioButtonWlasny_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(301, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 31);
            this.label7.TabIndex = 66;
            this.label7.Text = "Odszyfrowywanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(319, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 65;
            this.label4.Text = "Szyfrowanie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tekst odszyfrowany";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Tekst zaszyfrowany";
            // 
            // textBoxOdszyfrowany
            // 
            this.textBoxOdszyfrowany.Location = new System.Drawing.Point(560, 284);
            this.textBoxOdszyfrowany.Multiline = true;
            this.textBoxOdszyfrowany.Name = "textBoxOdszyfrowany";
            this.textBoxOdszyfrowany.Size = new System.Drawing.Size(165, 75);
            this.textBoxOdszyfrowany.TabIndex = 62;
            // 
            // textBoxZaszyfrowany
            // 
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(195, 284);
            this.textBoxZaszyfrowany.Multiline = true;
            this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(190, 75);
            this.textBoxZaszyfrowany.TabIndex = 61;
            // 
            // buttonOdszyfruj
            // 
            this.buttonOdszyfruj.Location = new System.Drawing.Point(430, 285);
            this.buttonOdszyfruj.Name = "buttonOdszyfruj";
            this.buttonOdszyfruj.Size = new System.Drawing.Size(100, 52);
            this.buttonOdszyfruj.TabIndex = 60;
            this.buttonOdszyfruj.Text = "Odszyfruj";
            this.buttonOdszyfruj.UseVisualStyleBackColor = true;
            this.buttonOdszyfruj.Click += new System.EventHandler(this.buttonOdszyfruj_Click);
            // 
            // textBoxTekstZaszyfrowany
            // 
            this.textBoxTekstZaszyfrowany.Location = new System.Drawing.Point(561, 100);
            this.textBoxTekstZaszyfrowany.Multiline = true;
            this.textBoxTekstZaszyfrowany.Name = "textBoxTekstZaszyfrowany";
            this.textBoxTekstZaszyfrowany.Size = new System.Drawing.Size(164, 79);
            this.textBoxTekstZaszyfrowany.TabIndex = 59;
            // 
            // textBoxTekst
            // 
            this.textBoxTekst.Location = new System.Drawing.Point(195, 100);
            this.textBoxTekst.Multiline = true;
            this.textBoxTekst.Name = "textBoxTekst";
            this.textBoxTekst.Size = new System.Drawing.Size(190, 79);
            this.textBoxTekst.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tekst zaszyfrowany";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tekst do zaszyfrowania:";
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.Location = new System.Drawing.Point(430, 113);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(95, 48);
            this.buttonSzyfruj.TabIndex = 55;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = true;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(38, 420);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(110, 62);
            this.buttonWyczysc.TabIndex = 74;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(703, 420);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(126, 62);
            this.buttonPowrot.TabIndex = 73;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonZapiszOdszyfrowany
            // 
            this.buttonZapiszOdszyfrowany.Location = new System.Drawing.Point(744, 308);
            this.buttonZapiszOdszyfrowany.Name = "buttonZapiszOdszyfrowany";
            this.buttonZapiszOdszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszOdszyfrowany.TabIndex = 78;
            this.buttonZapiszOdszyfrowany.Text = "Zapisz odszyfrowany tekst";
            this.buttonZapiszOdszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszOdszyfrowany.Click += new System.EventHandler(this.buttonZapiszOdszyfrowany_Click);
            // 
            // buttonZapiszZaszyfrowany
            // 
            this.buttonZapiszZaszyfrowany.Location = new System.Drawing.Point(744, 120);
            this.buttonZapiszZaszyfrowany.Name = "buttonZapiszZaszyfrowany";
            this.buttonZapiszZaszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszZaszyfrowany.TabIndex = 77;
            this.buttonZapiszZaszyfrowany.Text = "Zapisz szyfr";
            this.buttonZapiszZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszZaszyfrowany.Click += new System.EventHandler(this.buttonZapiszZaszyfrowany_Click);
            // 
            // buttonOdczytOdszyfrowanie
            // 
            this.buttonOdczytOdszyfrowanie.Location = new System.Drawing.Point(38, 331);
            this.buttonOdczytOdszyfrowanie.Name = "buttonOdczytOdszyfrowanie";
            this.buttonOdczytOdszyfrowanie.Size = new System.Drawing.Size(104, 40);
            this.buttonOdczytOdszyfrowanie.TabIndex = 76;
            this.buttonOdczytOdszyfrowanie.Text = "Odczyt z pliku";
            this.buttonOdczytOdszyfrowanie.UseVisualStyleBackColor = true;
            this.buttonOdczytOdszyfrowanie.Click += new System.EventHandler(this.buttonOdczytOdszyfrowanie_Click);
            // 
            // buttonOdczyt
            // 
            this.buttonOdczyt.Location = new System.Drawing.Point(60, 124);
            this.buttonOdczyt.Name = "buttonOdczyt";
            this.buttonOdczyt.Size = new System.Drawing.Size(104, 40);
            this.buttonOdczyt.TabIndex = 75;
            this.buttonOdczyt.Text = "Odczyt z pliku";
            this.buttonOdczyt.UseVisualStyleBackColor = true;
            this.buttonOdczyt.Click += new System.EventHandler(this.buttonOdczyt_Click);
            // 
            // ROT13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 494);
            this.Controls.Add(this.buttonZapiszOdszyfrowany);
            this.Controls.Add(this.buttonZapiszZaszyfrowany);
            this.Controls.Add(this.buttonOdczytOdszyfrowanie);
            this.Controls.Add(this.buttonOdczyt);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.radioButtonWygenerowany);
            this.Controls.Add(this.radioButtonWlasny);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOdszyfrowany);
            this.Controls.Add(this.textBoxZaszyfrowany);
            this.Controls.Add(this.buttonOdszyfruj);
            this.Controls.Add(this.textBoxTekstZaszyfrowany);
            this.Controls.Add(this.textBoxTekst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSzyfruj);
            this.Name = "ROT13";
            this.Text = "ROT13";
            this.Load += new System.EventHandler(this.ROT13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonWygenerowany;
        private System.Windows.Forms.RadioButton radioButtonWlasny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOdszyfrowany;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany;
        private System.Windows.Forms.Button buttonOdszyfruj;
        private System.Windows.Forms.TextBox textBoxTekstZaszyfrowany;
        private System.Windows.Forms.TextBox textBoxTekst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonZapiszOdszyfrowany;
        private System.Windows.Forms.Button buttonZapiszZaszyfrowany;
        private System.Windows.Forms.Button buttonOdczytOdszyfrowanie;
        private System.Windows.Forms.Button buttonOdczyt;
    }
}