using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////////////////////////////
//  Craig Rondinelli      //
//  CIS 202               //
//  Food - Final Project  //
////////////////////////////

namespace Rondinelli_Food
{
    public partial class frmMain : Form
    {
        public frmMain()
        {   //Names form upon loading.
            InitializeComponent();
            this.Text = "Rondinelli Food";
        }
        //Declares variable to track price of order throughout order.
        double price = 0;

        //Adds items to list box, to price variable, and displays feedback based on user choices when button is clicked.
        private void btnSandwich_Click(object sender, EventArgs e)
        {   
            if (radHam.Checked == true)
            {
                listOrder.Items.Add("Hamburger:     $6.99");
                price += 6.99;
                lblTotal.Text = price.ToString("c");
            }

            else if (radChick.Checked == true)
            {
                listOrder.Items.Add("Chicken:       $5.99");
                price += 5.99;
                lblTotal.Text = price.ToString("c");
            }

            else if (radFish.Checked == true)
            {
                listOrder.Items.Add("Fish:          $4.99");
                price += 4.99;
                lblTotal.Text = price.ToString("c");
            }

            if (chkKet.Checked == true)
            {
                listOrder.Items.Add("  Ketchup");
            }

            if (chkMus.Checked == true)
            {
                listOrder.Items.Add("  Mustard");
            }

            if (chkMayo.Checked == true)
            {
                listOrder.Items.Add("  Mayonnaise");
            }

            btnOrder.Enabled = true;


        }
        //Adds items to list box, to price variable, and displays feedback based on user choices when button is clicked.
        private void btnSide_Click(object sender, EventArgs e)
        {
            if (chkFry.Checked == true)
            {
                listOrder.Items.Add("Fries:         $1.99");
                price += 1.99;
                lblTotal.Text = price.ToString("c");
            }

            if (chkSalad.Checked == true)
            {
                listOrder.Items.Add("Salad:         $1.99");
                price += 1.99;
                lblTotal.Text = price.ToString("c");
            }

            if (chkChili.Checked == true)
            {
                listOrder.Items.Add("Chili:         $1.49");
                price += 1.49;
                lblTotal.Text = price.ToString("c");
            }

            if (chkIce.Checked == true)
            {
                listOrder.Items.Add("Ice Cream:     $2.49");
                price += 2.49;
                lblTotal.Text = price.ToString("c");
            }

            btnOrder.Enabled = true;

        }
        //Adds items to list box, to price variable, and displays feedback based on user choices when button is clicked.
        private void btnDrink_Click(object sender, EventArgs e)
        {
            if (radWater.Checked == true)
            {
                listOrder.Items.Add("Water:         $0.00");
            }

            btnOrder.Enabled = true;
        }
        //Declares variable to track order number.
        int counter = 1;

        //Displays total amount in messagebox, calls user method, increases order number, and resets other variables, settings, and listbox to default values.
        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order comes to " + price.ToString("c") + ".");
            thanks();
            listOrder.Items.Clear();
            price = 0;
            lblTotal.Text = price.ToString("c");
            counter++;
            lblOrder.Text = "Order #" + counter.ToString();
            tabControl1.SelectedTab = tabPage1;
            btnOrder.Enabled = false;
        }

        //Resets listbox, tab page, disables Order button, and displays messagebox.
        private void btnReset_Click(object sender, EventArgs e)
        {
            listOrder.Items.Clear();
            tabControl1.SelectedTab = tabPage1;
            MessageBox.Show("Your order has been reset!");
            btnOrder.Enabled = false;
        }

        //Exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //User defined method that shows a messagebox when called
        void thanks ()
        {
            MessageBox.Show("Thanks for your order!");
        }
    }
}