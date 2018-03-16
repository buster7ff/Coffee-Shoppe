using System;
using System.Windows.Forms;


namespace shoppeform4._0
{
    public partial class Form1 : Form
    {
        Coke c;
        Sprite s;
        RootBeer h;
        Lays d;
        Kettle b;
        Doritos o;
        Ham a;
        Turkey t;
        Club l;
        Gormet g;
        Cappuchino p;
        Espresso e;

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(new Coke());
            listBox1.Items.Add(new Sprite());
            listBox1.Items.Add(new RootBeer());
            listBox1.Items.Add(new Lays());
            listBox1.Items.Add(new Kettle());
            listBox1.Items.Add(new Doritos());
            listBox1.Items.Add(new Ham ());
            listBox1.Items.Add(new Turkey());
            listBox1.Items.Add(new Club());
            listBox1.Items.Add(new Gormet());
            listBox1.Items.Add(new Cappuchino());
            listBox1.Items.Add(new Espresso());
        }
       
        private void addPop_Click(object sender, EventArgs e)
        {
            try
            {  
                lbxMoneyList.Items.Add(listBox1.SelectedItem);
                GetSelectedTotal();
            }
            catch (ArgumentNullException)
            {
                Total.Text.ToString();
            }
           finally
            {
               GetSelectedTotal();
            }
        }
        private void GetSelectedTotal()
        {
            decimal tempValue = 0.0m;
            foreach (object p in lbxMoneyList.Items)
            {
                if (p is Product tempProduct)
                {
                    tempValue += tempProduct.Price.Value;

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

        private void proccessing_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
