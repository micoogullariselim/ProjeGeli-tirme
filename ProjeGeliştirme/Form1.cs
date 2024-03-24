using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeGeliştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tboxetek.Text.ToString());
        }

        private void btnekle2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(tboxkazak.Text.ToString());
        }

        private void btnekle3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(tboxelb.Text.ToString());
        }

        private void btnekle4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(tboxceket.Text.ToString());
        }
    }
} // Yapılan işlem ve yazılan kodlarla textboxtan girilen veriler ekle buttonuyla listeye eklenmiştir.
