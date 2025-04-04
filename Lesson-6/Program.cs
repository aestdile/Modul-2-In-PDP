namespace Lesson6InModule2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();

            DisplayHelper.PrintSection("Encapsulation Tasks", TestEncapsulation);
            DisplayHelper.PrintSection("Inheritance Tasks", TestInheritance);
            DisplayHelper.PrintSection("Polymorphism Tasks", TestPolymorphism);
            DisplayHelper.PrintSection("Abstraction Tasks", TestAbstraction);

            DisplayHelper.PrintFooter();
            Console.WriteLine("\u001b[0m");
        }

        static void TestEncapsulation()
        {
            // BankAccount Task
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(200);
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Balance: {account.GetBalance()}"));
            
            // Student Task
            Student student = new Student();
            student.SetName("Mukhtor");
            student.SetAge(21);
            student.SetGrades(new List<int> { 5, 6, 7 });
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Student: {student.GetName()}, Age: {student.GetAge()}, Average Grade: {student.CalculateAverage():F2}"));
            Console.WriteLine();

            // Car Task
            Car car = new Car();
            car.SetSpeed(60);
            car.SetFuelLevel(45);
            car.Accelerate(20);
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Car speed: {car.GetSpeed()}, Fuel level: {car.GetFuelLevel()}"));
            Console.WriteLine();
            
            // PasswordManager Task
            PasswordManager passwordManager = new PasswordManager();
            passwordManager.AddPassword("Email", "securepass123");
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Email password exists: {passwordManager.CheckPasswordExists("Email")}"));
            Console.WriteLine();
            
            // TemperatureConverter Task
            TemperatureConverter tempConverter = new TemperatureConverter();
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"30°C to Fahrenheit: {tempConverter.CelsiusToFahrenheit(30)}°F"));
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"86°F to Celsius: {tempConverter.FahrenheitToCelsius(86)}°C"));
            Console.WriteLine();
        }
        
        static void TestInheritance()
        {
            // Employee  Task
            Manager manager = new Manager();
            manager.Name = "Muhammad Abdulloh";
            manager.ID = 101;
            manager.Salary = 5000;
            manager.Department = "IT";
            
            Developer developer = new Developer();
            developer.Name = "Mukhtor";
            developer.ID = 102;
            developer.Salary = 4000;
            developer.ProgrammingLanguage = "C#";
            
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Manager: {manager.Name}, Department: {manager.Department}"));
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Developer: {developer.Name}, Language: {developer.ProgrammingLanguage}"));
            Console.WriteLine();
            
            // Shape Task
            Circle circle = new Circle { Radius = 5 };
            Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Circle area: {circle.CalculateArea():F2}"));
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Rectangle area: {rectangle.CalculateArea()}"));
            Console.WriteLine();
            
            // Animal Task
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.MakeSound();
            cat.MakeSound();
            
            // Vehicle Task
            Car2 car2 = new Car2();
            Bike bike = new Bike();
            car2.Move();
            bike.Move();
            
            // SchoolMember Task
            Teacher teacher = new Teacher { Name = "Muhammad Abdulloh", Subject = "C# Programming language"};
            Student2 student2 = new Student2 { Name = "Mukhtor", Grade = "100"};
            teacher.DisplayInfo();
            student2.DisplayInfo();
        }
        
        static void TestPolymorphism()
        {
            // Shape Task
            List<Shape> shapes = new List<Shape>
            {
                new Circle2 { Radius = 3 },
                new Rectangle2 { Width = 4, Height = 5 },
                new Triangle { Base = 6, Height = 8 }
            };

            foreach (var shape in shapes)
            {
                GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Shape area: {shape.CalculateArea():F2}"));
            }
            Console.WriteLine();
            
            // Animal Task
            Animal dog2 = new Dog2();
            Animal cat2 = new Cat2();
            dog2.MakeSound();
            cat2.MakeSound();
            
            // Payment Task
            List<Payment> payments = new List<Payment>
            {
                new CreditCardPayment { CardNumber = ": 9860 1201 1408 0100" },
                new PayPalPayment { Email = "aestdile@gmail.com" },
                new BankTransferPayment { AccountNumber = "+998-77-267-27-74" }
            };
            
            foreach (var payment in payments)
            {
                payment.ProcessPayment(100);
            }
            
            // Employee Task
            List<Employee2> employees = new List<Employee2>
            {
                new Manager2 { Name = "Muhammad Abdulloh", BaseSalary = 5000, Bonus = 1000 },
                new Developer2 { Name = "Mukhtor", BaseSalary = 4000, OvertimeHours = 8 },
                new Intern { Name = "Nicola", BaseSalary = 1500, SchoolCredit = 500 }
            };
            
            foreach (var emp in employees)
            {
                GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"{emp.Name}'s salary: {emp.CalculateSalary()}"));
            }
            Console.WriteLine();
            
            // Transport Task
            List<Transport> transports = new List<Transport>
            {
                new Car3 { Speed = 80 },
                new Bike2 { Speed = 25 },
                new Bus { Speed = 60 }
            };
            
            foreach (var transport in transports)
            {
                GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Travel time for 100 km: {transport.CalculateTime(100):F2} hours"));
            }
            Console.WriteLine();
        }
        
        static void TestAbstraction()
        {
            // Vehicle Task
            Vehicle2 carVehicle = new Car4();
            Vehicle2 bikeVehicle = new Bike3();
            carVehicle.Move();
            bikeVehicle.Move();
            
            // Shape Task
            Shape2 square = new Square { Side = 5 };
            Shape2 circle3 = new Circle3 { Radius = 3 };
            Shape2 triangle2 = new Triangle2 { Base = 4, Height = 6 };
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Square area: {square.CalculateArea()}"));
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Circle area: {circle3.CalculateArea():F2}"));
            GradientPrinter.PrintGradientResult(GradientPrinter.StringCentered($"Triangle area: {triangle2.CalculateArea()}"));
            Console.WriteLine();
            
            // PaymentGateway Task
            PaymentGateway stripePayment = new StripePayment();
            PaymentGateway paypalPayment2 = new PayPalPayment2();
            stripePayment.ProcessPayment(200);
            paypalPayment2.ProcessPayment(150);
            
            // Database Task
            Database mySqlDb = new MySQLDatabase();
            Database mongoDb = new MongoDBDatabase();
            mySqlDb.Connect();
            mySqlDb.StoreData("user data");
            mySqlDb.Disconnect();
            mongoDb.Connect();
            mongoDb.StoreData("product data");
            mongoDb.Disconnect();
            
            // Animal Task
            Animal2 bird = new Bird();
            Animal2 fish = new Fish();
            Animal2 mammal = new Mammal();
            bird.Move();
            fish.Move();
            mammal.Move();
        }
    }
}







