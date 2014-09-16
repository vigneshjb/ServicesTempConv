namespace TempConvForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InpCel = new System.Windows.Forms.TextBox();
            this.InpFar = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CelToFarBut = new System.Windows.Forms.Button();
            this.FarToCelBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Celsius to Fahrenheit ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Celsius";
            // 
            // InpCel
            // 
            this.InpCel.Location = new System.Drawing.Point(110, 82);
            this.InpCel.Name = "InpCel";
            this.InpCel.Size = new System.Drawing.Size(113, 20);
            this.InpCel.TabIndex = 2;
            // 
            // InpFar
            // 
            this.InpFar.Location = new System.Drawing.Point(110, 153);
            this.InpFar.Name = "InpFar";
            this.InpFar.Size = new System.Drawing.Size(113, 20);
            this.InpFar.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(110, 216);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(113, 20);
            this.Result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fahrenheit to  Celsius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Fahrenheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result";
            // 
            // CelToFarBut
            // 
            this.CelToFarBut.Location = new System.Drawing.Point(238, 78);
            this.CelToFarBut.Name = "CelToFarBut";
            this.CelToFarBut.Size = new System.Drawing.Size(60, 26);
            this.CelToFarBut.TabIndex = 8;
            this.CelToFarBut.Text = "Convert";
            this.CelToFarBut.UseVisualStyleBackColor = true;
            this.CelToFarBut.Click += new System.EventHandler(this.CelToFarBut_Click);
            // 
            // FarToCelBut
            // 
            this.FarToCelBut.Location = new System.Drawing.Point(238, 149);
            this.FarToCelBut.Name = "FarToCelBut";
            this.FarToCelBut.Size = new System.Drawing.Size(60, 26);
            this.FarToCelBut.TabIndex = 9;
            this.FarToCelBut.Text = "Convert";
            this.FarToCelBut.UseVisualStyleBackColor = true;
            this.FarToCelBut.Click += new System.EventHandler(this.FarToCelBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "This Form Consumes a WCF service to convert Temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Design by Vignesh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 252);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FarToCelBut);
            this.Controls.Add(this.CelToFarBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InpFar);
            this.Controls.Add(this.InpCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InpCel;
        private System.Windows.Forms.TextBox InpFar;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CelToFarBut;
        private System.Windows.Forms.Button FarToCelBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

