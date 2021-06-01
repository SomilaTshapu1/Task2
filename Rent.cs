using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_System
{
    public partial class Rent : Form
    {
        List<String> list_;
        Dictionary<int,string> list;
        public Rent()
        {
            InitializeComponent();
        }

        private void btnCapture_rent_Click(object sender, EventArgs e)
        {
            //linking classes 
            cCustomer iCustomer = new cCustomer();
            RentClass iRent = new RentClass();
            cUtilities iUtilities = new cUtilities();

            iCustomer.theDeposit = Double.Parse(txtDeposit.Text);
            iRent.theCost = Double.Parse(txtCost.Text);
            iRent.theNumberofroom = Double.Parse(nudRoom.Text);
            iUtilities.theElectricity = Double.Parse(txtelectricity.Text);
            iUtilities.theLocalTax = Double.Parse(txtlocaltax.Text);
            iUtilities.theWaterBill = Double.Parse(txtWaterBill.Text);

            // Calculating the rent and utility bills
            String q = String.Format("{0:C}", iCustomer.theDeposit + iCustomer.theDownPayment + (iRent.theCost * iRent.theNumberofroom)
                + iUtilities.theElectricity + iUtilities.theLocalTax + iUtilities.theWaterBill);
            txtTotal.Text = q;

            String a = String.Format("{0:C}", iCustomer.theDeposit + iCustomer.theDownPayment + (iRent.theCost * iRent.theNumberofroom)
                + iUtilities.theElectricity + iUtilities.theLocalTax + iUtilities.theWaterBill);
            txtTotal.Text = a;


            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rent_Load(object sender, EventArgs e)
        {
            // using generic collections(dictionary) for storing data
            list = new Dictionary<int, string>();
            list.Add(1, "January");
            list.Add(2, "February");
            list.Add(3, "March");
            list.Add(4, "April");
            list.Add(5, "May");
            list.Add(6, "June");
            list.Add(7, "July");
            list.Add(8, "August");
            list.Add(9, "Septembe");
            list.Add(10, "October"); 
            list.Add(11, "November");
            list.Add(12, "December");

            foreach(KeyValuePair<int, string> item in list)
            {
                cmbMonth_rent.Items.Add(item.Key + ":" + item.Value);
            }
            // using generic collections for storing data
            list_ = new List<String>(31);
            list_.Add("1");
            list_.Add("2");
            list_.Add("3");
            list_.Add("4");
            list_.Add("5");
            list_.Add("6");
            list_.Add("7");
            list_.Add("8");
            list_.Add("9");
            list_.Add("10");
            list_.Add("11");
            list_.Add("12");
            list_.Add("13");
            list_.Add("14");
            list_.Add("15");
            list_.Add("16");
            list_.Add("17");
            list_.Add("18");
            list_.Add("19");
            list_.Add("20");
            list_.Add("21");
            list_.Add("22");
            list_.Add("23");
            list_.Add("24");
            list_.Add("25");
            list_.Add("26");
            list_.Add("27");
            list_.Add("28");
            list_.Add("29");
            list_.Add("30");
            list_.Add("31");


            foreach (String item in list_)
            {
                cmbDate_rent.Items.Add(item);
            }
            // usng generic collections for storing data
            list_ = new List<String>(5);
            list_.Add("2021");
            list_.Add("2022");
            list_.Add("2023");
            list_.Add("2024");
            list_.Add("2025");

            foreach (String item in list_)
            {
                cmbYear_rent.Items.Add(item);
            }

        }
        //Navigating to another page
        private void btnExpenses_car_Click(object sender, EventArgs e)
        {
            new Vehicle().Show();
            this.Hide();
        }
        //Navigating to another page
        private void btnRent_rent_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
            this.Hide();
        }

        private void btnHomeloan_rent_Click(object sender, EventArgs e)
        //Navigating to another page
        {
            new House().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //for exiting the system, it will ask the user to confirm if they want to exit
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtCost.Clear();
            txtAddress.Clear();
            txtDeposit.Clear();
            txtelectricity.Text = "";
            txtlocaltax.Text = "";
            txtPostalCode.Text = "";
            txtTotal.Text = "";
            txtWaterBill.Text = "";
            cmbDate_rent.Text = "";
            cmbMonth_rent.Text = "";
            cmbYear_rent.Text = "";
            cmbLocation.Text = "";
            rtReciept.Clear();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            //this will output every thing that is captured in the textboxes and combobox as reciept
            rtReciept.AppendText("--------------------------------------REPORT---------------------------------------------" + "\n");
            rtReciept.AppendText("---------------------------------------------------------------------------------------------\n");
            rtReciept.AppendText("Date" + "\t\t\t" + cmbDate_rent.Text + cmbMonth_rent.Text + cmbYear_rent.Text + "\n");
            rtReciept.AppendText("Address" + "\t\t\t" + txtAddress.Text + "\n");
            rtReciept.AppendText("Postal Code" + "\t\t" + txtPostalCode.Text + "\n");
            rtReciept.AppendText("Town" + "\t\t\t" + cmbLocation.Text + "\n");
            rtReciept.AppendText("----------------------------------------------------------------------------------------\n");
            rtReciept.AppendText("Cost" + "\t\t\t" + txtCost.Text + "\n");
            rtReciept.AppendText("Deposit" + "\t\t\t" + txtDeposit.Text + "\n");
            rtReciept.AppendText("Electricity" + "\t\t\t" + txtelectricity.Text + "\n");
            rtReciept.AppendText("Local Tax" + "\t\t\t" + txtlocaltax.Text + "\n");
            rtReciept.AppendText("Water Bill" + "\t\t\t" + txtWaterBill.Text + "\n");
            rtReciept.AppendText("------------------------------------------------------------------------------------------\n");
            rtReciept.AppendText("Total Payment" + "\t\t" + txtTotal.Text + "\n");
            rtReciept.AppendText("---------------------------------------------------------------------------------------------");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //this button is for importing the report from rich textbox into text files
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files| *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtReciept.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //this button is for exporting the report from rich textbox into text files
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files| *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, rtReciept.Text);
            }
        }
    }
}
