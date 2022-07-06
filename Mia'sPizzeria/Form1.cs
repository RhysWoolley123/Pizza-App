using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mia_sPizzeria
{
    public partial class Form1 : Form
    {
        double total;
        List<details> customerList = new List<details>();
        List<items> pizzaDetails = new List<items>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPizza.Appearance = TabAppearance.FlatButtons;
            tabPizza.ItemSize = new Size(0, 1);
            tabPizza.SizeMode = TabSizeMode.Fixed;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            tabPizza.SelectedTab = tab3;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            total = total + 1.70 * Convert.ToDouble(numGarlic.Value) + 2.20 * Convert.ToDouble(numGarlCheese.Value);
            total = total + 3.50 * Convert.ToDouble(numChick5.Value) + 6.00 * Convert.ToDouble(numChick10.Value);
            total = total + 1.00 * Convert.ToDouble(numFriesReg.Value) + 1.30 * Convert.ToDouble(numFriesLarge.Value);
            total = total + 0.70 * Convert.ToDouble(numColeslaw.Value);

            total = total + 0.70 * Convert.ToDouble(numCoke.Value) + 0.70 * Convert.ToDouble(numDietCoke.Value);
            total = total + 0.70 * Convert.ToDouble(numPepsi.Value) + 0.70 * Convert.ToDouble(num7Up.Value);
            total = total + 0.70 * Convert.ToDouble(numFanta.Value) + 0.70 * Convert.ToDouble(numTango.Value);
            
            if (radioButton4.Checked && total < 20)
            {
                total = total + 5;
            }

            string totalAll = total.ToString();
            lblTotal.Text = "Total: £" +totalAll;

            displayCustomer();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOffer1_Click(object sender, EventArgs e)
        {
            tabPizza.SelectedTab = tabPage2;
        }

        private void btnOffer2_Click(object sender, EventArgs e)
        {
            tabPizza.SelectedTab = tabPage2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            details customerDetails = new details();
            customerDetails.name = txtName.Text;
            customerDetails.address = txtAddress.Text;
            customerDetails.telephone = txtPhone.Text;
            customerDetails.staff = txtStaff.Text;

            customerList.Add(customerDetails);


            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtStaff.Clear();

            
        }
        private void displayCustomer()
        {
            int y = 0;
            while (y < customerList.Count)
            {
                lstDetails.Items.Add(customerList[y].name + " " + customerList[y].address + " " + customerList[y].telephone + " " + customerList[y].staff);
                y++;
            }
            customerList.Clear();
            int x = 0;
            while (x < pizzaDetails.Count)
            {
                lstDetails.Items.Add(pizzaDetails[x].pizza + " " + pizzaDetails[x].size + " " + pizzaDetails[x].toppings);
                x++;
            }
            pizzaDetails.Clear();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            items pizzaType = new items();
            if (cboxSize.Text == "Small")
            {
                total += 3.50;
            }
            else if (cboxSize.Text == "Medium")
            {
                total += 5.00;
            }
            else if (cboxSize.Text == "Large")
            {
                total += 7.00;
            }
            foreach(object itemChecked in chckLstTopping.CheckedItems)
            {
                total = total + 0.80;
                pizzaType.toppings.Add(itemChecked.ToString());
            }
            
            pizzaType.pizza = cboxPizza.Text;
            pizzaType.size = cboxSize.Text;
            

            pizzaDetails.Add(pizzaType);


            cboxPizza.ResetText();
            cboxSize.ResetText();
            chckLstTopping.ClearSelected();
        }
    }
}
