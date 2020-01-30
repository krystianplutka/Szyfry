namespace ProjektSzyfryPlutka
{
    partial class AES
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
            this.buttonSzyfruj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTekst = new System.Windows.Forms.TextBox();
            this.textBoxTekstZaszyfrowany = new System.Windows.Forms.TextBox();
            this.radioButtonWygenerowany = new System.Windows.Forms.RadioButton();
            this.buttonOdszyfruj = new System.Windows.Forms.Button();
            this.textBoxZaszyfrowany = new System.Windows.Forms.TextBox();
            this.textBoxOdszyfrowany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonZapiszZaszyfrowany = new System.Windows.Forms.Button();
            this.buttonOdczyt = new System.Windows.Forms.Button();
            this.buttonZapiszOdszyfrowany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(683, 377);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(85, 51);
            this.buttonPowrot.TabIndex = 0;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.Location = new System.Drawing.Point(378, 105);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(95, 48);
            this.buttonSzyfruj.TabIndex = 1;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = true;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tekst do zaszyfrowania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tekst zaszyfrowany";
            // 
            // textBoxTekst
            // 
            this.textBoxTekst.Location = new System.Drawing.Point(143, 92);
            this.textBoxTekst.Multiline = true;
            this.textBoxTekst.Name = "textBoxTekst";
            this.textBoxTekst.Size = new System.Drawing.Size(190, 79);
            this.textBoxTekst.TabIndex = 6;
            // 
            // textBoxTekstZaszyfrowany
            // 
            this.textBoxTekstZaszyfrowany.Location = new System.Drawing.Point(509, 92);
            this.textBoxTekstZaszyfrowany.Multiline = true;
            this.textBoxTekstZaszyfrowany.Name = "textBoxTekstZaszyfrowany";
            this.textBoxTekstZaszyfrowany.Size = new System.Drawing.Size(164, 79);
            this.textBoxTekstZaszyfrowany.TabIndex = 7;
            // 
            // radioButtonWygenerowany
            // 
            this.radioButtonWygenerowany.AutoSize = true;
            this.radioButtonWygenerowany.Enabled = false;
            this.radioButtonWygenerowany.Location = new System.Drawing.Point(36, 308);
            this.radioButtonWygenerowany.Name = "radioButtonWygenerowany";
            this.radioButtonWygenerowany.Size = new System.Drawing.Size(122, 17);
            this.radioButtonWygenerowany.TabIndex = 9;
            this.radioButtonWygenerowany.TabStop = true;
            this.radioButtonWygenerowany.Text = "Szyfr wygenerowany";
            this.radioButtonWygenerowany.UseVisualStyleBackColor = true;
            this.radioButtonWygenerowany.CheckedChanged += new System.EventHandler(this.radioButtonWygenerowany_CheckedChanged);
            // 
            // buttonOdszyfruj
            // 
            this.buttonOdszyfruj.Enabled = false;
            this.buttonOdszyfruj.Location = new System.Drawing.Point(379, 290);
            this.buttonOdszyfruj.Name = "buttonOdszyfruj";
            this.buttonOdszyfruj.Size = new System.Drawing.Size(100, 52);
            this.buttonOdszyfruj.TabIndex = 12;
            this.buttonOdszyfruj.Text = "Odszyfruj";
            this.buttonOdszyfruj.UseVisualStyleBackColor = true;
            this.buttonOdszyfruj.Click += new System.EventHandler(this.buttonOdszyfruj_Click);
            // 
            // textBoxZaszyfrowany
            // 
            this.textBoxZaszyfrowany.Enabled = false;
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(186, 290);
            this.textBoxZaszyfrowany.Multiline = true;
            this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(153, 74);
            this.textBoxZaszyfrowany.TabIndex = 13;
            // 
            // textBoxOdszyfrowany
            // 
            this.textBoxOdszyfrowany.Enabled = false;
            this.textBoxOdszyfrowany.Location = new System.Drawing.Point(509, 289);
            this.textBoxOdszyfrowany.Multiline = true;
            this.textBoxOdszyfrowany.Name = "textBoxOdszyfrowany";
            this.textBoxOdszyfrowany.Size = new System.Drawing.Size(140, 74);
            this.textBoxOdszyfrowany.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tekst zaszyfrowany";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tekst odszyfrowany";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(328, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Szyfrowanie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(234, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Odszyfrowywanie";
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(19, 377);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(97, 51);
            this.buttonWyczysc.TabIndex = 20;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonZapiszZaszyfrowany
            // 
            this.buttonZapiszZaszyfrowany.Location = new System.Drawing.Point(693, 109);
            this.buttonZapiszZaszyfrowany.Name = "buttonZapiszZaszyfrowany";
            this.buttonZapiszZaszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszZaszyfrowany.TabIndex = 59;
            this.buttonZapiszZaszyfrowany.Text = "Zapisz szyfr";
            this.buttonZapiszZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszZaszyfrowany.Click += new System.EventHandler(this.buttonZapiszZaszyfrowany_Click);
            // 
            // buttonOdczyt
            // 
            this.buttonOdczyt.Location = new System.Drawing.Point(12, 109);
            this.buttonOdczyt.Name = "buttonOdczyt";
            this.buttonOdczyt.Size = new System.Drawing.Size(104, 40);
            this.buttonOdczyt.TabIndex = 58;
            this.buttonOdczyt.Text = "Odczyt z pliku";
            this.buttonOdczyt.UseVisualStyleBackColor = true;
            this.buttonOdczyt.Click += new System.EventHandler(this.buttonOdczyt_Click);
            // 
            // buttonZapiszOdszyfrowany
            // 
            this.buttonZapiszOdszyfrowany.Location = new System.Drawing.Point(683, 308);
            this.buttonZapiszOdszyfrowany.Name = "buttonZapiszOdszyfrowany";
            this.buttonZapiszOdszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszOdszyfrowany.TabIndex = 60;
            this.buttonZapiszOdszyfrowany.Text = "Zapisz odszyfrowany tekst";
            this.buttonZapiszOdszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszOdszyfrowany.Click += new System.EventHandler(this.buttonZapiszOdszyfrowany_Click);
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZapiszOdszyfrowany);
            this.Controls.Add(this.buttonZapiszZaszyfrowany);
            this.Controls.Add(this.buttonOdczyt);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOdszyfrowany);
            this.Controls.Add(this.textBoxZaszyfrowany);
            this.Controls.Add(this.buttonOdszyfruj);
            this.Controls.Add(this.radioButtonWygenerowany);
            this.Controls.Add(this.textBoxTekstZaszyfrowany);
            this.Controls.Add(this.textBoxTekst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSzyfruj);
            this.Controls.Add(this.buttonPowrot);
            this.Name = "AES";
            this.Text = "AES";
            this.Load += new System.EventHandler(this.AES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTekst;
        private System.Windows.Forms.TextBox textBoxTekstZaszyfrowany;
        private System.Windows.Forms.RadioButton radioButtonWygenerowany;
        private System.Windows.Forms.Button buttonOdszyfruj;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany;
        private System.Windows.Forms.TextBox textBoxOdszyfrowany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonZapiszZaszyfrowany;
        private System.Windows.Forms.Button buttonOdczyt;
        private System.Windows.Forms.Button buttonZapiszOdszyfrowany;
    }
}