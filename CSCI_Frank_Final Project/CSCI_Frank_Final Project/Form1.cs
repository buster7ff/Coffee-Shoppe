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
            //closes the program
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //not everything has been named however all the calculateing for the inital amount works
            //after we have another library to include from the skeloton of this code will work on btnCaculatePrice
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
            for (int i = 0; i < tempCount; i++)
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
            txtAmtMoney.Text = temptotal.ToString();

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void penny_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            //makes dthe other half of the screen visable 
            //hopefully can keep the user from not beingg overwhelemed at first
            //only sets the right half of the screen visable
            btnCreditCard.Visible = true;
            label2.Visible = true;
            label15.Visible = true;
            penny.Visible = true;
            nickel.Visible = true;
            dime.Visible = true;
            quarter.Visible = true;
            silverdollar.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            fivedollar.Visible = true;
            label8.Visible = true;
            tendollars.Visible = true;
            twentydollars.Visible = true;
            label9.Visible = true;
            label9.Visible = true;
            label1.Visible = true;
            txtAmtMoney.Visible = true;
            listBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            btnCreditCard.Visible = true;
            label17.Visible = true;
            txtChangedOwed.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
         


        }
    }
}
