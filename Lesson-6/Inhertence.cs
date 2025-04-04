
namespace Lesson6InModule2
{
    // Employee Task
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }
        
        public void DisplayInfo()
        {
           GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Employee: {Name}, ID: {ID}, Salary: {Salary}"));
        }
    }
    
    public class Manager : Employee
    {
        public string Department { get; set; }
        
        public void AssignTasks()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"{Name} is assigning tasks for the {Department} department"));
        }
    }
    
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        
        public void WriteCode()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"{Name} is writing {ProgrammingLanguage} code"));
        }
    }
    
    // Shape Task
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
    
    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    
    // Animal Task
    public class Animal
    {
        public string Name { get; set; }
        
        public virtual void MakeSound()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Animal makes a sound"));
            Console.WriteLine();
        }
    }
    
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Dog barks: Woof! Woof!"));
            Console.WriteLine();
        }
    }
    
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Cat meows: Meow!"));
            Console.WriteLine();
        }
    }
    
    // Vehicle Task
    public class Vehicle
    {
        public int Speed { get; set; }
        
        public virtual void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Vehicle is moving"));
            Console.WriteLine();
        }
    }
    
    public class Car2 : Vehicle
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Car is driving on the road"));
            Console.WriteLine();
        }
    }
    
    public class Bike : Vehicle
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Bike is pedaling on the path"));
            Console.WriteLine();
        }
    }
    
    // SchoolMember Task
    public class SchoolMember
    {
        public string Name { get; set; }
        
        public virtual void DisplayInfo()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"School member: {Name}"));
            Console.WriteLine();
        }
    }
    
    public class Teacher : SchoolMember
    {
        public string Subject { get; set; }
        
        public override void DisplayInfo()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Teacher: {Name}, Subject: {Subject}"));
            Console.WriteLine();
        }
    }
    
    public class Student2 : SchoolMember
    {
        public string Grade { get; set; }
        
        public override void DisplayInfo()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Student: {Name}, Grade: {Grade}"));
            Console.WriteLine();
        }
    }   
}