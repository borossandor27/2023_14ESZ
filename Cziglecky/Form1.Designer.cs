
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ForrasFajlNeve = new System.Windows.Forms.TextBox();
            this.button_ForrasFajlBetoltese = new System.Windows.Forms.Button();
            this.listBox_orszagok = new System.Windows.Forms.ListBox();
            this.button_teruletek_atlaga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_nagyobbMint100ezer = new System.Windows.Forms.RadioButton();
            this.radioButton_KisebbMint100Ezer = new System.Windows.Forms.RadioButton();
            this.button_Megszamolas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_EredmenyFajlNeve = new System.Windows.Forms.TextBox();
            this.button_EredmenyKiirasa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_MinumuVagyMaximum = new System.Windows.Forms.ComboBox();
            this.button_MinimumVagyMaximumKivalasztasa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_OrszakKereso = new System.Windows.Forms.TextBox();
            this.checkBox_TalalatokKijelolese = new System.Windows.Forms.CheckBox();
            this.button_kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forrásfájl neve:";
            // 
            // textBox_ForrasFajlNeve
            // 
            this.textBox_ForrasFajlNeve.Location = new System.Drawing.Point(16, 30);
            this.textBox_ForrasFajlNeve.Name = "textBox_ForrasFajlNeve";
            this.textBox_ForrasFajlNeve.Size = new System.Drawing.Size(100, 20);
            this.textBox_ForrasFajlNeve.TabIndex = 1;
            // 
            // button_ForrasFajlBetoltese
            // 
            this.button_ForrasFajlBetoltese.Location = new System.Drawing.Point(16, 57);
            this.button_ForrasFajlBetoltese.Name = "button_ForrasFajlBetoltese";
            this.button_ForrasFajlBetoltese.Size = new System.Drawing.Size(100, 26);
            this.button_ForrasFajlBetoltese.TabIndex = 2;
            this.button_ForrasFajlBetoltese.Text = "Betöltés";
            this.button_ForrasFajlBetoltese.UseVisualStyleBackColor = true;
            this.button_ForrasFajlBetoltese.Click += new System.EventHandler(this.button_ForrasFajlBetoltese_Click);
            // 
            // listBox_orszagok
            // 
            this.listBox_orszagok.FormattingEnabled = true;
            this.listBox_orszagok.Location = new System.Drawing.Point(17, 90);
            this.listBox_orszagok.Name = "listBox_orszagok";
            this.listBox_orszagok.Size = new System.Drawing.Size(100, 264);
            this.listBox_orszagok.TabIndex = 3;
            // 
            // button_teruletek_atlaga
            // 
            this.button_teruletek_atlaga.Location = new System.Drawing.Point(16, 371);
            this.button_teruletek_atlaga.Name = "button_teruletek_atlaga";
            this.button_teruletek_atlaga.Size = new System.Drawing.Size(100, 22);
            this.button_teruletek_atlaga.TabIndex = 4;
            this.button_teruletek_atlaga.Text = "Területek átlaga";
            this.button_teruletek_atlaga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_KisebbMint100Ezer);
            this.groupBox1.Controls.Add(this.radioButton_nagyobbMint100ezer);
            this.groupBox1.Location = new System.Drawing.Point(122, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // radioButton_nagyobbMint100ezer
            // 
            this.radioButton_nagyobbMint100ezer.AutoSize = true;
            this.radioButton_nagyobbMint100ezer.Location = new System.Drawing.Point(16, 35);
            this.radioButton_nagyobbMint100ezer.Name = "radioButton_nagyobbMint100ezer";
            this.radioButton_nagyobbMint100ezer.Size = new System.Drawing.Size(163, 17);
            this.radioButton_nagyobbMint100ezer.TabIndex = 0;
            this.radioButton_nagyobbMint100ezer.TabStop = true;
            this.radioButton_nagyobbMint100ezer.Text = "100.000-nél nagyobb területű";
            this.radioButton_nagyobbMint100ezer.UseVisualStyleBackColor = true;
            // 
            // radioButton_KisebbMint100Ezer
            // 
            this.radioButton_KisebbMint100Ezer.AutoSize = true;
            this.radioButton_KisebbMint100Ezer.Location = new System.Drawing.Point(16, 58);
            this.radioButton_KisebbMint100Ezer.Name = "radioButton_KisebbMint100Ezer";
            this.radioButton_KisebbMint100Ezer.Size = new System.Drawing.Size(147, 17);
            this.radioButton_KisebbMint100Ezer.TabIndex = 1;
            this.radioButton_KisebbMint100Ezer.TabStop = true;
            this.radioButton_KisebbMint100Ezer.Text = "legfeljebb 100.000területű";
            this.radioButton_KisebbMint100Ezer.UseVisualStyleBackColor = true;
            // 
            // button_Megszamolas
            // 
            this.button_Megszamolas.Location = new System.Drawing.Point(123, 106);
            this.button_Megszamolas.Name = "button_Megszamolas";
            this.button_Megszamolas.Size = new System.Drawing.Size(266, 30);
            this.button_Megszamolas.TabIndex = 6;
            this.button_Megszamolas.Text = "Megszámolás";
            this.button_Megszamolas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eredmény fájl neve:";
            // 
            // textBox_EredmenyFajlNeve
            // 
            this.textBox_EredmenyFajlNeve.Location = new System.Drawing.Point(126, 160);
            this.textBox_EredmenyFajlNeve.Name = "textBox_EredmenyFajlNeve";
            this.textBox_EredmenyFajlNeve.Size = new System.Drawing.Size(263, 20);
            this.textBox_EredmenyFajlNeve.TabIndex = 8;
            // 
            // button_EredmenyKiirasa
            // 
            this.button_EredmenyKiirasa.Location = new System.Drawing.Point(126, 187);
            this.button_EredmenyKiirasa.Name = "button_EredmenyKiirasa";
            this.button_EredmenyKiirasa.Size = new System.Drawing.Size(263, 29);
            this.button_EredmenyKiirasa.TabIndex = 9;
            this.button_EredmenyKiirasa.Text = "Kiírás";
            this.button_EredmenyKiirasa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Minimum vagy maximum";
            // 
            // comboBox_MinumuVagyMaximum
            // 
            this.comboBox_MinumuVagyMaximum.FormattingEnabled = true;
            this.comboBox_MinumuVagyMaximum.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox_MinumuVagyMaximum.Location = new System.Drawing.Point(126, 240);
            this.comboBox_MinumuVagyMaximum.Name = "comboBox_MinumuVagyMaximum";
            this.comboBox_MinumuVagyMaximum.Size = new System.Drawing.Size(263, 21);
            this.comboBox_MinumuVagyMaximum.TabIndex = 11;
            // 
            // button_MinimumVagyMaximumKivalasztasa
            // 
            this.button_MinimumVagyMaximumKivalasztasa.Location = new System.Drawing.Point(126, 265);
            this.button_MinimumVagyMaximumKivalasztasa.Name = "button_MinimumVagyMaximumKivalasztasa";
            this.button_MinimumVagyMaximumKivalasztasa.Size = new System.Drawing.Size(263, 24);
            this.button_MinimumVagyMaximumKivalasztasa.TabIndex = 12;
            this.button_MinimumVagyMaximumKivalasztasa.Text = "Minimum / Maximum kiválasztása";
            this.button_MinimumVagyMaximumKivalasztasa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ország keresése";
            // 
            // textBox_OrszakKereso
            // 
            this.textBox_OrszakKereso.Location = new System.Drawing.Point(132, 324);
            this.textBox_OrszakKereso.Name = "textBox_OrszakKereso";
            this.textBox_OrszakKereso.Size = new System.Drawing.Size(257, 20);
            this.textBox_OrszakKereso.TabIndex = 14;
            // 
            // checkBox_TalalatokKijelolese
            // 
            this.checkBox_TalalatokKijelolese.AutoSize = true;
            this.checkBox_TalalatokKijelolese.Location = new System.Drawing.Point(132, 351);
            this.checkBox_TalalatokKijelolese.Name = "checkBox_TalalatokKijelolese";
            this.checkBox_TalalatokKijelolese.Size = new System.Drawing.Size(164, 17);
            this.checkBox_TalalatokKijelolese.TabIndex = 15;
            this.checkBox_TalalatokKijelolese.Text = "Találatok kijelölése a listában";
            this.checkBox_TalalatokKijelolese.UseVisualStyleBackColor = true;
            // 
            // button_kereses
            // 
            this.button_kereses.Location = new System.Drawing.Point(132, 369);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(257, 23);
            this.button_kereses.TabIndex = 16;
            this.button_kereses.Text = "Keresés";
            this.button_kereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 409);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.checkBox_TalalatokKijelolese);
            this.Controls.Add(this.textBox_OrszakKereso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_MinimumVagyMaximumKivalasztasa);
            this.Controls.Add(this.comboBox_MinumuVagyMaximum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_EredmenyKiirasa);
            this.Controls.Add(this.textBox_EredmenyFajlNeve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Megszamolas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_teruletek_atlaga);
            this.Controls.Add(this.listBox_orszagok);
            this.Controls.Add(this.button_ForrasFajlBetoltese);
            this.Controls.Add(this.textBox_ForrasFajlNeve);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Példa Windows Forms alkalmazás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ForrasFajlNeve;
        private System.Windows.Forms.Button button_ForrasFajlBetoltese;
        private System.Windows.Forms.ListBox listBox_orszagok;
        private System.Windows.Forms.Button button_teruletek_atlaga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_KisebbMint100Ezer;
        private System.Windows.Forms.RadioButton radioButton_nagyobbMint100ezer;
        private System.Windows.Forms.Button button_Megszamolas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_EredmenyFajlNeve;
        private System.Windows.Forms.Button button_EredmenyKiirasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_MinumuVagyMaximum;
        private System.Windows.Forms.Button button_MinimumVagyMaximumKivalasztasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_OrszakKereso;
        private System.Windows.Forms.CheckBox checkBox_TalalatokKijelolese;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

