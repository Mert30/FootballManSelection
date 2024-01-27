using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int count = listBox3.Items.Count;
             Random rand = new Random();
             int number = rand.Next(0, count);
             listBox3.SelectedIndex = number;
             listBox1.Items.Add(listBox3.SelectedItem.ToString());             
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int count = listBox3.Items.Count;
            Random rand = new Random();
            int number = rand.Next(0, count);
            listBox3.SelectedIndex = number;
            listBox2.Items.Add(listBox3.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
        }
    }
}
