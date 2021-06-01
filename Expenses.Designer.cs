namespace Car_System
{
    partial class Expenses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHomeloan = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnExpenses_car = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.txtGroceries = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.lblWater = new System.Windows.Forms.Label();
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTTransport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntertainment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClothing = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvestments = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMoneyleft = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnHomeloan);
            this.groupBox1.Controls.Add(this.btnRent);
            this.groupBox1.Controls.Add(this.btnExpenses_car);
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 301);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 40);
            this.label13.TabIndex = 9;
            this.label13.Text = "Which action would you \r\nlike to perfom next?";
            // 
            // btnHomeloan
            // 
            this.btnHomeloan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHomeloan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeloan.Location = new System.Drawing.Point(0, 179);
            this.btnHomeloan.Name = "btnHomeloan";
            this.btnHomeloan.Size = new System.Drawing.Size(135, 41);
            this.btnHomeloan.TabIndex = 7;
            this.btnHomeloan.Text = "House";
            this.btnHomeloan.UseVisualStyleBackColor = false;
            this.btnHomeloan.Click += new System.EventHandler(this.btnHomeloan_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRent.Location = new System.Drawing.Point(0, 134);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(135, 39);
            this.btnRent.TabIndex = 6;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnExpenses_car
            // 
            this.btnExpenses_car.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExpenses_car.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpenses_car.Location = new System.Drawing.Point(0, 89);
            this.btnExpenses_car.Name = "btnExpenses_car";
            this.btnExpenses_car.Size = new System.Drawing.Size(135, 39);
            this.btnExpenses_car.TabIndex = 5;
            this.btnExpenses_car.Text = "Car";
            this.btnExpenses_car.UseVisualStyleBackColor = false;
            this.btnExpenses_car.Click += new System.EventHandler(this.btnExpenses_car_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(457, 98);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(135, 28);
            this.cmbMonth.TabIndex = 33;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(398, 106);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(54, 20);
            this.Month.TabIndex = 34;
            this.Month.Text = "Month";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(377, 142);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(142, 26);
            this.txtGross.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Gross Income";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(183, 391);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(130, 42);
            this.btnCapture.TabIndex = 37;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtGroceries
            // 
            this.txtGroceries.Location = new System.Drawing.Point(372, 178);
            this.txtGroceries.Name = "txtGroceries";
            this.txtGroceries.Size = new System.Drawing.Size(147, 26);
            this.txtGroceries.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Groceries";
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(660, 143);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(135, 26);
            this.txtWater.TabIndex = 41;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(548, 146);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(52, 20);
            this.lblWater.TabIndex = 42;
            this.lblWater.Text = "Water";
            // 
            // txtElectricity
            // 
            this.txtElectricity.Location = new System.Drawing.Point(372, 210);
            this.txtElectricity.Name = "txtElectricity";
            this.txtElectricity.Size = new System.Drawing.Size(147, 26);
            this.txtElectricity.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Electricity";
            // 
            // txtTTransport
            // 
            this.txtTTransport.Location = new System.Drawing.Point(660, 178);
            this.txtTTransport.Name = "txtTTransport";
            this.txtTTransport.Size = new System.Drawing.Size(135, 26);
            this.txtTTransport.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Transport";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(374, 337);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(144, 26);
            this.txtTax.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = " Monthly Tax";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(369, 251);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 26);
            this.txtPhone.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 40);
            this.label3.TabIndex = 50;
            this.label3.Text = "Cellphone/\r\nTelephone";
            // 
            // txtEntertainment
            // 
            this.txtEntertainment.Location = new System.Drawing.Point(663, 213);
            this.txtEntertainment.Name = "txtEntertainment";
            this.txtEntertainment.Size = new System.Drawing.Size(132, 26);
            this.txtEntertainment.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Entertainment";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(663, 299);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 26);
            this.txtTotal.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Total";
            // 
            // txtClothing
            // 
            this.txtClothing.Location = new System.Drawing.Point(369, 296);
            this.txtClothing.Name = "txtClothing";
            this.txtClothing.Size = new System.Drawing.Size(149, 26);
            this.txtClothing.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Clothing";
            // 
            // txtInvestments
            // 
            this.txtInvestments.Location = new System.Drawing.Point(663, 252);
            this.txtInvestments.Name = "txtInvestments";
            this.txtInvestments.Size = new System.Drawing.Size(132, 26);
            this.txtInvestments.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Investments";
            // 
            // txtMoneyleft
            // 
            this.txtMoneyleft.Location = new System.Drawing.Point(660, 337);
            this.txtMoneyleft.Name = "txtMoneyleft";
            this.txtMoneyleft.ReadOnly = true;
            this.txtMoneyleft.Size = new System.Drawing.Size(135, 26);
            this.txtMoneyleft.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(547, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "Money Left";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(823, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 328);
            this.richTextBox1.TabIndex = 63;
            this.richTextBox1.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(247, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "Date";
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(303, 100);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(83, 28);
            this.cmbDate.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(674, 103);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 28);
            this.cmbYear.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 68;
            this.button1.Text = "Reciept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(493, 391);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 41);
            this.btnReset.TabIndex = 69;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(646, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 41);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(874, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(327, 20);
            this.label14.TabIndex = 73;
            this.label14.Text = "Which option would you like to perform?";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(878, 467);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(170, 37);
            this.btnExport.TabIndex = 72;
            this.btnExport.Text = "Export Textfile";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(878, 424);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(170, 37);
            this.btnImport.TabIndex = 71;
            this.btnImport.Text = "Import Textfile";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 681);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMoneyleft);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInvestments);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtClothing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEntertainment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTTransport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtElectricity);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroceries);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.cmbMonth);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHomeloan;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnExpenses_car;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox txtGroceries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTTransport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntertainment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClothing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvestments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMoneyleft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}