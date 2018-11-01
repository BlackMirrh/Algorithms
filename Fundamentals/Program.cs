using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IGrouping<System.Reflection.MemberTypes, System.Reflection.MemberInfo> group = typeof(String).GetMembers().GroupBy(member => member.MemberType).First();

            Console.WriteLine("\nValues that have the key '{0}':", group.Key);
            foreach(System.Reflection.MemberInfo mi in group)
            {
                Console.WriteLine(mi.Name);
            }

            Console.ReadLine();
        }
    }
}
