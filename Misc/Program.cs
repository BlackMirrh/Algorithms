using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

delegate T NumberChanger<T>(T n);
namespace Misc
{
    class Complex
    {
        private double re, im;

        public double Real
        {
            get { return re; }
            set { re = value; }
        }

        public double Imaginary
        {
            get { return im; }
            set { im = value; }
        }

        // binary operator overloading
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex() { Real = c1.Real + c2.Real, Imaginary = c1.Imaginary + c2.Imaginary };
        }

        public static Complex operator -(Complex c)
        {
            return new Complex() { Real = -c.Real, Imaginary = -c.Imaginary };
        }

        // cast operator overloading (both implicit and explicit)
        public static implicit operator double(Complex c)
        {
            return Math.Sqrt(Math.Pow(c.Real, 2) + Math.Pow(c.Imaginary, 2));
        }

        public static explicit operator string(Complex c)
        {
            return c.Real.ToString() + " + " + c.Imaginary.ToString() + "i";
        }
    }

    public class AlertService
    {
        private readonly IAlertDAO storage = new AlertDAO();

        public AlertService(IAlertDAO alert)
        {
            this.storage = alert;
        }

        public Guid RaiseAlert()
        {
            return this.storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return this.storage.GetAlert(id);
        }
    }

    public interface IAlertDAO
    {
        Guid AddAlert(DateTime time);

        DateTime GetAlert(Guid id);
    }

    public class AlertDAO : IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }

    class Racer
    {
        private readonly string name;

        public Racer(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Thread.Sleep(100);
            Console.Write(name);
        }
    }

    public class MovingTotal
    {
        List<int> values = new List<int>();

        public void Append(int[] list)
        {
            foreach(int i in list)
            {
                values.Add(i);
            }
        }

        public bool Contains(int total)
        {
            int n = values.Count;
                 
            while (n >= 3)
            {
                int sum = SumOfLastThree(n - 1);
                if (total == sum)
                    return true;
                n--;
            }  
            return false;
        }

        public int SumOfLastThree(int idx)
        {
            int sum = 0;
            for (int i = idx; i > idx - 3; i--)
            {
                sum += values[i];
            }
            return sum;
        }
    }

    public class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
            friend.Friends.Add(this);
        }

        public bool CanBeConnected(Friend friend)
        {
            return CanBeConnected(this, friend);
        }

        private bool CanBeConnected(Friend friend, Friend targetFriend)
        {
            if (friend.Friends != null)
            {
                if (friend.Friends.Contains(targetFriend))
                    return true;
                else
                {
                    foreach (Friend myFriend in friend.Friends)
                    {
                        return CanBeConnected(myFriend, targetFriend);
                    }
                }                                                    
            }
            return false;
        }
    }

    // Define the base class, Car. The class defines two virtual methods,  
    // DescribeCar and ShowDetails. DescribeCar calls ShowDetails, and each derived  
    // class also defines a ShowDetails method. The example tests which version of  
    // ShowDetails is used, the base class method or the derived class method.  
    class Car
    {
        public virtual void DescribeCar()
        {
            System.Console.WriteLine("Four wheels and an engine.");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            System.Console.WriteLine("Standard transportation.");
        }
    }

    // Define the derived classes.  

    // Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
    // hides the base class method.  
    class ConvertibleCar : Car
    {
        public new void ShowDetails()
        {
            System.Console.WriteLine("A roof that opens up.");
        }
    }

    // Class Minivan uses the override modifier to specify that ShowDetails  
    // extends the base class method.  
    class Minivan : Car
    {
        public override void ShowDetails()
        {
            System.Console.WriteLine("Carries seven people.");
        }
    }



    class Program
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        public static void TestCars1()
        {
            System.Console.WriteLine("\nTestCars1");
            System.Console.WriteLine("----------");

            Car car1 = new Car();
            car1.DescribeCar();
            System.Console.WriteLine("----------");

            // Notice the output from this test case. The new modifier is  
            // used in the definition of ShowDetails in the ConvertibleCar  
            // class.    
            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();
            System.Console.WriteLine("----------");
                                          
            Minivan car3 = new Minivan();
            car3.DescribeCar();
            System.Console.WriteLine("----------");
        }
        // Output:  
        // TestCars1  
        // ----------  
        // Four wheels and an engine.  
        // Standard transportation.  
        // ----------  
        // Four wheels and an engine.  
        // Standard transportation.  
        // ----------  
        // Four wheels and an engine.  
        // Carries seven people.  
        // ----------  

        public static void TestCars2()
        {
            System.Console.WriteLine("\nTestCars2");
            System.Console.WriteLine("----------");

            var cars = new List<Car> { new Car(), new ConvertibleCar(),
                new Minivan() };

            foreach (var car in cars)
            {
                car.DescribeCar();
                System.Console.WriteLine("----------");
            }
        }
        // Output:  
        // TestCars2  
        // ----------  
        // Four wheels and an engine.  
        // Standard transportation.  
        // ----------  
        // Four wheels and an engine.  
        // Standard transportation.  
        // ----------  
        // Four wheels and an engine.  
        // Carries seven people.  
        // ----------  

        public static void TestCars3()
        {
            System.Console.WriteLine("\nTestCars3");
            System.Console.WriteLine("----------");
            ConvertibleCar car2 = new ConvertibleCar();
            Minivan car3 = new Minivan();
            car2.ShowDetails();
            car3.ShowDetails();
        }
        // Output:  
        // TestCars3  
        // ----------  
        // A roof that opens up.  
        // Carries seven people.  

        public static void TestCars4()
        {
            System.Console.WriteLine("\nTestCars4");
            System.Console.WriteLine("----------");
            Car car2 = new ConvertibleCar();
            Car car3 = new Minivan();
            car2.ShowDetails();
            car3.ShowDetails();
        }
        // Output:  
        // TestCars4  
        // ----------  
        // Standard transportation.  
        // Carries seven people.  

        static void Main(string[] args)
        {
            // Declare objects of the derived classes and test which version  
            // of ShowDetails is run, base or derived.  
            TestCars1();

            // Declare objects of the base class, instantiated with the  
            // derived classes, and repeat the tests.  
            TestCars2();

            // Declare objects of the derived classes and call ShowDetails  
            // directly.  
            TestCars3();

            // Declare objects of the base class, instantiated with the  
            // derived classes, and repeat the tests.  
            TestCars4();

            //DeliveryDistance dd = new DeliveryDistance();
            //List<List<int>> deliveries = new List<List<int>>();
            //int[,] locations = { { 1, -3 }, { 1, 2 }, { 3, 4 } };
            //deliveries = dd.ClosestXdestinations(3, locations, 2);

            //foreach(var delivery in deliveries)
            //{
            //    Console.Write("Delivery Location : ");
            //    foreach(var location in delivery)
            //    {
            //        Console.Write(location + ", ");
            //    }
            //    Console.Write(Environment.NewLine);
            //}

            #region Delegate Example
            //int a, b;
            //char c, d;
            //a = 10;
            //b = 20;
            //c = 'I';
            //d = 'V';

            ////display values before swap:
            //Console.WriteLine("Int values before calling swap:");
            //Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine("Char values before calling swap:");
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            //call swap
            //Swap<int>(ref a, ref b);
            //Swap<char>(ref c, ref d);

            ////display values after swap:
            //Console.WriteLine("Int values after calling swap:");
            //Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine("Char values after calling swap:");
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            ////Create delegate instances
            //NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            //NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            ////calling the methods using the delegate objects
            //nc1(25);
            //Console.WriteLine("Value of Num: {0}", getNum());
            //nc2(5);
            //Console.WriteLine("Value of Num: {0}", getNum());
            #endregion

            //string[] log = { "t2 13 121 98", "rl box ape bit", "b4 xi me nu", "br8 eat num did", "wl has uni gry", "f3 52, 54, 31" };
            //string[] reorderedLog = LexicographicalOrder.ReorderLexicographically(log.Length, log);

            //Console.WriteLine("Reordered Log ");
            //foreach (string s in reorderedLog)
            //{
            //    Console.WriteLine(s);
            //}            
            //ReorderLexicographically


            //string input = "Rose is a flower red rose are flower";
            //string input2 = "Jack and jill went to the market to buy bread and cheese. Cheese is Jack's and Jill's favorite food.";
            //string[] arr = Regex.Replace(input.ToLower(), @"[^a-z]+", " ").Split(' ');
            //string[] arr2 = Regex.Replace(input2.ToLower(), @"[^a-z]+", " ").Split(' ');
            //string[] excludeArr = { "is", "are", "a" };
            //string[] excludeArr2 = { "and", "he", "the", "to", "is"};

            ////string[] result = MostFrequent.FindMostFrequent(arr, excludeArr);
            //string[] result = MostFrequent.FindMostFrequent(arr2, excludeArr2);

            //Console.WriteLine("Most Frequent Elements");
            //foreach(string s in result)
            //{
            //    Console.Write(s + ", ");
            //}


            //Friend a = new Friend("A");
            //Friend b = new Friend("B");
            //Friend c = new Friend("C");

            //a.AddFriendship(b);
            //b.AddFriendship(c);

            //Console.WriteLine(a.CanBeConnected(c));

            //MovingTotal movingTotal = new MovingTotal();

            //movingTotal.Append(new int[] { 1, 2, 3 });

            ////Console.WriteLine(movingTotal.Contains(6));
            ////Console.WriteLine(movingTotal.Contains(9));

            //movingTotal.Append(new int[] { 4 });

            //Console.WriteLine(movingTotal.Contains(11));

            //Thread t1 = new Thread(new Racer("1").Run);
            //Thread t2 = new Thread(new Racer("2").Run);
            //Thread t3 = new Thread(new Racer("3").Run);
            //Thread t4 = new Thread(new Racer("4").Run);
            //Thread t5 = new Thread(new Racer("5").Run);


            //t5.Start();
            //t3.Start();
            //t1.Start();
            //t3.Join();
            //t2.Start();
            //t1.Join();

            //Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            //if (indices != null)
            //{
            //    Console.WriteLine(indices.Item1 + " " + indices.Item2);
            //}

            //string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            //string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            //Console.WriteLine(string.Join(", ", FindCommon(names1, names2)));

            //AlertDAO dao = new AlertDAO();            

            //AlertService alertService = new AlertService(dao);
            //Guid guid = alertService.RaiseAlert();

            //Console.WriteLine(alertService.GetAlertTime(guid));

            //Complex number1 = new Complex() { Real = 1, Imaginary = 2 };
            //Complex number2 = new Complex() { Real = 4, Imaginary = 10 };
            //Complex number3 = number1 + number2;

            //number3 = -number3;
            //double testNumber = number3;
            //Console.WriteLine((string)number3);

            //global::System.Console.WriteLine("Hello, World!");

            Console.ReadLine();
        }

        static void Swap<T> (ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static string[] FindCommon(string[] names1, string[] names2)
        {
            HashSet<string> newArray = new HashSet<string>();
                          
            foreach(string s in names1)
            {
                newArray.Add(s);    
            }

            foreach(string s in names2)
            {
                newArray.Add(s);
            }

            return newArray.ToArray();
        }

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[i] + list[j] == sum)
                    {
                        return new Tuple<int, int>(list[i], list[j]);
                    }
                }

            }
            return null;
        }
    }
}
