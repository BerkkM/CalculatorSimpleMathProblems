using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Ebob : Form
    {
        public Ebob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                int s1 = Convert.ToInt32(txt_s1.Text);
                int s2 = Convert.ToInt32(txt_s2.Text);
                int ebob=1;
                

                if (s1 < s2)
                {
                    for (int i = 1; i < s2; i++)
                    {
                        if (s2 % i == 0 && s1 % i == 0)
                        { ebob = i;
                            
                        }
                    }

                }
                else
                {
                    for (int i = 1; i < s1; i++)
                    {
                        if (s2 % i == 0 && s1 % i == 0)
                        { ebob = i; }
                    }

                }
                textBox3.Text = Convert.ToString(ebob);
                if (s1 < 0 || s2<0)
                {
                    label4.Visible = true;
                    textBox3.Text = "Hata";
                }
                else
                {
                    label4.Visible = false;
                }
                


                
                
                using (StreamWriter sw = new StreamWriter("veriler.txt",true))
                {
                    try
                    {
                        sw.WriteLine("EBOB bul:  " + txt_s1.Text + "   " + txt_s2.Text);
                        sw.WriteLine(" " + textBox3.Text);
                        if(label4.Visible == true){
                            sw.WriteLine("=" + label4.Text);
                        }
                      
                 }
                    finally
                    {
                        sw.Flush();
                        sw.Close();
                    }
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
