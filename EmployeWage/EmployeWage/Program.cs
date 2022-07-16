//Already using class since starting
using EmployeeWage;
Console.WriteLine("Welcome to employee wage computation program");
IEmployeeWageForCompany details = new Wages();
details.compute("IBM", 30, 18, 80);
details.compute("TATA", 35, 25, 115);