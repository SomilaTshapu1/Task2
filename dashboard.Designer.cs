namespace Car_System
{
    partial class Vehicle
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
            this.llbCar = new System.Windows.Forms.Label();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtImnterest = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.rtreciept = new System.Windows.Forms.RichTextBox();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.btnCarfinance = new System.Windows.Forms.Button();
            this.btnReciept = new System.Windows.Forms.Button();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHomeloan_car = new System.Windows.Forms.Button();
            this.btnRent_car = new System.Windows.Forms.Button();
            this.btnExpenses_car = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbCar
            // 
            this.llbCar.AutoSize = true;
            this.llbCar.Location = new System.Drawing.Point(214, 39);
            this.llbCar.Name = "llbCar";
            this.llbCar.Size = new System.Drawing.Size(93, 20);
            this.llbCar.TabIndex = 1;
            this.llbCar.Text = "Choose Car";
            // 
            // cmbCarType
            // 
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Location = new System.Drawing.Point(374, 31);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(236, 28);
            this.cmbCarType.TabIndex = 2;
            this.cmbCarType.SelectedIndexChanged += new System.EventHandler(this.cmbCarType_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(347, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 41);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.Color.White;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(370, 295);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(240, 32);
            this.lblMonthlyPayment.TabIndex = 35;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.BackColor = System.Drawing.Color.White;
            this.lblTotalPayment.Location = new System.Drawing.Point(370, 351);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(240, 32);
            this.lblTotalPayment.TabIndex = 34;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(535, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 41);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtImnterest
            // 
            this.txtImnterest.Location = new System.Drawing.Point(374, 216);
            this.txtImnterest.Name = "txtImnterest";
            this.txtImnterest.Size = new System.Drawing.Size(236, 26);
            this.txtImnterest.TabIndex = 32;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(374, 161);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(236, 26);
            this.txtPeriod.TabIndex = 31;
            // 
            // rtreciept
            // 
            this.rtreciept.Location = new System.Drawing.Point(733, 3);
            this.rtreciept.Name = "rtreciept";
            this.rtreciept.Size = new System.Drawing.Size(451, 441);
            this.rtreciept.TabIndex = 29;
            this.rtreciept.Text = "";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Location = new System.Drawing.Point(209, 351);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(110, 20);
            this.lblTotalPay.TabIndex = 27;
            this.lblTotalPay.Text = "Total Payment";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(209, 307);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(130, 20);
            this.lblMonthly.TabIndex = 26;
            this.lblMonthly.Text = "Monthly Payment";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(214, 216);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(96, 20);
            this.lblInterest.TabIndex = 25;
            this.lblInterest.Text = "Interest rate";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(214, 161);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(125, 20);
            this.lblYears.TabIndex = 24;
            this.lblYears.Text = "Number of years";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(214, 73);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(115, 20);
            this.lblPurchasePrice.TabIndex = 23;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // btnCarfinance
            // 
            this.btnCarfinance.Location = new System.Drawing.Point(3, 402);
            this.btnCarfinance.Name = "btnCarfinance";
            this.btnCarfinance.Size = new System.Drawing.Size(151, 41);
            this.btnCarfinance.TabIndex = 22;
            this.btnCarfinance.Text = "Capture";
            this.btnCarfinance.UseVisualStyleBackColor = true;
            this.btnCarfinance.Click += new System.EventHandler(this.btnCarfinance_Click);
            // 
            // btnReciept
            // 
            this.btnReciept.Location = new System.Drawing.Point(176, 402);
            this.btnReciept.Name = "btnReciept";
            this.btnReciept.Size = new System.Drawing.Size(149, 42);
            this.btnReciept.TabIndex = 21;
            this.btnReciept.Text = "Reciept";
            this.btnReciept.UseVisualStyleBackColor = true;
            this.btnReciept.Click += new System.EventHandler(this.btnReciept_Click);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(374, 73);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(236, 26);
            this.txtPurchasePrice.TabIndex = 37;
            // 
            // txtTotalDeposit
            // 
            this.txtTotalDeposit.Location = new System.Drawing.Point(374, 119);
            this.txtTotalDeposit.Name = "txtTotalDeposit";
            this.txtTotalDeposit.Size = new System.Drawing.Size(236, 26);
            this.txtTotalDeposit.TabIndex = 39;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(214, 119);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(103, 20);
            this.lblDeposit.TabIndex = 38;
            this.lblDeposit.Text = "Total Deposit";
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(374, 248);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(236, 26);
            this.txtInsurance.TabIndex = 41;
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(214, 248);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(80, 20);
            this.lblInsurance.TabIndex = 40;
            this.lblInsurance.Text = "Insurance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnHomeloan_car);
            this.groupBox1.Controls.Add(this.btnRent_car);
            this.groupBox1.Controls.Add(this.btnExpenses_car);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 273);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 40);
            this.label8.TabIndex = 4;
            this.label8.Text = "Which action would you \r\nlike to perfom next?";
            // 
            // btnHomeloan_car
            // 
            this.btnHomeloan_car.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHomeloan_car.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeloan_car.Location = new System.Drawing.Point(0, 161);
            this.btnHomeloan_car.Name = "btnHomeloan_car";
            this.btnHomeloan_car.Size = new System.Drawing.Size(135, 41);
            this.btnHomeloan_car.TabIndex = 2;
            this.btnHomeloan_car.Text = "House";
            this.btnHomeloan_car.UseVisualStyleBackColor = false;
            this.btnHomeloan_car.Click += new System.EventHandler(this.btnHomeloan_car_Click);
            // 
            // btnRent_car
            // 
            this.btnRent_car.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRent_car.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRent_car.Location = new System.Drawing.Point(0, 116);
            this.btnRent_car.Name = "btnRent_car";
            this.btnRent_car.Size = new System.Drawing.Size(135, 39);
            this.btnRent_car.TabIndex = 1;
            this.btnRent_car.Text = "Rent";
            this.btnRent_car.UseVisualStyleBackColor = false;
            this.btnRent_car.Click += new System.EventHandler(this.btnRent_car_Click);
            // 
            // btnExpenses_car
            // 
            this.btnExpenses_car.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExpenses_car.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpenses_car.Location = new System.Drawing.Point(0, 71);
            this.btnExpenses_car.Name = "btnExpenses_car";
            this.btnExpenses_car.Size = new System.Drawing.Size(135, 39);
            this.btnExpenses_car.TabIndex = 0;
            this.btnExpenses_car.Text = "Expenses";
            this.btnExpenses_car.UseVisualStyleBackColor = false;
            this.btnExpenses_car.Click += new System.EventHandler(this.btnExpenses_car_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(733, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 43;
            this.button1.Text = "Import Textfile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(733, 521);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(170, 37);
            this.btnExport.TabIndex = 45;
            this.btnExport.Text = "Export Textfile";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Which option would you like to perform?";
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.txtTotalDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtImnterest);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.rtreciept);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lblMonthly);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.btnCarfinance);
            this.Controls.Add(this.btnReciept);
            this.Controls.Add(this.cmbCarType);
            this.Controls.Add(this.llbCar);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label llbCar;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtImnterest;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.RichTextBox rtreciept;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Button btnCarfinance;
        private System.Windows.Forms.Button btnReciept;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtTotalDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHomeloan_car;
        private System.Windows.Forms.Button btnRent_car;
        private System.Windows.Forms.Button btnExpenses_car;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
    }
}