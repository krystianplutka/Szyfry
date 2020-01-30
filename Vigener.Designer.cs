namespace ProjektSzyfryPlutka
{
    partial class Vigener
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
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.textBoxKluczSZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBoxKluczOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonWlasny = new System.Windows.Forms.RadioButton();
            this.radioButtonWygenerowany = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOdczyt = new System.Windows.Forms.Button();
            this.buttonOdczytOdszyfrowanie = new System.Windows.Forms.Button();
            this.buttonZapiszZaszyfrowany = new System.Windows.Forms.Button();
            this.buttonZapiszOdszyfrowany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(698, 396);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(100, 49);
            this.buttonPowrot.TabIndex = 0;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(187, 396);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(90, 49);
            this.buttonWyczysc.TabIndex = 22;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // textBoxKluczSZ
            // 
            this.textBoxKluczSZ.Location = new System.Drawing.Point(43, 95);
            this.textBoxKluczSZ.Name = "textBoxKluczSZ";
            this.textBoxKluczSZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxKluczSZ.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Klucz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(282, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "Odszyfrowywanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(300, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Szyfrowanie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tekst odszyfrowany";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tekst zaszyfrowany";
            // 
            // textBoxOdszyfrowany
            // 
            this.textBoxOdszyfrowany.Location = new System.Drawing.Point(541, 279);
            this.textBoxOdszyfrowany.Multiline = true;
            this.textBoxOdszyfrowany.Name = "textBoxOdszyfrowany";
            this.textBoxOdszyfrowany.Size = new System.Drawing.Size(165, 75);
            this.textBoxOdszyfrowany.TabIndex = 44;
            // 
            // textBoxZaszyfrowany
            // 
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(176, 279);
            this.textBoxZaszyfrowany.Multiline = true;
            this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(190, 75);
            this.textBoxZaszyfrowany.TabIndex = 43;
            // 
            // buttonOdszyfruj
            // 
            this.buttonOdszyfruj.Location = new System.Drawing.Point(411, 280);
            this.buttonOdszyfruj.Name = "buttonOdszyfruj";
            this.buttonOdszyfruj.Size = new System.Drawing.Size(100, 52);
            this.buttonOdszyfruj.TabIndex = 42;
            this.buttonOdszyfruj.Text = "Odszyfruj";
            this.buttonOdszyfruj.UseVisualStyleBackColor = true;
            this.buttonOdszyfruj.Click += new System.EventHandler(this.buttonOdszyfruj_Click);
            // 
            // textBoxTekstZaszyfrowany
            // 
            this.textBoxTekstZaszyfrowany.Location = new System.Drawing.Point(542, 95);
            this.textBoxTekstZaszyfrowany.Multiline = true;
            this.textBoxTekstZaszyfrowany.Name = "textBoxTekstZaszyfrowany";
            this.textBoxTekstZaszyfrowany.Size = new System.Drawing.Size(164, 79);
            this.textBoxTekstZaszyfrowany.TabIndex = 41;
            // 
            // textBoxTekst
            // 
            this.textBoxTekst.Location = new System.Drawing.Point(176, 95);
            this.textBoxTekst.Multiline = true;
            this.textBoxTekst.Name = "textBoxTekst";
            this.textBoxTekst.Size = new System.Drawing.Size(190, 79);
            this.textBoxTekst.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tekst zaszyfrowany";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tekst do zaszyfrowania bez spacji !";
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.Location = new System.Drawing.Point(411, 108);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(95, 48);
            this.buttonSzyfruj.TabIndex = 37;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = true;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // textBoxKluczOD
            // 
            this.textBoxKluczOD.Location = new System.Drawing.Point(26, 334);
            this.textBoxKluczOD.Name = "textBoxKluczOD";
            this.textBoxKluczOD.Size = new System.Drawing.Size(100, 20);
            this.textBoxKluczOD.TabIndex = 52;
            this.textBoxKluczOD.TextChanged += new System.EventHandler(this.textBoxKluczOD_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Klucz:";
            // 
            // radioButtonWlasny
            // 
            this.radioButtonWlasny.AutoSize = true;
            this.radioButtonWlasny.Location = new System.Drawing.Point(26, 293);
            this.radioButtonWlasny.Name = "radioButtonWlasny";
            this.radioButtonWlasny.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWlasny.TabIndex = 53;
            this.radioButtonWlasny.TabStop = true;
            this.radioButtonWlasny.Text = "Własny";
            this.radioButtonWlasny.UseVisualStyleBackColor = true;
            this.radioButtonWlasny.CheckedChanged += new System.EventHandler(this.radioButtonWlasny_CheckedChanged);
            // 
            // radioButtonWygenerowany
            // 
            this.radioButtonWygenerowany.AutoSize = true;
            this.radioButtonWygenerowany.Location = new System.Drawing.Point(26, 270);
            this.radioButtonWygenerowany.Name = "radioButtonWygenerowany";
            this.radioButtonWygenerowany.Size = new System.Drawing.Size(125, 17);
            this.radioButtonWygenerowany.TabIndex = 54;
            this.radioButtonWygenerowany.TabStop = true;
            this.radioButtonWygenerowany.Text = "Szyfr Wygenerowany";
            this.radioButtonWygenerowany.UseVisualStyleBackColor = true;
            this.radioButtonWygenerowany.CheckedChanged += new System.EventHandler(this.radioButtonWygenerowany_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOdczyt
            // 
            this.buttonOdczyt.Location = new System.Drawing.Point(47, 134);
            this.buttonOdczyt.Name = "buttonOdczyt";
            this.buttonOdczyt.Size = new System.Drawing.Size(104, 40);
            this.buttonOdczyt.TabIndex = 55;
            this.buttonOdczyt.Text = "Odczyt z pliku";
            this.buttonOdczyt.UseVisualStyleBackColor = true;
            this.buttonOdczyt.Click += new System.EventHandler(this.buttonOdczyt_Click);
            // 
            // buttonOdczytOdszyfrowanie
            // 
            this.buttonOdczytOdszyfrowanie.Location = new System.Drawing.Point(26, 367);
            this.buttonOdczytOdszyfrowanie.Name = "buttonOdczytOdszyfrowanie";
            this.buttonOdczytOdszyfrowanie.Size = new System.Drawing.Size(104, 40);
            this.buttonOdczytOdszyfrowanie.TabIndex = 56;
            this.buttonOdczytOdszyfrowanie.Text = "Odczyt z pliku";
            this.buttonOdczytOdszyfrowanie.UseVisualStyleBackColor = true;
            this.buttonOdczytOdszyfrowanie.Click += new System.EventHandler(this.buttonOdczytOdszyfrowanie_Click);
            // 
            // buttonZapiszZaszyfrowany
            // 
            this.buttonZapiszZaszyfrowany.Location = new System.Drawing.Point(713, 108);
            this.buttonZapiszZaszyfrowany.Name = "buttonZapiszZaszyfrowany";
            this.buttonZapiszZaszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszZaszyfrowany.TabIndex = 57;
            this.buttonZapiszZaszyfrowany.Text = "Zapisz szyfr";
            this.buttonZapiszZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszZaszyfrowany.Click += new System.EventHandler(this.buttonZapiszZaszyfrowany_Click);
            // 
            // buttonZapiszOdszyfrowany
            // 
            this.buttonZapiszOdszyfrowany.Location = new System.Drawing.Point(713, 300);
            this.buttonZapiszOdszyfrowany.Name = "buttonZapiszOdszyfrowany";
            this.buttonZapiszOdszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszOdszyfrowany.TabIndex = 58;
            this.buttonZapiszOdszyfrowany.Text = "Zapisz odszyfrowany tekst";
            this.buttonZapiszOdszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszOdszyfrowany.Click += new System.EventHandler(this.buttonZapiszOdszyfrowany_Click);
            // 
            // Vigener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.buttonZapiszOdszyfrowany);
            this.Controls.Add(this.buttonZapiszZaszyfrowany);
            this.Controls.Add(this.buttonOdczytOdszyfrowanie);
            this.Controls.Add(this.buttonOdczyt);
            this.Controls.Add(this.radioButtonWygenerowany);
            this.Controls.Add(this.radioButtonWlasny);
            this.Controls.Add(this.textBoxKluczOD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKluczSZ);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonPowrot);
            this.Name = "Vigener";
            this.Text = "Vigener";
            this.Load += new System.EventHandler(this.Vigener_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.TextBox textBoxKluczSZ;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox textBoxKluczOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonWlasny;
        private System.Windows.Forms.RadioButton radioButtonWygenerowany;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOdczyt;
        private System.Windows.Forms.Button buttonOdczytOdszyfrowanie;
        private System.Windows.Forms.Button buttonZapiszZaszyfrowany;
        private System.Windows.Forms.Button buttonZapiszOdszyfrowany;
    }
}