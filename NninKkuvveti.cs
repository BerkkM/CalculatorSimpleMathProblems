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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txt_s1.Text);
            int s2 = Convert.ToInt32(txt_s2.Text);
            int sonuc = 1;
            for (int i = 1; i <= s2; i++)
            {
                sonuc = sonuc * s1;
            }
            
          
            textBox3.Text = Convert.ToString(sonuc);
            
            using (StreamWriter sw = new StreamWriter("veriler.txt", true))
            {
                try
                {
                    sw.WriteLine("n'in k kuvveti:  " + txt_s1.Text + "   " + txt_s2.Text);
                    sw.WriteLine("=" + textBox3.Text);

                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }
}
