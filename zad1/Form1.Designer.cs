
namespace zad1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLiczba1 = new System.Windows.Forms.Label();
            this.lblLiczba2 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.txtWartosc1 = new System.Windows.Forms.TextBox();
            this.txtWartosc2 = new System.Windows.Forms.TextBox();
            this.txtWynikObliczen = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.uwaga1 = new System.Windows.Forms.Label();
            this.uwaga2 = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.Label();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.btnHaslo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLiczba1
            // 
            this.lblLiczba1.AutoSize = true;
            this.lblLiczba1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiczba1.Location = new System.Drawing.Point(231, 82);
            this.lblLiczba1.Name = "lblLiczba1";
            this.lblLiczba1.Size = new System.Drawing.Size(117, 45);
            this.lblLiczba1.TabIndex = 0;
            this.lblLiczba1.Text = "liczba1";
            // 
            // lblLiczba2
            // 
            this.lblLiczba2.AutoSize = true;
            this.lblLiczba2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiczba2.Location = new System.Drawing.Point(231, 183);
            this.lblLiczba2.Name = "lblLiczba2";
            this.lblLiczba2.Size = new System.Drawing.Size(117, 45);
            this.lblLiczba2.TabIndex = 1;
            this.lblLiczba2.Text = "liczba2";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wynik.Location = new System.Drawing.Point(231, 258);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 45);
            this.wynik.TabIndex = 2;
            this.wynik.Text = "wynik";
            // 
            // txtWartosc1
            // 
            this.txtWartosc1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWartosc1.Location = new System.Drawing.Point(373, 77);
            this.txtWartosc1.Name = "txtWartosc1";
            this.txtWartosc1.Size = new System.Drawing.Size(185, 50);
            this.txtWartosc1.TabIndex = 3;
            this.txtWartosc1.TextChanged += new System.EventHandler(this.txtWartosc1_TextChanged);
            // 
            // txtWartosc2
            // 
            this.txtWartosc2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWartosc2.Location = new System.Drawing.Point(373, 178);
            this.txtWartosc2.Name = "txtWartosc2";
            this.txtWartosc2.Size = new System.Drawing.Size(185, 50);
            this.txtWartosc2.TabIndex = 4;
            this.txtWartosc2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtWynikObliczen
            // 
            this.txtWynikObliczen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWynikObliczen.Location = new System.Drawing.Point(373, 253);
            this.txtWynikObliczen.Name = "txtWynikObliczen";
            this.txtWynikObliczen.Size = new System.Drawing.Size(185, 50);
            this.txtWynikObliczen.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.Location = new System.Drawing.Point(407, 340);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 50);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // uwaga1
            // 
            this.uwaga1.AutoSize = true;
            this.uwaga1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uwaga1.Location = new System.Drawing.Point(564, 93);
            this.uwaga1.Name = "uwaga1";
            this.uwaga1.Size = new System.Drawing.Size(224, 28);
            this.uwaga1.TabIndex = 7;
            this.uwaga1.Text = "* pole jest obowiazkowe";
            this.uwaga1.Visible = false;
            // 
            // uwaga2
            // 
            this.uwaga2.AutoSize = true;
            this.uwaga2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uwaga2.Location = new System.Drawing.Point(564, 194);
            this.uwaga2.Name = "uwaga2";
            this.uwaga2.Size = new System.Drawing.Size(224, 28);
            this.uwaga2.TabIndex = 8;
            this.uwaga2.Text = "* pole jest obowiazkowe";
            this.uwaga2.Visible = false;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haslo.Location = new System.Drawing.Point(43, 59);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(73, 32);
            this.haslo.TabIndex = 9;
            this.haslo.Text = "Haslo";
            // 
            // txtHaslo
            // 
            this.txtHaslo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHaslo.Location = new System.Drawing.Point(27, 119);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(100, 34);
            this.txtHaslo.TabIndex = 10;
            // 
            // btnHaslo
            // 
            this.btnHaslo.Location = new System.Drawing.Point(43, 183);
            this.btnHaslo.Name = "btnHaslo";
            this.btnHaslo.Size = new System.Drawing.Size(75, 23);
            this.btnHaslo.TabIndex = 11;
            this.btnHaslo.Text = "Enter";
            this.btnHaslo.UseVisualStyleBackColor = true;
            this.btnHaslo.Click += new System.EventHandler(this.btnHaslo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHaslo);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.uwaga2);
            this.Controls.Add(this.uwaga1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtWynikObliczen);
            this.Controls.Add(this.txtWartosc2);
            this.Controls.Add(this.txtWartosc1);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.lblLiczba2);
            this.Controls.Add(this.lblLiczba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btnDodaj_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLiczba1;
        private System.Windows.Forms.Label lblLiczba2;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.TextBox txtWartosc1;
        private System.Windows.Forms.TextBox txtWartosc2;
        private System.Windows.Forms.TextBox txtWynikObliczen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label uwaga1;
        private System.Windows.Forms.Label uwaga2;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Button btnHaslo;
    }
}

