using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;


namespace EmployeeNamespace
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName { set { first_name = value; } get { return first_name;  } }
        public string LastName { set { last_name = value; } get { return last_name; } } 
        public string Department { set { department = value; } get { return department;  } }
        public string JobTitle { set { job_title = value; } get { return job_title; } }
        public double BasicSalary { set { basic_salary = value; } get { return this.basic_salary; } }
        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept; 
            this.job_title = job;
        }
        
        public void computeSalary(int hoursWorked, double ratePerHour) 
        { 
            BasicSalary = hoursWorked * ratePerHour;
        }
        public double getSalary() 
        {
            return BasicSalary;
        }       

    }
}
