using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyLib;
using CSCI_Frank_Final_Project;

namespace CSCI_Frank_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Form1 wallet = new Form1();
        static Penny p = new Penny();
        static Nickel n = new Nickel();
        static Dime d = new Dime();
        static Quarter q = new Quarter();
        static SilverDollar sd = new SilverDollar();
        static FiveDollarBill d5 = new FiveDollarBill();
        static TenDollarBill d10 = new TenDollarBill();
        static TwentyDollarBill d20 = new TwentyDollarBill();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tempCount = 0;
            tempCount = (int)penny.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(n);
            }
            tempCount = (int)dime.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(d);
            }
            tempCount = (int)quarter.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(q);
            }
            tempCount = (int)nickel.Value;
            for (int i = 0; i < tempCount; i++ )
            {
                listBox1.Items.Add(n);
            }
            tempCount = (int)silverdollar.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(sd);
            }
            tempCount = (int)fivedollar.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(d5);
            }
            tempCount = (int)tendollars.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(d10);
            }
            tempCount = (int)twentydollars.Value;
            for (int i = 0; i < tempCount; i++)
            {
                listBox1.Items.Add(d20);
            }

            penny.Value = 0;
            nickel.Value = 0;
            dime.Value = 0;
            quarter.Value = 0;
            silverdollar.Value = 0;
            fivedollar.Value = 0;
            tendollars.Value = 0;
            twentydollars.Value = 0;

            displayTotal();

        }

        private void displayTotal()
        {
            decimal temptotal = 0m;
            foreach (CirculatingMoney mn in listBox1.Items)
            {
                temptotal += mn.Value;
            }
            textBox1.Text = temptotal.ToString();
            
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
