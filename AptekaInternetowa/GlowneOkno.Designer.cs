namespace AptekaInternetowa
{
    partial class GlowneOkno
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
            this.button_Zaloguj = new System.Windows.Forms.Button();
            this.button_Zarejestruj = new System.Windows.Forms.Button();
            this.label_AptekaInternetowa = new System.Windows.Forms.Label();
            this.label_Nazwa = new System.Windows.Forms.Label();
            this.label_haslo = new System.Windows.Forms.Label();
            this.textBox_Nazwa = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Haslo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_Zaloguj
            // 
            this.button_Zaloguj.Location = new System.Drawing.Point(65, 183);
            this.button_Zaloguj.Name = "button_Zaloguj";
            this.button_Zaloguj.Size = new System.Drawing.Size(75, 23);
            this.button_Zaloguj.TabIndex = 0;
            this.button_Zaloguj.Text = "Zaloguj";
            this.button_Zaloguj.UseVisualStyleBackColor = true;
            // 
            // button_Zarejestruj
            // 
            this.button_Zarejestruj.Location = new System.Drawing.Point(150, 183);
            this.button_Zarejestruj.Name = "button_Zarejestruj";
            this.button_Zarejestruj.Size = new System.Drawing.Size(75, 23);
            this.button_Zarejestruj.TabIndex = 1;
            this.button_Zarejestruj.Text = "Zarejestruj";
            this.button_Zarejestruj.UseVisualStyleBackColor = true;
            this.button_Zarejestruj.Click += new System.EventHandler(this.button_Zarejestruj_Click);
            // 
            // label_AptekaInternetowa
            // 
            this.label_AptekaInternetowa.AutoSize = true;
            this.label_AptekaInternetowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AptekaInternetowa.Location = new System.Drawing.Point(56, 46);
            this.label_AptekaInternetowa.Name = "label_AptekaInternetowa";
            this.label_AptekaInternetowa.Size = new System.Drawing.Size(196, 25);
            this.label_AptekaInternetowa.TabIndex = 2;
            this.label_AptekaInternetowa.Text = "Apteka Internetowa";
            // 
            // label_Nazwa
            // 
            this.label_Nazwa.AutoSize = true;
            this.label_Nazwa.Location = new System.Drawing.Point(58, 93);
            this.label_Nazwa.Name = "label_Nazwa";
            this.label_Nazwa.Size = new System.Drawing.Size(40, 13);
            this.label_Nazwa.TabIndex = 3;
            this.label_Nazwa.Text = "Nazwa";
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Location = new System.Drawing.Point(62, 140);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(36, 13);
            this.label_haslo.TabIndex = 4;
            this.label_haslo.Text = "Hasło";
            // 
            // textBox_Nazwa
            // 
            this.textBox_Nazwa.Location = new System.Drawing.Point(128, 93);
            this.textBox_Nazwa.Name = "textBox_Nazwa";
            this.textBox_Nazwa.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nazwa.TabIndex = 5;
            // 
            // maskedTextBox_Haslo
            // 
            this.maskedTextBox_Haslo.Location = new System.Drawing.Point(128, 137);
            this.maskedTextBox_Haslo.Name = "maskedTextBox_Haslo";
            this.maskedTextBox_Haslo.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Haslo.TabIndex = 6;
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.maskedTextBox_Haslo);
            this.Controls.Add(this.textBox_Nazwa);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_Nazwa);
            this.Controls.Add(this.label_AptekaInternetowa);
            this.Controls.Add(this.button_Zarejestruj);
            this.Controls.Add(this.button_Zaloguj);
            this.Name = "GlowneOkno";
            this.Text = "Apteka Internetowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Zaloguj;
        private System.Windows.Forms.Button button_Zarejestruj;
        private System.Windows.Forms.Label label_AptekaInternetowa;
        private System.Windows.Forms.Label label_Nazwa;
        private System.Windows.Forms.Label label_haslo;
        private System.Windows.Forms.TextBox textBox_Nazwa;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Haslo;
    }
}

