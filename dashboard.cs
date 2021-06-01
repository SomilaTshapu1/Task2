using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Car_System
{
    
    public partial class Vehicle : Form
    {
        double InterestRate, monthlyInteresetRate, loanAmount, MonthlyPayment, TotalPayment,  deposit, insurance;

        private void btnReciept_Click(object sender, EventArgs e)
        {
            //this will output every thing that is captured in the textboxes and combobox as reciept
            rtreciept.AppendText("--------------------------------------REPORT---------------------------------------------" + "\n");
            rtreciept.AppendText("---------------------------------------------------------------------------------------------\n");
            rtreciept.AppendText("Car Make and Model" + "\t" + cmbCarType.Text + "\n");
            rtreciept.AppendText("Purchace Price" + "\t\t" + txtPurchasePrice.Text + "\n");
            rtreciept.AppendText("Number of Years" + "\t\t" + txtPeriod.Text + "\n");
            rtreciept.AppendText("Interest Rate" + "\t\t" + txtImnterest.Text + "%"+"\n");
            rtreciept.AppendText("Monthly Payment" + "\t\t" + lblMonthlyPayment.Text + "\n");
            rtreciept.AppendText("---------------------------------------------------------------------------------------------\n");
            rtreciept.AppendText("Total " + "\t\t\t" + lblTotalPayment.Text + "\n");
            rtreciept.AppendText("---------------------------------------------------------------------------------------------\n");

        }

        private void cmbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExpenses_car_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
            this.Hide();
        }

        private void btnRent_car_Click(object sender, EventArgs e)
        {
            new Rent().Show();
            this.Hide();
        }

        private void btnHomeloan_car_Click(object sender, EventArgs e)
        {
            new House().Show();
            this.Hide();
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtImnterest.Clear();
            txtInsurance.Clear();
            txtPeriod.Clear();
            txtPurchasePrice.Text = "";
            txtTotalDeposit.Text = "";
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            cmbCarType.Text = "Choose";
            rtreciept.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //this button is for importing the report from rich textbox into text files
             OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files| *.txt";

            if(ofd.ShowDialog()== DialogResult.OK)
            {
                rtreciept.Text = System.IO.File.ReadAllText(ofd.FileName);
            }



        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //this button is for exporting the report from rich textbox into text files
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files| *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, rtreciept.Text);
            }
        }

        String iMonthlyPayment, iTotalPayment;
        int numberOfYears;

        private void btnCarfinance_Click(object sender, EventArgs e)
        {
            // if the user clicks on this button it will calculate the payments and output the amounts that the user will pay or have paid
            InterestRate = Convert.ToDouble(txtImnterest.Text);
            monthlyInteresetRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtPeriod.Text);
            loanAmount = Convert.ToDouble(txtPurchasePrice.Text);
            deposit = Convert.ToDouble(txtTotalDeposit.Text);
            insurance = Convert.ToDouble(txtInsurance.Text);

            
            MonthlyPayment = (loanAmount + deposit) * monthlyInteresetRate / (1 - 1 / Math.Pow(1 + monthlyInteresetRate , numberOfYears * 12));

            
            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);

            txtPurchasePrice.Text = String.Format("{0:C}", loanAmount);
        }

        List<String> list;
        public Vehicle()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // using generic collections lists for storing data into a combo box
            list = new List<String>(25);
            list.Add("Toyota Hilux");
            list.Add("Volkswagen Polo Vivo");
            list.Add("Ford Ranger");
            list.Add("Volkswagen Polo");
            list.Add("Isuzu D-Max");
            list.Add("Toyota Hi-Ace");
            list.Add("Nissan NP200");
            list.Add("Toyota Fortuner");
            list.Add("Toyota Corolla Quest");
            list.Add("Ford EcoSport");
            list.Add("Renault Kwid");
            list.Add("Toyota Etios");
            list.Add("Volkswagen T-Cross");
            list.Add("Hyundai Grand i10");
            list.Add("Suzuki Swift");
            list.Add("Hyundai i20");
            list.Add("Nissan NP300");
            list.Add("Ford Figo");
            list.Add("Hyundai Venue");
            list.Add("Haval H2");
            list.Add("Kia Picando");
            list.Add("Kia Rio");
            list.Add("Datsun  Go");
            list.Add("Renault Clio ");
            list.Add("Mazda 2 ");

            //Sorting the items in decending order
            list.Sort();
            list.Reverse();
            foreach (String item in list)
            {
                cmbCarType.Items.Add(item);
            }
            
        }

       
    }
}
