namespace ProjektSzyfryPlutka
{
    partial class SHAMD5
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
            this.radioButtonSHA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA256 = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA384 = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA512 = new System.Windows.Forms.RadioButton();
            this.buttonSzyfruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHasloZaszyfrowane = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHasloPonownie = new System.Windows.Forms.TextBox();
            this.buttonPorownaj = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonZapiszZaszyfrowany = new System.Windows.Forms.Button();
            this.buttonOdczyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(638, 376);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(130, 51);
            this.buttonPowrot.TabIndex = 0;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // radioButtonSHA1
            // 
            this.radioButtonSHA1.AutoSize = true;
            this.radioButtonSHA1.Location = new System.Drawing.Point(75, 39);
            this.radioButtonSHA1.Name = "radioButtonSHA1";
            this.radioButtonSHA1.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSHA1.TabIndex = 1;
            this.radioButtonSHA1.TabStop = true;
            this.radioButtonSHA1.Text = "SHA1";
            this.radioButtonSHA1.UseVisualStyleBackColor = true;
            this.radioButtonSHA1.CheckedChanged += new System.EventHandler(this.radioButtonSHA1_CheckedChanged);
            // 
            // radioButtonSHA256
            // 
            this.radioButtonSHA256.AutoSize = true;
            this.radioButtonSHA256.Location = new System.Drawing.Point(75, 63);
            this.radioButtonSHA256.Name = "radioButtonSHA256";
            this.radioButtonSHA256.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSHA256.TabIndex = 2;
            this.radioButtonSHA256.TabStop = true;
            this.radioButtonSHA256.Text = "SHA256";
            this.radioButtonSHA256.UseVisualStyleBackColor = true;
            this.radioButtonSHA256.CheckedChanged += new System.EventHandler(this.radioButtonSHA256_CheckedChanged);
            // 
            // radioButtonSHA384
            // 
            this.radioButtonSHA384.AutoSize = true;
            this.radioButtonSHA384.Location = new System.Drawing.Point(75, 86);
            this.radioButtonSHA384.Name = "radioButtonSHA384";
            this.radioButtonSHA384.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSHA384.TabIndex = 3;
            this.radioButtonSHA384.TabStop = true;
            this.radioButtonSHA384.Text = "SHA384";
            this.radioButtonSHA384.UseVisualStyleBackColor = true;
            this.radioButtonSHA384.CheckedChanged += new System.EventHandler(this.radioButtonSHA384_CheckedChanged);
            // 
            // radioButtonSHA512
            // 
            this.radioButtonSHA512.AutoSize = true;
            this.radioButtonSHA512.Location = new System.Drawing.Point(75, 110);
            this.radioButtonSHA512.Name = "radioButtonSHA512";
            this.radioButtonSHA512.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSHA512.TabIndex = 4;
            this.radioButtonSHA512.TabStop = true;
            this.radioButtonSHA512.Text = "SHA512";
            this.radioButtonSHA512.UseVisualStyleBackColor = true;
            this.radioButtonSHA512.CheckedChanged += new System.EventHandler(this.radioButtonSHA512_CheckedChanged);
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.Enabled = false;
            this.buttonSzyfruj.Location = new System.Drawing.Point(400, 80);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(90, 47);
            this.buttonSzyfruj.TabIndex = 5;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = true;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wpisz hasło";
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Location = new System.Drawing.Point(183, 63);
            this.textBoxHaslo.Multiline = true;
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(164, 64);
            this.textBoxHaslo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasło zaszyfrowane";
            // 
            // textBoxHasloZaszyfrowane
            // 
            this.textBoxHasloZaszyfrowane.Location = new System.Drawing.Point(542, 63);
            this.textBoxHasloZaszyfrowane.Multiline = true;
            this.textBoxHasloZaszyfrowane.Name = "textBoxHasloZaszyfrowane";
            this.textBoxHasloZaszyfrowane.Size = new System.Drawing.Size(171, 64);
            this.textBoxHasloZaszyfrowane.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wpisz hasło ponownie, aby porównać szyfry";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxHasloPonownie
            // 
            this.textBoxHasloPonownie.Location = new System.Drawing.Point(60, 232);
            this.textBoxHasloPonownie.Multiline = true;
            this.textBoxHasloPonownie.Name = "textBoxHasloPonownie";
            this.textBoxHasloPonownie.Size = new System.Drawing.Size(150, 70);
            this.textBoxHasloPonownie.TabIndex = 12;
            // 
            // buttonPorownaj
            // 
            this.buttonPorownaj.Enabled = false;
            this.buttonPorownaj.Location = new System.Drawing.Point(235, 245);
            this.buttonPorownaj.Name = "buttonPorownaj";
            this.buttonPorownaj.Size = new System.Drawing.Size(121, 43);
            this.buttonPorownaj.TabIndex = 13;
            this.buttonPorownaj.Text = "Porównaj zaszyfrowane hasła";
            this.buttonPorownaj.UseVisualStyleBackColor = true;
            this.buttonPorownaj.Click += new System.EventHandler(this.buttonPorownaj_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(75, 133);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MD5";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(39, 376);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(116, 51);
            this.buttonWyczysc.TabIndex = 21;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonZapiszZaszyfrowany
            // 
            this.buttonZapiszZaszyfrowany.Location = new System.Drawing.Point(628, 133);
            this.buttonZapiszZaszyfrowany.Name = "buttonZapiszZaszyfrowany";
            this.buttonZapiszZaszyfrowany.Size = new System.Drawing.Size(85, 48);
            this.buttonZapiszZaszyfrowany.TabIndex = 59;
            this.buttonZapiszZaszyfrowany.Text = "Zapisz szyfr";
            this.buttonZapiszZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonZapiszZaszyfrowany.Click += new System.EventHandler(this.buttonZapiszZaszyfrowany_Click);
            // 
            // buttonOdczyt
            // 
            this.buttonOdczyt.Location = new System.Drawing.Point(211, 133);
            this.buttonOdczyt.Name = "buttonOdczyt";
            this.buttonOdczyt.Size = new System.Drawing.Size(104, 40);
            this.buttonOdczyt.TabIndex = 58;
            this.buttonOdczyt.Text = "Odczyt z pliku";
            this.buttonOdczyt.UseVisualStyleBackColor = true;
            this.buttonOdczyt.Click += new System.EventHandler(this.buttonOdczyt_Click);
            // 
            // SHAMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZapiszZaszyfrowany);
            this.Controls.Add(this.buttonOdczyt);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonPorownaj);
            this.Controls.Add(this.textBoxHasloPonownie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHasloZaszyfrowane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSzyfruj);
            this.Controls.Add(this.radioButtonSHA512);
            this.Controls.Add(this.radioButtonSHA384);
            this.Controls.Add(this.radioButtonSHA256);
            this.Controls.Add(this.radioButtonSHA1);
            this.Controls.Add(this.buttonPowrot);
            this.Name = "SHAMD5";
            this.Text = "SHA i MD5";
            this.Load += new System.EventHandler(this.SHA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.RadioButton radioButtonSHA1;
        private System.Windows.Forms.RadioButton radioButtonSHA256;
        private System.Windows.Forms.RadioButton radioButtonSHA384;
        private System.Windows.Forms.RadioButton radioButtonSHA512;
        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHasloZaszyfrowane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHasloPonownie;
        private System.Windows.Forms.Button buttonPorownaj;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonZapiszZaszyfrowany;
        private System.Windows.Forms.Button buttonOdczyt;
    }
}