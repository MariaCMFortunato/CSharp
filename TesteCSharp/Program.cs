using System;
internal class Program
{
     private static void Main(string[] args) 
     {
          int age;

          Console.WriteLine("Hello, World!");
          Console.WriteLine("Hello C#!");
          Console.WriteLine();
          Console.WriteLine($"The current time is: {DateTime.Now}");
          Console.WriteLine();
          Console.WriteLine("What is our name?");
          string name = Console.ReadLine();
          // devia ser escrito string name = Console.ReadLine()
          //Só retorna valores em string
          Console.WriteLine($"Hello, {name}");
          Console.WriteLine();
          Console.WriteLine("What is our age?");
          age = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"{age} what a nice age!");
          Console.WriteLine();
          //taking inputs
          string input1 = Console.ReadLine();
          string input2 = Console.ReadLine();

          //converting to int
          int number1 = Convert.ToInt32(input1);
          int number2 = Convert.ToInt32(input2);

          //calculating the sum
          int result = number1 + number2;

          Console.WriteLine(result);
          Console.WriteLine();

          int wins;
          int ties;

          //your code goes here
          string input3 = Console.ReadLine();
          string input4 = Console.ReadLine();
        
          wins = Convert.ToInt32(input3);
          ties = Convert.ToInt32(input4);

          double pointsEarned = wins + 0.5 * ties;

          Console.WriteLine(pointsEarned);

           Console.WriteLine(@"Hey!
     I'm a verbatim string.");

          //string name = Console.ReadLine();
          Console.WriteLine();
          Console.WriteLine(name + " is an awesome Sololearner!");
          Console.WriteLine(name + " learns!");
          Console.WriteLine(name + " practises!");
          Console.WriteLine("Be like " + name + "!");



     }
}