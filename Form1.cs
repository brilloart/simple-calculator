using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laporan_praktikum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int penambahan(int a, int b)
        {
            return a + b;
        }
        private int pengurangan(int a, int b)
        {
            return a - b;

        }
        private int perkalian(int a, int b)
        {
            return a * b;
        }
        private float pembagian(float a, float b)
        {
            return a / b;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nilaiA.Text);
            var b = Convert.ToInt32(nilaiB.Text);
 

            string combo;
            combo = comboBox1.Text;

            if (combo == "Penambahan")
                {
                listView1.Items.Clear();
                listView1.Items.Add(string.Format( "" + penambahan(a,b)));
                }
            else if (combo == "Pengurangan")
            {
                listView1.Items.Clear();
                listView1.Items.Add(string.Format ( ""+pengurangan(a, b)));
            }
            else if (combo == "Perkalian")
            {
                listView1.Items.Clear();
                listView1.Items.Add(string.Format("" + perkalian(a, b)));
            }
            else if (combo == "Pembagian")
            {
                listView1.Items.Clear();
                listView1.Items.Add(string.Format("" + pembagian(a, b)));
            }
        }
    }
}
