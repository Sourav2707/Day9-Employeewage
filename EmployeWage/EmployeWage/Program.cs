//Already using class since starting
using EmployeeWage;
Console.WriteLine("Welcome to employee wage computation program");
Emp emp = new Emp();
Console.WriteLine("Enter the company name");
string comp = Console.ReadLine();
Console.WriteLine("Enter wage per day");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the total working days");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the total working hours");
int c = Convert.ToInt32(Console.ReadLine());
emp.Wage(comp, a, b, c);