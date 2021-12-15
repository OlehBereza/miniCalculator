using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtWartosc1.Enabled = false;
            txtWartosc2.Enabled = false;
            
           

        }
        private void btnHaslo_Click(object sender, EventArgs e)
        {
           
            if (txtHaslo.Text == "abc")
            {
                txtWartosc1.Enabled = true;
                txtWartosc2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Haslo nie jest poprawne");
            }
        }



        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex("^[0-9]+$");


            if (txtWartosc1.Text == "" || txtWartosc2.Text == "")
            {
                uwaga1.Visible = true;
                uwaga2.Visible = true;

                MessageBox.Show("Pola * sa obowiazkowe");
            }

            else
            {
                if (rg.Match(txtWartosc1.Text).Success || rg.Match(txtWartosc2.Text).Success)
                {
                    uwaga1.Visible = false;
                    uwaga2.Visible = false;

                    int liczba1 = Convert.ToInt32(txtWartosc1.Text);
                    int liczba2 = Convert.ToInt32(txtWartosc2.Text);
                    txtWynikObliczen.Text = String.Format("{0}", liczba1 + liczba2);
                }
                else
                {

                }

                MessageBox.Show("Podane wartosci nie sa liczbowe");
            }



            
        }

        private void txtWartosc1_TextChanged(object sender, EventArgs e)
        {
            if (txtWartosc1.Text == "")
            {
                uwaga1.Visible = true;

            }
            else
            {
                uwaga1.Visible = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtWartosc2.Text == "")
            {
                uwaga2.Visible = true;

            }
            else
            {
                uwaga2.Visible = false;
            }
        }

       
    }
}
