using System;
using System.Collections.Generic;
List<Employee> employees = new List<Employee>
{
    new Employee("A", "IT", 100000),
    new Employee("B", "IT", 95000),
    new Employee("C", "HR", 85000),
    new Employee("D", "Sales", 70000),
    new Employee("E", "Sales", 50000)
};
Dictionary<string, int> deptSalary = new Dictionary<string, int>();
foreach (Employee emp in employees)
{
    if (deptSalary.ContainsKey(emp.Department))
    {
        deptSalary[emp.Department] += emp.Salary;
    }
    else
    {
        deptSalary[emp.Department] = emp.Salary;
    }
}
string highestDept = "";
int maxSalary = 0;
foreach (var item in deptSalary)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
 
    if (item.Value > maxSalary)
    {
        maxSalary = item.Value;
        highestDept = item.Key;
    }
}
Console.WriteLine($"Highest paying: {highestDept}");
class Employee
{
    public string Name;
    public string Department;
    public int Salary;
    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}