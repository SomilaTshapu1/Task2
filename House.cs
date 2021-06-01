using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_System
{
    public partial class House : Form
    {
        double InterestRate, monthlyInteresetRate, loanAmount, MonthlyPayment, TotalPayment;

        private void btnExpenses_car_Click(object sender, EventArgs e)
        {
            // navigating to another page

            new Vehicle().Show();
            this.Hide();
        }

        private void btnRent_car_Click(object sender, EventArgs e)
        {
            //navigating to another page
            new Rent().Show();
            this.Hide();
        }

        private void btnHomeloan_car_Click(object sender, EventArgs e)
        {
            //navigating to another pages
            new Expenses().Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //this will clear everything in the form for the user to start fresh
            txtAmountofLoan.Clear();
            txtInterestRate.Clear();
            txtNumberOfYears.Clear();
            txtDepo.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtReciept.Clear();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            //this will output every thing that is captured in the textboxes and combobox as reciept
            rtReciept.AppendText("\t\" HOUSE" + "\n" + "----------------------------------------------------------------------------------------" + "\n");
            rtReciept.AppendText("-------------------------------------------------------------------------------------------------\n");
            rtReciept.AppendText("Loan Amount" + "\t\t" + txtAmountofLoan.Text + "\n");
            rtReciept.AppendText("Number of Years" + "\t\t" + txtNumberOfYears.Text + "\n");
            rtReciept.AppendText("Interest Rate" + "\t\t" + txtInterestRate.Text + "\n");
            rtReciept.AppendText("Monthly Payment" + "\t\t" + lblMonthlyPayment.Text + "\n");
            rtReciept.AppendText("------------------------------------------------------------------------------------------------------\n");
            rtReciept.AppendText("Total" + "\t\t\t" + lblTotalPayment.Text + "\n");
            rtReciept.AppendText("------------------------------------------------------------------------------------------------------\n");

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

        private void House_Load(object sender, EventArgs e)
        {

        }

        public House()
        {
            InitializeComponent();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            // the system will calculate the loan payments
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInteresetRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountofLoan.Text);

            MonthlyPayment = loanAmount * monthlyInteresetRate / (1 - 1 / Math.Pow(1 + monthlyInteresetRate, numberOfYears * 12));


            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);

            txtAmountofLoan.Text = String.Format("{0:}", loanAmount);
        }

        String iMonthlyPayment, iTotalPayment;
        int numberOfYears;
    }
    }
