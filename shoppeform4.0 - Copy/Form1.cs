using System;
using System.Windows.Forms;


namespace shoppeform4._0
{
    public partial class Form1 : Form
    {
        Coke c;
        Sprite s;
        Pepsi h;
        Lays d;
        BBQ b;
        Sour o;
        
          
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(new Coke());
            listBox1.Items.Add(new Sprite());
            listBox1.Items.Add(new Pepsi());
            listBox1.Items.Add(new Lays());
            listBox1.Items.Add(new BBQ());
            listBox1.Items.Add(new Sour());
           
        }
       
        private void addPop_Click(object sender, EventArgs e)
        {

            lbxMoneyList.Items.Add(listBox1.SelectedItem);
            GetSelectedTotal();
        }

        private void GetSelectedTotal()
        {
            decimal tempValue = 0.0m;
            foreach (object p in lbxMoneyList.Items)
            {
                if (p is Pop tempPop)
                {
                    tempValue += tempPop.Price.Value;

                }
                else if (p is Chips tempChip)
                {
                    tempValue += tempChip.Price.Value;
                }
               
            }
            Total.Text = tempValue.ToString();

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxMoneyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            lbxMoneyList.Items.Remove(listBox1.SelectedItem);
            GetSelectedTotal();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lbxMoneyList.Items.Clear();
            GetSelectedTotal();

        }
    }
}
