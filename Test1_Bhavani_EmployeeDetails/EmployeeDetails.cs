using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Bhavani_EmployeeDetails
{
    public  class EmployeeDetails
    {
       
        public double HRA { get; set; }
        public double TA { get; set; }
        public double Tax { get; set; }
        public double DA { get; set; }
        public double Salary { get; set; }
        public string EName { get; set; }
        public int Id { get; set; } 
        public string Addres { get; set; }

        public double Netsalary { get; set; }
         public double bonus = 2000;


        public void EmployeeSalaryMethod()
        {
            double bonus = 2000;
            if (Salary < 10000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.1;
                Tax = Salary * 0.1;
                DA = Salary * 0.15;
            }

            else
            {
                HRA = Salary * 0.3;
                TA = Salary * 0.15;
                Tax = Salary * 0.2;
                DA = Salary * 0.2;

            }
            Netsalary = Salary +bonus+ HRA + TA + DA - Tax;
            Console.WriteLine("The Netsalary is :" + Netsalary);
            

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee details is");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Employee name is " + EName);
     

            Console.WriteLine("Employee id  is " +Id);

            Console.WriteLine("Employee address is " + Addres);

            Console.WriteLine("Employee salary is " + Salary);

            Console.WriteLine("Employee bonus is " + bonus);
            Console.WriteLine( "Employee NetSalary is"+Netsalary);



        }

    }
}
