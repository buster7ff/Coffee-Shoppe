namespace shoppeform4._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPop = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.TextBox();
            this.lbxMoneyList = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.proccessing = new System.Windows.Forms.Button();
            this.productShelves = new System.Windows.Forms.Label();
            this.shoppingCart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPop
            // 
            this.addPop.Location = new System.Drawing.Point(153, 12);
            this.addPop.Name = "addPop";
            this.addPop.Size = new System.Drawing.Size(75, 74);
            this.addPop.TabIndex = 1;
            this.addPop.Text = "&Add";
            this.addPop.UseVisualStyleBackColor = true;
            this.addPop.Click += new System.EventHandler(this.addPop_Click);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(271, 142);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(115, 20);
            this.Total.TabIndex = 2;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // lbxMoneyList
            // 
            this.lbxMoneyList.FormattingEnabled = true;
            this.lbxMoneyList.Location = new System.Drawing.Point(266, 28);
            this.lbxMoneyList.Name = "lbxMoneyList";
            this.lbxMoneyList.Size = new System.Drawing.Size(120, 95);
            this.lbxMoneyList.TabIndex = 3;
            this.lbxMoneyList.SelectedIndexChanged += new System.EventHandler(this.lbxMoneyList_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 4;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(153, 92);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 70);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "&Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(153, 181);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "&Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // proccessing
            // 
            this.proccessing.Location = new System.Drawing.Point(271, 180);
            this.proccessing.Name = "proccessing";
            this.proccessing.Size = new System.Drawing.Size(115, 23);
            this.proccessing.TabIndex = 7;
            this.proccessing.Text = "&proccessing";
            this.proccessing.UseVisualStyleBackColor = true;
            this.proccessing.Click += new System.EventHandler(this.proccessing_Click);
            // 
            // productShelves
            // 
            this.productShelves.AutoSize = true;
            this.productShelves.Location = new System.Drawing.Point(23, 12);
            this.productShelves.Name = "productShelves";
            this.productShelves.Size = new System.Drawing.Size(81, 13);
            this.productShelves.TabIndex = 8;
            this.productShelves.Text = "productShelves";
            // 
            // shoppingCart
            // 
            this.shoppingCart.AutoSize = true;
            this.shoppingCart.Location = new System.Drawing.Point(295, 12);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(69, 13);
            this.shoppingCart.TabIndex = 9;
            this.shoppingCart.Text = "shoppingCart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 251);
            this.Controls.Add(this.shoppingCart);
            this.Controls.Add(this.productShelves);
            this.Controls.Add(this.proccessing);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbxMoneyList);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.addPop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPop;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.ListBox lbxMoneyList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button proccessing;
        private System.Windows.Forms.Label productShelves;
        private System.Windows.Forms.Label shoppingCart;
    }
}

