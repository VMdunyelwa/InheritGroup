using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022___InheritanceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            double sal = 10000;
            double com = sal * 0.25;
            CommissionEmployee emp = new CommissionEmployee();
            //User has 4 properties (name, surname, ID, dob)
            emp.Name = "Vuyo";
            emp.Surname = "Mdunyelwa";
            emp.DOB = "29 March 2000";
            emp.IDNumber = "0002859858555";
            emp.Salary = sal;
            emp.CommissionRate = com;
            lblName.Text = emp.Name;
            lblSurname.Text = emp.Surname;
            lblDob.Text = emp.DOB;
            lblID.Text = emp.IDNumber;
            //Empoyee has 1 property (Salary)
            lblSalaryFee.Text = emp.Salary.ToString("C");
            //Commission Employee has 1 property (Commission Rate)
            lblComCalc.Text = emp.CommissionRate.ToString("C");
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            PartTimeStudent part = new PartTimeStudent();
            double fee = 10000;
            double calcRate = 0;
            //User has 4 properties (name, surname, ID, dob)
            part.Name = "Vuyo";
            part.Surname = "Mdunyelwa";
            part.DOB = "29 March 2000";
            part.IDNumber = "0002859858555";
            part.Fees = fee;
            calcRate = part.CalculatedFee(fee);


            lblName.Text = part.Name;
            lblSurname.Text = part.Surname;
            lblDob.Text = part.DOB;
            lblID.Text = part.IDNumber;
            //Student had 1 property (Fees)
            lblSalaryFee.Text = part.Fees.ToString("C");
            //Part Time student has 1 method (Calculated rate)
            lblComCalc.Text = calcRate.ToString("C");
        }
    }
}
