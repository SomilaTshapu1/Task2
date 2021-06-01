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
    public partial class Expenses : Form
    {
        List<String> list;
        public Expenses()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Expenses_Class expenses = new Expenses_Class();


            expenses.theClothing = Double.Parse(txtClothing.Text);
            expenses.theElectricity = Double.Parse(txtElectricity.Text);
            expenses.theEntertainment = Double.Parse(txtEntertainment.Text);
            expenses.theGroceries = Double.Parse(txtGroceries.Text);
            expenses.theInvestment = Double.Parse(txtInvestments.Text);
            expenses.thePhone = Double.Parse(txtPhone.Text);
            expenses.theTransport = Double.Parse(txtTTransport.Text);
            expenses.theWater = Double.Parse(txtWater.Text);
            expenses.theTax = Double.Parse(txtTax.Text);

            expenses.theGrossIncome = Double.Parse(txtGross.Text);



            String t = String.Format("{0:C}", expenses.theClothing + expenses.theElectricity +
                expenses.theEntertainment + expenses.theGroceries + expenses.theInvestment + expenses.thePhone +
                expenses.theTax + expenses.theTransport + expenses.theWater);
            txtTotal.Text = t;



            //moneyLeft = expenses.theTotal * expenses.theTax / (1 - 1 / Math.Pow(1 + expenses.thePhone, expenses.theInvestment * 12));

            

        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            /// usefull for task 2 generic collections for storing data
            list = new List<String>(12);
            list.Add("January");
            list.Add("February");
            list.Add("March");
            list.Add("April");
            list.Add("May");
            list.Add("June");
            list.Add("July");
            list.Add("August");
            list.Add("September");
            list.Add("October");
            list.Add("November");
            list.Add("December");
           
            foreach (String item in list)
            {
                cmbMonth.Items.Add(item);
            }
            /// usefull for task 2 generic collections for storing data
            list = new List<String>(31);
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            list.Add("8");
            list.Add("9");
            list.Add("10");
            list.Add("11");
            list.Add("12");
            list.Add("13");
            list.Add("14");
            list.Add("15");
            list.Add("16");
            list.Add("17");
            list.Add("18");
            list.Add("19");
            list.Add("20");
            list.Add("21");
            list.Add("22");
            list.Add("23");
            list.Add("24");
            list.Add("25");
            list.Add("26");
            list.Add("27");
            list.Add("28");
            list.Add("29");
            list.Add("30");
            list.Add("31");
            

            foreach (String item in list)
            {
                cmbDate.Items.Add(item);
            }
            /// usefull for task 2 generic collections for storing data
            list = new List<String>(5);
            list.Add("2021");
            list.Add("2022");
            list.Add("2023");
            list.Add("2024");
            list.Add("2025");
            
            foreach (String item in list)
            {
                cmbYear.Items.Add(item);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnHomeloan_Click(object sender, EventArgs e)
        {
            new House().Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            new Rent().Show();
            this.Hide();
        }

        private void btnExpenses_car_Click(object sender, EventArgs e)
        {
            new Vehicle().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("---------------------------------REPORT---------------------------------------" + "\n");
            richTextBox1.AppendText("Date" + "\t\t" + cmbDate.Text + cmbMonth.Text + cmbYear.Text + "\n");
            richTextBox1.AppendText("Gross Income" + "\t" + txtGross.Text + "\n");
            richTextBox1.AppendText("Clothing" + "\t\t" + txtClothing.Text + "\n");
            richTextBox1.AppendText("Electricity" + "\t\t" + txtElectricity.Text + "\n");
            richTextBox1.AppendText("Entertaiment" + "\t" + txtEntertainment.Text + "\n");
            richTextBox1.AppendText("Groceries" + "\t\t" + txtGroceries.Text + "\n");
            richTextBox1.AppendText("Transport" + "\t\t" + txtTTransport.Text + "\n");
            richTextBox1.AppendText("Investment" + "\t" + txtInvestments.Text + "\n");
            richTextBox1.AppendText("Phone" + "\t\t" + txtPhone.Text + "\n");
            richTextBox1.AppendText("Water" + "\t\t" + txtWater.Text + "\n");
            richTextBox1.AppendText("Tax" + "\t\t" + txtTax.Text + "\n");
            richTextBox1.AppendText("----------------------------------------------------------------------------------");
            richTextBox1.AppendText("Total" + "\t\t" + txtTotal.Text + "\n");
            richTextBox1.AppendText("----------------------------------------------------------------------------------");
        }

        private void btnReset_Click(object sender, EventArgs e)
        { //this will clear everything in the form for the user to start fresh
            txtClothing.Clear();
            txtElectricity.Clear();
            txtEntertainment.Clear();
            txtGroceries.Text = "";
            txtGross.Text = "";
            txtInvestments.Text = "";
            txtPhone.Text = "";
            txtTax.Text = "";
            txtTotal.Clear();
            txtTTransport.Clear();
            txtWater.Clear();
            cmbDate.Text="";
            cmbMonth.Text = "";
            cmbYear.Text = "";
            richTextBox1.Text = "";
           
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            //this button is for importing the report from rich textbox into text files
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files| *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //this button is for exporting the report from rich textbox into text files
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files| *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }
    }
}
