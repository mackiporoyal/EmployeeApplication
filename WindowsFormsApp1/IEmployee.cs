using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeInterface
{
    public interface IEmployee
    {

        string FirstName { set; get; }
        string LastName { set; get; }
        string Department { set; get; }
        string JobTitle { set; get; }
        double BasicSalary { set; get; }
        void computeSalary(int hoursWorked, double ratePerHour);
    }
}
