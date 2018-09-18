using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

    class Program
    {
        static void Main(string[] args)
        {
            Friend a = new Friend("A");
            Friend b = new Friend("B");
            Friend c = new Friend("C");

            a.AddFriendship(b);
            b.AddFriendship(c);

            Console.WriteLine(a.CanBeConnected(c));

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
