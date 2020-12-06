using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloGithub
{
    class Program
    {
        public int Sub(int a, int b)
        {
            //bug fix
            return a - b;
        }
        public int Add(int a, int b)
        {
            //Add Function
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git Hub!");
            Console.WriteLine("This is from Git Hub");
            Console.WriteLine("New feature");
            Console.WriteLine("New feature efect");
            Console.WriteLine("Merge from master");
        }
    }
}
