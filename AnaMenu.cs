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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete(@"veriler.txt");
        }

       
       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          


            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ebob goster = new Ebob();
            goster.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ekok goster = new Ekok();
            goster.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Carpan goster = new Carpan();
            goster.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 goster = new Form9();
            goster.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AkrepYelkovan goster = new AkrepYelkovan();
            goster.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            string myPath = @"veriler.txt";
            System.Diagnostics.Process islem = new System.Diagnostics.Process();
            islem.StartInfo.FileName = myPath;
            islem.Start();

            this.Close();
            Application.Exit();
            

        }
    }
}
