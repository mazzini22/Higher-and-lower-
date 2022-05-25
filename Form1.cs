using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double n3 = Convert.ToDouble(txt3.Text);

            // verificando qual é o maior
           if (n1 > n2)
            {
                if (n1 > n3)
                {
                    lblmaior.Text = n1 + " é maior";
                }
                else
                {
                    lblmaior.Text = n3 + " é maior";
                }
                
            }
            else
            {
                if (n2 > n3)
                {
                    lblmaior.Text = n2 + " é maior";
                }
                else
                {
                    lblmaior.Text = n3 + " é maior";
                }
            }
            // fim verificação

            // menor
            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    lblmenor.Text = n1 + " é menor";
                }
                else
                {
                    lblmenor.Text = n3 + " é menor";
                }

            }
            else
            {
                if (n2 < n3)
                {
                    lblmenor.Text = n2 + " é menor";
                }
                else
                {
                    lblmenor.Text = n3 + " é menor";
                }
            }
            //fim da verificação
            
            //soma
            lblsoma.Text = "soma: " + Convert.ToString(n1 + n2 + n3);
            //

            //media
            lblmedia.Text = "media: " + Convert.ToString((n1 + n2 + n3) / 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt2.Text = "";
            lblmaior.Text = "";
            lblmenor.Text = "";
            lblsoma.Text = "";
            lblmedia.Text = "";
            txt1.Focus();

        }
    }
}
