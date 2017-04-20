using System;

namespace FunctionalProgramming
{
    class Program
    {
        delegate void SayGreeting(string name);
      
        static void Main(string[] args)
        {
          SayGreeting sayGreeting = delegate(string name)
          {
            Console.WriteLine(string.Format("Hello, {0}", name));
          };
          
          Console.WriteLine("What's your name?");
          string input = Console.ReadLine();
          sayGreeting(input);
          
          Console.ReadLine();
          
          sayGreeting = delegate(string name)
          {
            Console.WriteLine(string.Format("Later, {0}", name));
          };
          
          sayGreeting(input);
        }
    }
}