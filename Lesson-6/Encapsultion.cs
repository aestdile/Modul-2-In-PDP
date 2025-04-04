
namespace Lesson6InModule2
{
    // BankAccount Task
    public class BankAccount
    {
        private double balance;
        
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }
        
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }
        
        public double GetBalance()
        {
            return balance;
        }
    }
    
    // Student Task
    public class Student
    {
        private string name;
        private int age;
        private List<int> grades;
        
        public void SetName(string name)
        {
            this.name = name;
        }
        
        public string GetName()
        {
            return name;
        }
        
        public void SetAge(int age)
        {
            if (age > 0)
                this.age = age;
        }
        
        public int GetAge()
        {
            return age;
        }
        
        public void SetGrades(List<int> grades)
        {
            this.grades = grades;
        }
        
        public double CalculateAverage()
        {
            if (grades == null || grades.Count == 0)
                return 0;
                
            int sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            
            return (double)sum / grades.Count;
        }
    }
    
    // Car Task
    public class Car
    {
        private int speed;
        private double fuelLevel;
        
        public void SetSpeed(int speed)
        {
            if (speed >= 0)
                this.speed = speed;
        }
        
        public int GetSpeed()
        {
            return speed;
        }
        
        public void SetFuelLevel(double fuelLevel)
        {
            if (fuelLevel >= 0 && fuelLevel <= 100)
                this.fuelLevel = fuelLevel;
        }
        
        public double GetFuelLevel()
        {
            return fuelLevel;
        }
        
        public void Accelerate(int amount)
        {
            if (fuelLevel > 0)
            {
                speed += amount;
                fuelLevel -= amount * 0.1;
            }
        }
    }
    
    // PasswordManager Task
    public class PasswordManager
    {
        private Dictionary<string, string> passwords = new Dictionary<string, string>();
        
        public void AddPassword(string account, string password)
        {
            passwords[account] = password;
        }
        
        public bool CheckPasswordExists(string account)
        {
            return passwords.ContainsKey(account);
        }
        
        public bool ValidatePassword(string account, string password)
        {
            if (passwords.ContainsKey(account))
                return passwords[account] == password;
            return false;
        }
    }
    
    // TemperatureConverter Task
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9/5) + 32;
        }
        
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }
    }
}
