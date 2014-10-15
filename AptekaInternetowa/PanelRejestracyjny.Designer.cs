namespace AptekaInternetowa
{
    partial class PanelRejestracyjny
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
            this.label_Imie = new System.Windows.Forms.Label();
            this.label_Nazwisko = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Pesel = new System.Windows.Forms.Label();
            this.textBox_Pesel = new System.Windows.Forms.TextBox();
            this.textBox_Imie = new System.Windows.Forms.TextBox();
            this.textBox_Nazwisko = new System.Windows.Forms.TextBox();
            this.button_ZapiszDane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Imie
            // 
            this.label_Imie.AutoSize = true;
            this.label_Imie.Location = new System.Drawing.Point(43, 69);
            this.label_Imie.Name = "label_Imie";
            this.label_Imie.Size = new System.Drawing.Size(26, 13);
            this.label_Imie.TabIndex = 0;
            this.label_Imie.Text = "Imie";
            // 
            // label_Nazwisko
            // 
            this.label_Nazwisko.AutoSize = true;
            this.label_Nazwisko.Location = new System.Drawing.Point(43, 108);
            this.label_Nazwisko.Name = "label_Nazwisko";
            this.label_Nazwisko.Size = new System.Drawing.Size(53, 13);
            this.label_Nazwisko.TabIndex = 1;
            this.label_Nazwisko.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lekarz Prowadzacy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Schorzenia";
            // 
            // label_Pesel
            // 
            this.label_Pesel.AutoSize = true;
            this.label_Pesel.Location = new System.Drawing.Point(46, 31);
            this.label_Pesel.Name = "label_Pesel";
            this.label_Pesel.Size = new System.Drawing.Size(33, 13);
            this.label_Pesel.TabIndex = 4;
            this.label_Pesel.Text = "Pesel";
            // 
            // textBox_Pesel
            // 
            this.textBox_Pesel.Location = new System.Drawing.Point(137, 31);
            this.textBox_Pesel.Name = "textBox_Pesel";
            this.textBox_Pesel.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pesel.TabIndex = 5;
            // 
            // textBox_Imie
            // 
            this.textBox_Imie.Location = new System.Drawing.Point(137, 73);
            this.textBox_Imie.Name = "textBox_Imie";
            this.textBox_Imie.Size = new System.Drawing.Size(100, 20);
            this.textBox_Imie.TabIndex = 6;
            // 
            // textBox_Nazwisko
            // 
            this.textBox_Nazwisko.Location = new System.Drawing.Point(137, 112);
            this.textBox_Nazwisko.Name = "textBox_Nazwisko";
            this.textBox_Nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nazwisko.TabIndex = 7;
            // 
            // button_ZapiszDane
            // 
            this.button_ZapiszDane.Location = new System.Drawing.Point(121, 212);
            this.button_ZapiszDane.Name = "button_ZapiszDane";
            this.button_ZapiszDane.Size = new System.Drawing.Size(75, 23);
            this.button_ZapiszDane.TabIndex = 8;
            this.button_ZapiszDane.Text = "Zapisz Dane";
            this.button_ZapiszDane.UseVisualStyleBackColor = true;
            // 
            // PanelRejestracyjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_ZapiszDane);
            this.Controls.Add(this.textBox_Nazwisko);
            this.Controls.Add(this.textBox_Imie);
            this.Controls.Add(this.textBox_Pesel);
            this.Controls.Add(this.label_Pesel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Nazwisko);
            this.Controls.Add(this.label_Imie);
            this.Name = "PanelRejestracyjny";
            this.Text = "Panel Rejestracyjny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Imie;
        private System.Windows.Forms.Label label_Nazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Pesel;
        private System.Windows.Forms.TextBox textBox_Pesel;
        private System.Windows.Forms.TextBox textBox_Imie;
        private System.Windows.Forms.TextBox textBox_Nazwisko;
        private System.Windows.Forms.Button button_ZapiszDane;
    }
}