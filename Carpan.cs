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
    public partial class Carpan : Form
    {
        public Carpan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txt_s1.Text);
            int sonuc = 0;
            for(int i = 1; i < s1; i++)
            {
                if (s1 % i == 0)
                {
                    sonuc += i;

                }
             
                textBox3.Text = Convert.ToString(sonuc);

            }
            if (s1 < 0)
            {
                textBox3.Text = "Hata";

            }
            
            using (StreamWriter sw = new StreamWriter("veriler.txt", true))
            {
                try
                {
                    sw.WriteLine("Carpan:  " + txt_s1.Text );
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
