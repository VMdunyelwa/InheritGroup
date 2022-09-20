using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022___InheritanceExample
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string IDNumber { get; set; }
        protected string results;
    }
    class Employee:User
    {
        public double Salary { get; set; }
        
    }
    class CommissionEmployee:Employee
    {
        public double CommissionRate { get; set; }
    }
    class Student:User
    {
        public double Fees { get; set; }
    }
    class PartTimeStudent:Student
    {
        public string Results
        {
            get
            {
                return results;
            }
            set
            {
                results = "Results withheld";
            }
        }
        public double CalculatedFee(double fees)
        {
            double fee = 0;
            this.Fees = fees;
            fee = fees * 0.3;
            return fee;
        }
    }
}
