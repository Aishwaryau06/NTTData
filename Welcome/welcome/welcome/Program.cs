using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("Enter your Name");
            username = Console.ReadLine();
            Console.WriteLine("HELLO WELCOME {0}", username);
            Console.ReadLine();
        }
    }
}
