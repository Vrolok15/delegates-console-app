using System;

namespace FunctionalProgramming
{
    class Program
    {
        delegate void SayGreeting(string name);
        
        public static void SayHello(string name)
        {
          Console.WriteLine(string.Format("Hello, {0}", name));
        }
      
        static void Main(string[] args)
        {
          SayGreeting sayGreeting = new SayGreeting(SayHello);
          Console.WriteLine("What's your name?");
          string input = Console.ReadLine();
          sayGreeting(input);
        }
    }
}