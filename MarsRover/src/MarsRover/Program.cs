using System;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var exampleInput = @"5 5
1 2 N
LMLMLMLMM";
            // This is just a starting point
            var rover = new Rover();

            // rover process ("LMLMLMLMM");
            var output = rover.CurrentDirection();

            // for the above input output will be => "1 3 N"
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }

    public class Rover
    {
        public string CurrentDirection()
        {
            throw new NotImplementedException();
        }
        
    }
}
