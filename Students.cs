using System;
Student s = new Student("Amit", 20, 101);
Teacher t = new Teacher("Priya", 35, "C#");
s.ShowDetails();
t.ShowDetails();
class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"{Name}, {Age}");
    }
}
class Student : Person
{
    public int RollNumber;
    public Student(string name, int age, int rollNumber)
        : base(name, age)
    {
        RollNumber = rollNumber;
    }
}
class Teacher : Person{
    public string Subject;
    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }
}