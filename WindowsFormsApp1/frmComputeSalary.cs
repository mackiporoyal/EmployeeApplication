using System;
using EmployeeNamespace;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace WindowsFormsApp1
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtRatePerHour = new System.Windows.Forms.TextBox();
            this.txtTotalHoursWorked = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(243, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(22, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(218, 26);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.Location = new System.Drawing.Point(246, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 26);
            this.txtLastName.TabIndex = 13;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepartment.Location = new System.Drawing.Point(22, 159);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(218, 26);
            this.txtDepartment.TabIndex = 14;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJobTitle.Location = new System.Drawing.Point(246, 159);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(218, 26);
            this.txtJobTitle.TabIndex = 15;
            // 
            // txtRatePerHour
            // 
            this.txtRatePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRatePerHour.Location = new System.Drawing.Point(22, 234);
            this.txtRatePerHour.Name = "txtRatePerHour";
            this.txtRatePerHour.Size = new System.Drawing.Size(218, 26);
            this.txtRatePerHour.TabIndex = 16;
            // 
            // txtTotalHoursWorked
            // 
            this.txtTotalHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalHoursWorked.Location = new System.Drawing.Point(245, 234);
            this.txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            this.txtTotalHoursWorked.Size = new System.Drawing.Size(218, 26);
            this.txtTotalHoursWorked.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(248, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "*Job Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(25, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "*Rate per hour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(249, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Total hours worked:";
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompute.Location = new System.Drawing.Point(177, 266);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(149, 39);
            this.btnCompute.TabIndex = 21;
            this.btnCompute.Text = "Compute Salary";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(25, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(25, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Last Name: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(143, 345);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(133, 20);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "<first name here>";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.Location = new System.Drawing.Point(143, 384);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(132, 20);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "<last name here>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(179, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 26;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBasicSalary.Location = new System.Drawing.Point(144, 420);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(49, 20);
            this.lblBasicSalary.TabIndex = 28;
            this.lblBasicSalary.Text = "00.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(26, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Basic Salary:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Desktop;
            this.label10.ForeColor = System.Drawing.Color.FloralWhite;
            this.label10.Location = new System.Drawing.Point(25, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Sales.Corp";
            // 
            // frmComputeSalary
            // 
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(511, 473);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalHoursWorked);
            this.Controls.Add(this.txtRatePerHour);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Application";
            this.Load += new System.EventHandler(this.frmComputeSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string dept = txtDepartment.Text;
            string jTitle = txtJobTitle.Text;
            double rPerHour = Convert.ToDouble(txtRatePerHour.Text);
            int THoursWorked = Convert.ToInt32(txtTotalHoursWorked.Text);
            double salary;
            PartTimeEmployee getEmployee = new PartTimeEmployee(fName, lName, dept, jTitle);
            getEmployee.computeSalary(THoursWorked, rPerHour);


            salary = getEmployee.getSalary();
            lblBasicSalary.Text = salary.ToString();
            lblFirstName.Text = getEmployee.FirstName;
            lblLastName.Text = getEmployee.LastName;
        }
    }
}
