namespace Car_System
{
    partial class Rent
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
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nudRoom = new System.Windows.Forms.ComboBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCapture_rent = new System.Windows.Forms.Button();
            this.rtReciept = new System.Windows.Forms.RichTextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtWaterBill = new System.Windows.Forms.TextBox();
            this.txtlocaltax = new System.Windows.Forms.TextBox();
            this.txtelectricity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbYear_rent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonth_rent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDate_rent = new System.Windows.Forms.ComboBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHomeloan = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnReciept = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(153, 499);
            this.txtTest.Name = "txtTest";
            this.txtTest.ReadOnly = true;
            this.txtTest.Size = new System.Drawing.Size(173, 26);
            this.txtTest.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 536);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Number of Rooms";
            // 
            // nudRoom
            // 
            this.nudRoom.FormattingEnabled = true;
            this.nudRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.nudRoom.Location = new System.Drawing.Point(153, 256);
            this.nudRoom.Name = "nudRoom";
            this.nudRoom.Size = new System.Drawing.Size(154, 28);
            this.nudRoom.TabIndex = 17;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Green Acres",
            "Algoa",
            "Peridgeville",
            "New Brighton",
            "KwaDwesi",
            "Motherwell",
            "Newton Park",
            "Zwide",
            "KwaMagxaki"});
            this.cmbLocation.Location = new System.Drawing.Point(153, 110);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(146, 28);
            this.cmbLocation.TabIndex = 16;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(153, 182);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(154, 26);
            this.txtCost.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Location";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cost";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(272, 536);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 43);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCapture_rent
            // 
            this.btnCapture_rent.Location = new System.Drawing.Point(7, 537);
            this.btnCapture_rent.Name = "btnCapture_rent";
            this.btnCapture_rent.Size = new System.Drawing.Size(109, 42);
            this.btnCapture_rent.TabIndex = 14;
            this.btnCapture_rent.Text = "Capture";
            this.btnCapture_rent.UseVisualStyleBackColor = true;
            this.btnCapture_rent.Click += new System.EventHandler(this.btnCapture_rent_Click);
            // 
            // rtReciept
            // 
            this.rtReciept.Location = new System.Drawing.Point(840, 49);
            this.rtReciept.Name = "rtReciept";
            this.rtReciept.Size = new System.Drawing.Size(446, 412);
            this.rtReciept.TabIndex = 13;
            this.rtReciept.Text = "";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(153, 459);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(173, 26);
            this.txtTotal.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 456);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "Total Payment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(158, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 42);
            this.label18.TabIndex = 13;
            this.label18.Text = "Utility Bills";
            // 
            // txtWaterBill
            // 
            this.txtWaterBill.Location = new System.Drawing.Point(153, 421);
            this.txtWaterBill.Name = "txtWaterBill";
            this.txtWaterBill.Size = new System.Drawing.Size(173, 26);
            this.txtWaterBill.TabIndex = 12;
            // 
            // txtlocaltax
            // 
            this.txtlocaltax.Location = new System.Drawing.Point(153, 378);
            this.txtlocaltax.Name = "txtlocaltax";
            this.txtlocaltax.Size = new System.Drawing.Size(173, 26);
            this.txtlocaltax.TabIndex = 11;
            // 
            // txtelectricity
            // 
            this.txtelectricity.Location = new System.Drawing.Point(153, 345);
            this.txtelectricity.Name = "txtelectricity";
            this.txtelectricity.Size = new System.Drawing.Size(173, 26);
            this.txtelectricity.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Water Bill";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Local Tax";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 345);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Electricity";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReciept);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.cmbYear_rent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.cmbMonth_rent);
            this.panel2.Controls.Add(this.btnCapture_rent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbDate_rent);
            this.panel2.Controls.Add(this.txtTest);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtDeposit);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.nudRoom);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.cmbLocation);
            this.panel2.Controls.Add(this.txtWaterBill);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtlocaltax);
            this.panel2.Controls.Add(this.txtelectricity);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtPostalCode);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(263, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 631);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date";
            // 
            // cmbYear_rent
            // 
            this.cmbYear_rent.FormattingEnabled = true;
            this.cmbYear_rent.Location = new System.Drawing.Point(448, 42);
            this.cmbYear_rent.Name = "cmbYear_rent";
            this.cmbYear_rent.Size = new System.Drawing.Size(99, 28);
            this.cmbYear_rent.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Month";
            // 
            // cmbMonth_rent
            // 
            this.cmbMonth_rent.FormattingEnabled = true;
            this.cmbMonth_rent.Location = new System.Drawing.Point(284, 43);
            this.cmbMonth_rent.Name = "cmbMonth_rent";
            this.cmbMonth_rent.Size = new System.Drawing.Size(99, 28);
            this.cmbMonth_rent.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date";
            // 
            // cmbDate_rent
            // 
            this.cmbDate_rent.FormattingEnabled = true;
            this.cmbDate_rent.Location = new System.Drawing.Point(153, 43);
            this.cmbDate_rent.Name = "cmbDate_rent";
            this.cmbDate_rent.Size = new System.Drawing.Size(67, 28);
            this.cmbDate_rent.TabIndex = 34;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(153, 224);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(154, 26);
            this.txtDeposit.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Deposit";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(153, 150);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(154, 26);
            this.txtPostalCode.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(153, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 26);
            this.txtAddress.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Postal Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnHomeloan);
            this.groupBox1.Controls.Add(this.btnExpenses);
            this.groupBox1.Controls.Add(this.btnCar);
            this.groupBox1.Location = new System.Drawing.Point(10, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 283);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 40);
            this.label9.TabIndex = 14;
            this.label9.Text = "Which action would you \r\nlike to perfom next?";
            // 
            // btnHomeloan
            // 
            this.btnHomeloan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHomeloan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeloan.Location = new System.Drawing.Point(23, 170);
            this.btnHomeloan.Name = "btnHomeloan";
            this.btnHomeloan.Size = new System.Drawing.Size(135, 41);
            this.btnHomeloan.TabIndex = 12;
            this.btnHomeloan.Text = "House";
            this.btnHomeloan.UseVisualStyleBackColor = false;
            this.btnHomeloan.Click += new System.EventHandler(this.btnHomeloan_rent_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpenses.Location = new System.Drawing.Point(23, 125);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(135, 39);
            this.btnExpenses.TabIndex = 11;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnRent_rent_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCar.Location = new System.Drawing.Point(23, 80);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(135, 39);
            this.btnCar.TabIndex = 10;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnExpenses_car_Click);
            // 
            // btnReciept
            // 
            this.btnReciept.Location = new System.Drawing.Point(131, 536);
            this.btnReciept.Name = "btnReciept";
            this.btnReciept.Size = new System.Drawing.Size(132, 42);
            this.btnReciept.TabIndex = 40;
            this.btnReciept.Text = "Reciept";
            this.btnReciept.UseVisualStyleBackColor = true;
            this.btnReciept.Click += new System.EventHandler(this.btnReciept_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(836, 486);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(327, 20);
            this.label14.TabIndex = 115;
            this.label14.Text = "Which option would you like to perform?";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(840, 552);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(170, 37);
            this.btnExport.TabIndex = 114;
            this.btnExport.Text = "Export Textfile";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(840, 509);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(170, 37);
            this.btnImport.TabIndex = 113;
            this.btnImport.Text = "Import Textfile";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 681);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtReciept);
            this.Controls.Add(this.panel2);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox nudRoom;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCapture_rent;
        private System.Windows.Forms.RichTextBox rtReciept;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtWaterBill;
        private System.Windows.Forms.TextBox txtlocaltax;
        private System.Windows.Forms.TextBox txtelectricity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYear_rent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonth_rent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDate_rent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHomeloan;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnReciept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}