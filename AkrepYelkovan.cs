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
    public partial class AkrepYelkovan : Form
    {
        public AkrepYelkovan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txt_s1.Text);
            int s2 = Convert.ToInt32(txt_s2.Text);
            int aci =(11 * s2 - 60 * s1) / 2;
            
            if (aci < 0)
            {
                aci = aci*-1;
               
            }
            if (aci > 180)
            {
                aci = 360 - aci;
            }
            
            textBox3.Text = Convert.ToString(aci);
            if (s1 < 0 || s1 > 24)
            {
                label4.Visible = true;
                textBox3.Text = "Hata";
            }
            else
            {
                label4.Visible = false;
            }
            if (s2 < 0 || s2 > 60)
            {
                label5.Visible = true;
                textBox3.Text = "Hata";
            }
            else
            {
                label5.Visible = false;
            }

            using (StreamWriter sw = new StreamWriter("veriler.txt", true))
            {
                try
                {
                    sw.WriteLine("Akrep Yelkovan:  " + txt_s1.Text + "   " + txt_s2.Text);
                    sw.WriteLine("" + textBox3.Text);
                    if (label4.Visible == true)
                    {
                        sw.WriteLine("=" + label4.Text);
                    }
                    if (label5.Visible == true)
                    {
                        sw.WriteLine("=" + label5.Text);
                    }

                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                }
            }
        }
      
        private void txt_s1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
