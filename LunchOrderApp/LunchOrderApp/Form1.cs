using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrderApp
{
    public partial class frmHamburger : Form
    {
        decimal Subtotal;
        decimal Tax = 0.0775m;
        decimal OrderTotal;

// Main file for adding the changing checkboxes

        public frmHamburger()
        {
            InitializeComponent();
        }

        private void Addons_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                grpAddon.Text = "Add-on items($.75/each";
                chk1.Text = "Lettuce, tomato, and onions";
                chk2.Text = "Mayonnaise and mustard";
                chk3.Text = "French fries";

                chk1.Checked = false;
                chk2.Checked = false;
                chk3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();

            }
            else if (rdoPizza.Checked)
            {
                grpAddon.Text = "Add-on items($.50/each)";
                chk1.Text = "Pepproni";
                chk2.Text = "Sausage";
                chk3.Text = "Olives";

                chk1.Checked = false;
                chk2.Checked = false;
                chk3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
            }
            else if (rdoSalad.Checked)
            {
                grpAddon.Text = "Add-on items($.25/each";
                chk1.Text = "Croutons";
                chk2.Text = "Bacon bits";
                chk3.Text = "Bread sticks";

                chk1.Checked = false;
                chk2.Checked = false;
                chk3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
            }
            txtOrderTotal.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {


            string message = "Thank You for Using Our Service!\n Would You Like use our service again?";
            DialogResult button =
                MessageBox.Show(message, "Dear Customer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (button == DialogResult.No)
            {
                this.Close();
            }
            if (button == DialogResult.Yes)
            {
                MessageBox.Show("Thank You!! \n We Hope you will come Soon!", "Greeting Message");
                this.Close();
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            decimal add = 0m;
            if (chk1.Checked)
            {
                add++;
            }
            if (chk2.Checked)
            {
                add++;
            }
            if (chk3.Checked)
            {
                add++;
            }
            if (rdoHamburger.Checked)
            {
                decimal Hamburger = Convert.ToDecimal(rdoHamburger.Checked);
                Hamburger = 6.95m;

                Subtotal = Hamburger + (add * .75m);
                Tax = Subtotal * 0.0775m;
                OrderTotal = Tax + Subtotal;

                txtSubtotal.Text = Subtotal.ToString("c");
                txtTax.Text = Tax.ToString("c");
                txtOrderTotal.Text = OrderTotal.ToString("c");

            }
            else if (rdoPizza.Checked)
            {

                decimal Pizza = Convert.ToDecimal(rdoPizza.Checked);
                Pizza = 5.95m;

                Subtotal = Pizza + (add * .50m);

                Tax = Subtotal * 0.00775m;

                OrderTotal = Tax + Subtotal;

                txtSubtotal.Text = Subtotal.ToString("c");
                txtTax.Text = Tax.ToString("c");
                txtOrderTotal.Text = OrderTotal.ToString("c");


            }
            else if (rdoSalad.Checked)
            {

                decimal salad = Convert.ToDecimal(rdoSalad.Checked);
                salad = 4.95m;

                Subtotal = salad + (add * .25m);

                Tax = Subtotal * 0.0775m;
                OrderTotal = Tax + Subtotal;
                txtSubtotal.Text = Subtotal.ToString("c");
                txtTax.Text = Tax.ToString("c");
                txtOrderTotal.Text = OrderTotal.ToString("c");
            }
        }
    }
}
