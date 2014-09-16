namespace WindowsBrowserApp
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
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.BackBut = new System.Windows.Forms.Button();
            this.NextBut = new System.Windows.Forms.Button();
            this.NavBut = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FromCurComBox = new System.Windows.Forms.ComboBox();
            this.ToCurComBox = new System.Windows.Forms.ComboBox();
            this.CurRateBut = new System.Windows.Forms.Button();
            this.CurrencyRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StockSymbInp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StoQuoBut = new System.Windows.Forms.Button();
            this.StoQuoRes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EncryInp = new System.Windows.Forms.TextBox();
            this.EncryptOut = new System.Windows.Forms.TextBox();
            this.EncrypBut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DecryInp = new System.Windows.Forms.TextBox();
            this.DecryptOut = new System.Windows.Forms.TextBox();
            this.DecrypBut = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(122, 19);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(868, 20);
            this.AddressBox.TabIndex = 0;
            // 
            // BackBut
            // 
            this.BackBut.Location = new System.Drawing.Point(12, 19);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(49, 23);
            this.BackBut.TabIndex = 1;
            this.BackBut.Text = "Back";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // NextBut
            // 
            this.NextBut.Location = new System.Drawing.Point(67, 19);
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(49, 23);
            this.NextBut.TabIndex = 2;
            this.NextBut.Text = "Next";
            this.NextBut.UseVisualStyleBackColor = true;
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // NavBut
            // 
            this.NavBut.Location = new System.Drawing.Point(996, 17);
            this.NavBut.Name = "NavBut";
            this.NavBut.Size = new System.Drawing.Size(52, 23);
            this.NavBut.TabIndex = 3;
            this.NavBut.Text = "Go";
            this.NavBut.UseVisualStyleBackColor = true;
            this.NavBut.Click += new System.EventHandler(this.NavBut_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1036, 321);
            this.webBrowser1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Currency Converter App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selet From Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select To Currency";
            // 
            // FromCurComBox
            // 
            this.FromCurComBox.FormattingEnabled = true;
            this.FromCurComBox.Items.AddRange(new object[] {
            "AFA",
            "ALL",
            "DZD",
            "ARS",
            "AWG",
            "AUD",
            "BSD",
            "BHD",
            "BDT",
            "BBD",
            "BZD",
            "BMD",
            "BTN",
            "BOB",
            "BWP",
            "BRL",
            "GBP",
            "BND",
            "BIF",
            "XOF",
            "XAF",
            "KHR",
            "CAD",
            "CVE",
            "KYD",
            "CLP",
            "CNY",
            "COP",
            "KMF",
            "CRC",
            "HRK",
            "CUP",
            "CYP",
            "CZK",
            "DKK",
            "DJF",
            "DOP",
            "XCD",
            "EGP",
            "SVC",
            "EEK",
            "ETB",
            "EUR",
            "FKP",
            "GMD",
            "GHC",
            "GIP",
            "XAU",
            "GTQ",
            "GNF",
            "GYD",
            "HTG",
            "HNL",
            "HKD",
            "HUF",
            "ISK",
            "INR",
            "IDR",
            "IQD",
            "ILS",
            "JMD",
            "JPY",
            "JOD",
            "KZT",
            "KES",
            "KRW",
            "KWD",
            "LAK",
            "LVL",
            "LBP",
            "LSL",
            "LRD",
            "LYD",
            "LTL",
            "MOP",
            "MKD",
            "MGF",
            "MWK",
            "MYR",
            "MVR",
            "MTL",
            "MRO",
            "MUR",
            "MXN",
            "MDL",
            "MNT",
            "MAD",
            "MZM",
            "MMK",
            "NAD",
            "NPR",
            "ANG",
            "NZD",
            "NIO",
            "NGN",
            "KPW",
            "NOK",
            "OMR",
            "XPF",
            "PKR",
            "XPD",
            "PAB",
            "PGK",
            "PYG",
            "PEN",
            "PHP",
            "XPT",
            "PLN",
            "QAR",
            "ROL",
            "RUB",
            "WST",
            "STD",
            "SAR",
            "SCR",
            "SLL",
            "XAG",
            "SGD",
            "SKK",
            "SIT",
            "SBD",
            "SOS",
            "ZAR",
            "LKR",
            "SHP",
            "SDD",
            "SRG",
            "SZL",
            "SEK",
            "CHF",
            "SYP",
            "TWD",
            "TZS",
            "THB",
            "TOP",
            "TTD",
            "TND",
            "TRL",
            "USD",
            "AED",
            "UGX",
            "UAH",
            "UYU",
            "VUV",
            "VEB",
            "VND",
            "YER",
            "YUM",
            "ZMK",
            "ZWD",
            "TRY"});
            this.FromCurComBox.Location = new System.Drawing.Point(124, 424);
            this.FromCurComBox.Name = "FromCurComBox";
            this.FromCurComBox.Size = new System.Drawing.Size(121, 21);
            this.FromCurComBox.TabIndex = 8;
            // 
            // ToCurComBox
            // 
            this.ToCurComBox.FormattingEnabled = true;
            this.ToCurComBox.Items.AddRange(new object[] {
            "AFA",
            "ALL",
            "DZD",
            "ARS",
            "AWG",
            "AUD",
            "BSD",
            "BHD",
            "BDT",
            "BBD",
            "BZD",
            "BMD",
            "BTN",
            "BOB",
            "BWP",
            "BRL",
            "GBP",
            "BND",
            "BIF",
            "XOF",
            "XAF",
            "KHR",
            "CAD",
            "CVE",
            "KYD",
            "CLP",
            "CNY",
            "COP",
            "KMF",
            "CRC",
            "HRK",
            "CUP",
            "CYP",
            "CZK",
            "DKK",
            "DJF",
            "DOP",
            "XCD",
            "EGP",
            "SVC",
            "EEK",
            "ETB",
            "EUR",
            "FKP",
            "GMD",
            "GHC",
            "GIP",
            "XAU",
            "GTQ",
            "GNF",
            "GYD",
            "HTG",
            "HNL",
            "HKD",
            "HUF",
            "ISK",
            "INR",
            "IDR",
            "IQD",
            "ILS",
            "JMD",
            "JPY",
            "JOD",
            "KZT",
            "KES",
            "KRW",
            "KWD",
            "LAK",
            "LVL",
            "LBP",
            "LSL",
            "LRD",
            "LYD",
            "LTL",
            "MOP",
            "MKD",
            "MGF",
            "MWK",
            "MYR",
            "MVR",
            "MTL",
            "MRO",
            "MUR",
            "MXN",
            "MDL",
            "MNT",
            "MAD",
            "MZM",
            "MMK",
            "NAD",
            "NPR",
            "ANG",
            "NZD",
            "NIO",
            "NGN",
            "KPW",
            "NOK",
            "OMR",
            "XPF",
            "PKR",
            "XPD",
            "PAB",
            "PGK",
            "PYG",
            "PEN",
            "PHP",
            "XPT",
            "PLN",
            "QAR",
            "ROL",
            "RUB",
            "WST",
            "STD",
            "SAR",
            "SCR",
            "SLL",
            "XAG",
            "SGD",
            "SKK",
            "SIT",
            "SBD",
            "SOS",
            "ZAR",
            "LKR",
            "SHP",
            "SDD",
            "SRG",
            "SZL",
            "SEK",
            "CHF",
            "SYP",
            "TWD",
            "TZS",
            "THB",
            "TOP",
            "TTD",
            "TND",
            "TRL",
            "USD",
            "AED",
            "UGX",
            "UAH",
            "UYU",
            "VUV",
            "VEB",
            "VND",
            "YER",
            "YUM",
            "ZMK",
            "ZWD",
            "TRY"});
            this.ToCurComBox.Location = new System.Drawing.Point(124, 451);
            this.ToCurComBox.Name = "ToCurComBox";
            this.ToCurComBox.Size = new System.Drawing.Size(121, 21);
            this.ToCurComBox.TabIndex = 9;
            // 
            // CurRateBut
            // 
            this.CurRateBut.Location = new System.Drawing.Point(24, 483);
            this.CurRateBut.Name = "CurRateBut";
            this.CurRateBut.Size = new System.Drawing.Size(75, 23);
            this.CurRateBut.TabIndex = 10;
            this.CurRateBut.Text = "Get Rate";
            this.CurRateBut.UseVisualStyleBackColor = true;
            this.CurRateBut.Click += new System.EventHandler(this.CurRateBut_Click);
            // 
            // CurrencyRate
            // 
            this.CurrencyRate.Location = new System.Drawing.Point(135, 485);
            this.CurrencyRate.Name = "CurrencyRate";
            this.CurrencyRate.ReadOnly = true;
            this.CurrencyRate.Size = new System.Drawing.Size(100, 20);
            this.CurrencyRate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock Quote App";
            // 
            // StockSymbInp
            // 
            this.StockSymbInp.Location = new System.Drawing.Point(478, 422);
            this.StockSymbInp.Name = "StockSymbInp";
            this.StockSymbInp.Size = new System.Drawing.Size(100, 20);
            this.StockSymbInp.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter the Stock Symbol";
            // 
            // StoQuoBut
            // 
            this.StoQuoBut.Location = new System.Drawing.Point(428, 452);
            this.StoQuoBut.Name = "StoQuoBut";
            this.StoQuoBut.Size = new System.Drawing.Size(75, 23);
            this.StoQuoBut.TabIndex = 15;
            this.StoQuoBut.Text = "Get Quote";
            this.StoQuoBut.UseVisualStyleBackColor = true;
            this.StoQuoBut.Click += new System.EventHandler(this.StoQuoBut_Click);
            // 
            // StoQuoRes
            // 
            this.StoQuoRes.Location = new System.Drawing.Point(359, 485);
            this.StoQuoRes.Name = "StoQuoRes";
            this.StoQuoRes.ReadOnly = true;
            this.StoQuoRes.Size = new System.Drawing.Size(219, 20);
            this.StoQuoRes.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Encryption and Decryption App";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Enter text to be Encrypted";
            // 
            // EncryInp
            // 
            this.EncryInp.Location = new System.Drawing.Point(665, 437);
            this.EncryInp.Name = "EncryInp";
            this.EncryInp.Size = new System.Drawing.Size(155, 20);
            this.EncryInp.TabIndex = 20;
            // 
            // EncryptOut
            // 
            this.EncryptOut.Location = new System.Drawing.Point(665, 488);
            this.EncryptOut.Name = "EncryptOut";
            this.EncryptOut.ReadOnly = true;
            this.EncryptOut.Size = new System.Drawing.Size(155, 20);
            this.EncryptOut.TabIndex = 21;
            // 
            // EncrypBut
            // 
            this.EncrypBut.Location = new System.Drawing.Point(708, 461);
            this.EncrypBut.Name = "EncrypBut";
            this.EncrypBut.Size = new System.Drawing.Size(75, 23);
            this.EncrypBut.TabIndex = 22;
            this.EncrypBut.Text = "Encrypt Text";
            this.EncrypBut.UseVisualStyleBackColor = true;
            this.EncrypBut.Click += new System.EventHandler(this.EncrypBut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(887, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Enter text to be Decrypted";
            // 
            // DecryInp
            // 
            this.DecryInp.Location = new System.Drawing.Point(873, 437);
            this.DecryInp.Name = "DecryInp";
            this.DecryInp.Size = new System.Drawing.Size(155, 20);
            this.DecryInp.TabIndex = 24;
            // 
            // DecryptOut
            // 
            this.DecryptOut.Location = new System.Drawing.Point(873, 488);
            this.DecryptOut.Name = "DecryptOut";
            this.DecryptOut.ReadOnly = true;
            this.DecryptOut.Size = new System.Drawing.Size(155, 20);
            this.DecryptOut.TabIndex = 25;
            // 
            // DecrypBut
            // 
            this.DecrypBut.Location = new System.Drawing.Point(912, 461);
            this.DecrypBut.Name = "DecrypBut";
            this.DecrypBut.Size = new System.Drawing.Size(78, 23);
            this.DecrypBut.TabIndex = 26;
            this.DecrypBut.Text = "Decrypt Text";
            this.DecrypBut.UseVisualStyleBackColor = true;
            this.DecrypBut.Click += new System.EventHandler(this.DecrypBut_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(961, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Vignesh Jayabalan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 524);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DecrypBut);
            this.Controls.Add(this.DecryptOut);
            this.Controls.Add(this.DecryInp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EncrypBut);
            this.Controls.Add(this.EncryptOut);
            this.Controls.Add(this.EncryInp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StoQuoRes);
            this.Controls.Add(this.StoQuoBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StockSymbInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrencyRate);
            this.Controls.Add(this.CurRateBut);
            this.Controls.Add(this.ToCurComBox);
            this.Controls.Add(this.FromCurComBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.NavBut);
            this.Controls.Add(this.NextBut);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.AddressBox);
            this.Name = "Form1";
            this.Text = "Vignesh\'s Browser App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button NextBut;
        private System.Windows.Forms.Button NavBut;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FromCurComBox;
        private System.Windows.Forms.ComboBox ToCurComBox;
        private System.Windows.Forms.Button CurRateBut;
        private System.Windows.Forms.TextBox CurrencyRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StockSymbInp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StoQuoBut;
        private System.Windows.Forms.TextBox StoQuoRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EncryInp;
        private System.Windows.Forms.TextBox EncryptOut;
        private System.Windows.Forms.Button EncrypBut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DecryInp;
        private System.Windows.Forms.TextBox DecryptOut;
        private System.Windows.Forms.Button DecrypBut;
        private System.Windows.Forms.Label label9;
    }
}

