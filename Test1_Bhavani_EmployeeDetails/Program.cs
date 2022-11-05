// See https://aka.ms/new-console-template for more information
using Test1_Bhavani_EmployeeDetails;

Console.WriteLine("Hello, World!");
EmployeeDetails obj = new EmployeeDetails();
obj.EmployeeSalaryMethod();
Console.WriteLine("Enter employee name:");
obj.EName = Console.ReadLine();
Console.WriteLine("Enter employee Id:");
obj.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter employee Address:");
obj.Addres = Console.ReadLine();
Console.WriteLine("Enter employee salary:");
obj.Salary = Convert.ToDouble(Console.ReadLine());
obj.EmployeeSalaryMethod();
obj.DisplayEmployeeDetails();
Console.ReadLine();
