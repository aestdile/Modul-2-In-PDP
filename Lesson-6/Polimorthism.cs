
namespace Lesson6InModule2

{
    // Shape Task
    public class Circle2 : Shape
    {
        public double Radius { get; set; }
        
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    
    public class Rectangle2 : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
    
    // Animal Task
    public class Dog2 : Animal
    {
        public override void MakeSound()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Dog barks"));
            Console.WriteLine();
        }
    }
    
    public class Cat2 : Animal
    {
        public override void MakeSound()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Cat meows"));
            Console.WriteLine();
        }
    }
    
    // Payment Task
    public class Payment
    {
        public virtual void ProcessPayment(double amount)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Processing payment of ${amount}"));
            Console.WriteLine();
        }
    }
    
    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        
        public override void ProcessPayment(double amount)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Processing credit card payment of ${amount} with card {CardNumber}"));
            Console.WriteLine();
        }
    }
    
    public class PayPalPayment : Payment
    {
        public string Email { get; set; }
        
        public override void ProcessPayment(double amount)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Processing PayPal payment of ${amount} with account {Email}"));
            Console.WriteLine();
        }
    }
    
    public class BankTransferPayment : Payment
    {
        public string AccountNumber { get; set; }
        
        public override void ProcessPayment(double amount)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Processing bank transfer of ${amount} to account {AccountNumber}"));
            Console.WriteLine();
        }
    }
    
    // Employee Task
    public class Employee2
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        
        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }
    
    public class Manager2 : Employee2
    {
        public double Bonus { get; set; }
        
        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }
    }
    
    public class Developer2 : Employee2
    {
        public int OvertimeHours { get; set; }
        
        public override double CalculateSalary()
        {
            return BaseSalary + (OvertimeHours * 25);
        }
    }
    
    public class Intern : Employee2
    {
        public double SchoolCredit { get; set; }
        
        public override double CalculateSalary()
        {
            return BaseSalary + SchoolCredit;
        }
    }
    
    // Transport Task
    public class Transport
    {
        public double Speed { get; set; }
        
        public virtual double CalculateTime(double distance)
        {
            if (Speed == 0) return 0;
            return distance / Speed;
        }
    }
    
    public class Car3 : Transport
    {
        public override double CalculateTime(double distance)
        {
            return (distance / Speed) * 1.1;
        }
    }
    
    public class Bike2 : Transport
    {
        public override double CalculateTime(double distance)
        {
            return (distance / Speed) * 1.2;
        }
    }
    
    public class Bus : Transport
    {
        public override double CalculateTime(double distance)
        {
            return (distance / Speed) * 1.3;
        }
    }
}