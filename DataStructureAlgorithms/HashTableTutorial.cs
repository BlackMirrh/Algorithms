using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    public class HashTableTutorial
    {
        public static void Test()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            foreach(DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            ICollection valueColl = openWith.Values;

            foreach(string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            ICollection keyColl = openWith.Keys;

            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }
        }   
    }
}
