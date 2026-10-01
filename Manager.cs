// 5 Extending rather than replacing
// Create Employee with Name and Salary and a virtual ShowDetails(). Derive Manager
// adding TeamSize, whose ShowDetails prints everything the base version prints and then the
// team size — without duplicating the base code.
 
using System;
public class Employee
{
    public string Name;
    public double Salary;
 
    public virtual void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}
 
class Manager : Employee{
    public int TeamSize;
    public override void ShowDetails(){
        base.ShowDetails();
        Console.WriteLine($"TeamSize: {TeamSize}");
    }
 
}
 
class Program{
    static void Main(){
        Manager m = new Manager();
        m.Name = "Priya";
        m.Salary = 90000;
        m.TeamSize = 6;
        m.ShowDetails();
    }
}