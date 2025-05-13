using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fildan_Simina_Diferente
{
    public partial class Form1 : Form
    {
        int nrdif = 0, nrpasi=0;//cati pasi are progress barul
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Număr diferențe găsite: " + nrdif;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nrdif++;
            label1.Text = "Număr diferențe găsite: " + nrdif;
            //pictureBox3.Image = Properties.Resources.dif1_d;
            //MessageBox.Show("Bravo");
            pictureBox3.Enabled = false;
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            nrpasi++;
            if(nrdif==5 || nrpasi>60)
            {
                timer1.Stop();
                if (nrdif == 5)
                {
                    Form2 f = new Form2();
                    f.Show();
                }
                else
                {
                    Form3 g = new Form3();
                    g.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nrdif = 0;
            nrpasi = 0;
            label1.Text = "Număr diferențe găsite: " + nrdif;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            progressBar1.Value = 0;
            pictureBox3.Image = Properties.Resources.dif1_c;
            pictureBox4.Image = Properties.Resources.dif2;
            pictureBox5.Image = Properties.Resources.dif3;
            pictureBox6.Image = Properties.Resources.dif4;
            pictureBox7.Image = Properties.Resources.dif5;
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.dif1_d;
            pictureBox4.Image = Properties.Resources.dif2_b;
            pictureBox5.Image = Properties.Resources.dif3_b;
            pictureBox6.Image = Properties.Resources.dif4_b;
            pictureBox7.Image = Properties.Resources.dif5__b;
            timer1.Stop();
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            Form4 h = new Form4();
            h.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            nrdif++;
            label1.Text = "Număr diferențe găsite: " + nrdif;
            //pictureBox3.Image = Properties.Resources.dif1_d;
            //MessageBox.Show("Bravo");
            pictureBox4.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            nrdif++;
            label1.Text = "Număr diferențe găsite: " + nrdif;
            //pictureBox3.Image = Properties.Resources.dif1_d;
            //MessageBox.Show("Bravo");
            pictureBox5.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            nrdif++;
            label1.Text = "Număr diferențe găsite: " + nrdif;
            //pictureBox3.Image = Properties.Resources.dif1_d;
            //MessageBox.Show("Bravo");
            pictureBox6.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            nrdif++;
            label1.Text = "Număr diferențe găsite: " + nrdif;
            //pictureBox3.Image = Properties.Resources.dif1_d;
            //MessageBox.Show("Bravo");
            pictureBox7.Enabled = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
