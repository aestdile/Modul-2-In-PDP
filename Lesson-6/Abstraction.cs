
namespace Lesson6InModule2
{
    // Vehicle Task
    public abstract class Vehicle2
    {
        public abstract void Move();
    }
    
    public class Car4 : Vehicle2
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Car is moving on the road"));
            Console.WriteLine();
        }
    }
    
    public class Bike3 : Vehicle2
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Bike is pedaling on the path"));
            Console.WriteLine();
        }
    }
    
    // Shape Task
    public abstract class Shape2
    {
        public abstract double CalculateArea();
    }
    
    public class Square : Shape2
    {
        public double Side { get; set; }
        
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
    
    public class Circle3 : Shape2
    {
        public double Radius { get; set; }
        
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    
    public class Triangle2 : Shape2
    {
        public double Base { get; set; }
        public double Height { get; set; }
        
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
    
    // PaymentGateway Task
    public abstract class PaymentGateway
    {
        public abstract void ProcessPayment(double amount);
    }
    
    public class StripePayment : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Processing ${amount} via Stripe"));
            Console.WriteLine();
        }
    }
    
    public class PayPalPayment2 : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Processing ${amount} via PayPal"));
            Console.WriteLine();
        }
    }
    
    // Database Task
    public abstract class Database
    {
        public abstract void Connect();
        public abstract void StoreData(string data);
        public abstract void Disconnect();
    }
    
    public class MySQLDatabase : Database
    {
        public override void Connect()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Connecting to MySQL database"));
            Console.WriteLine();
        }
        
        public override void StoreData(string data)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Storing '{data}' in MySQL database"));
            Console.WriteLine();
        }
        
        public override void Disconnect()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Disconnecting from MySQL database"));
            Console.WriteLine();
        }
    }
    
    public class MongoDBDatabase : Database
    {
        public override void Connect()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Connecting to MongoDB database"));
            Console.WriteLine();
        }
        
        public override void StoreData(string data)
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Storing '{data}' in MongoDB database"));
            Console.WriteLine();
        }
        
        public override void Disconnect()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Disconnecting from MongoDB database"));
            Console.WriteLine();
        }
    }
    
    // Animal Task
    public abstract class Animal2
    {
        public abstract void Move();
    }
    
    public class Bird : Animal2
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Bird is flying"));
            Console.WriteLine();
        }
    }
    
    public class Fish : Animal2
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Fish is swimming"));
            Console.WriteLine();
        }
    }
    
    public class Mammal : Animal2
    {
        public override void Move()
        {
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered("Mammal is walking"));
            Console.WriteLine();
        }
    }
}