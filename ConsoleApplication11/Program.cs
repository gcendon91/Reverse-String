using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hola Como Te Va?";

            Console.WriteLine(MiFuncion(s));
            
            Console.ReadKey();
        }
        public static string MiFuncion (string s)
        {
            s = s.Replace(" ", "-");
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);            
            return new string(arr);
        }
        public static string MiOtraFuncion(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length-1 ; i >=0 ; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }
    }
}
