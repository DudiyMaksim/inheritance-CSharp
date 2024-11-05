namespace inheritance
{

    internal class Money
    {
        public int Whole_part;
        public int Partial_part;

        public void PrintMoney()
        {
            Console.WriteLine(Whole_part + "." + Partial_part);
        }
    }
    internal class Product : Money
    {
        public void increaseMoney(string amount)
        {
            if (amount.IndexOf(".") > -1)
            {
                Whole_part += int.Parse(amount.Split(".")[0]);
                Partial_part += int.Parse(amount.Split(".")[1]);
            }
            else {
                Whole_part += int.Parse(amount);
            }
        }
        public void ReduceMoney(string amount)
        {
            if (amount.IndexOf(".") > -1)
            {
                Whole_part -= int.Parse(amount.Split(".")[0]);
                Partial_part -= int.Parse(amount.Split(".")[1]);
            }
            else
            {
                Whole_part -= int.Parse(amount);
            }
        }
    }




    internal class Device
    {
        public string name;
        public string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Sound of dievice");
        }
        public virtual void Show()
        {
            Console.WriteLine(name);
        }
        public virtual void Desc()
        {
            Console.WriteLine(description);
        }
    }

    internal class Kettle : Device
    {
        public Kettle() : base("Electric Kettle", "A kettle for boiling water.")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("The kettle started to whistle");
        }
    }
    internal class Microwave : Device
    {
        public Microwave() : base("Microwave Oven", "An appliance for heating food.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Wuuuuuuuuuuuuuuuu");
        }
    }
    internal class Car : Device
    {
        public Car() : base("Sedan", "A comfortable car.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("WRRRRRRRRRR");
        }
    }
    internal class Steamboat : Device
    {
        public Steamboat() : base("River Steamboat", "A boat powered by steam.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("choo-choo");
        }
    }



    abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine($"President: {Name}, Age: {Age}, Responsibilities: Setting vision and strategy.");
        }
    }
    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine($"Security: {Name}, Age: {Age}, Responsibilities: Ensuring safety and security.");
        }
    }
    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Responsibilities: Overseeing team performance and projects.");
        }
    }
    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine($"Engineer: {Name}, Age: {Age}, Responsibilities: Designing and implementing systems.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ////task 1
            //Product product = new Product();

            //product.Whole_part = 25;
            //product.Partial_part = 69;
            //product.PrintMoney();
            //product.increaseMoney("10.2");
            //product.PrintMoney();
            ////task 2
            //Kettle kettle = new Kettle();
            //Microwave microwave = new Microwave();
            //Car car = new Car();
            //Steamboat teamboat = new Steamboat();

            //Device[] devices = new Device[4];
            //devices[0] = kettle;
            //devices[1] = microwave;
            //devices[2] = car;
            //devices[3] = teamboat;

            //foreach (Device device in devices) {
            //    device.Show();
            //    device.Desc();
            //    device.Sound();
            //    Console.WriteLine();
            //}
            ////task 4
            //Worker president = new President { Name = "Alice", Age = 50 };
            //Worker security = new Security { Name = "Bob", Age = 35 };
            //Worker manager = new Manager { Name = "Charlie", Age = 40 };
            //Worker engineer = new Engineer { Name = "David", Age = 30 };

            //president.Print();
            //security.Print();
            //manager.Print();
            //engineer.Print();
        }
    }
}
