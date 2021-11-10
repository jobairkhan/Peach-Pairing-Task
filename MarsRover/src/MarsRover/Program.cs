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

            // rover process or execute commands e.g. ("LMLMLMLMM");
            // Then check what is the current position
            var output = rover.Execute("LMLMLMLMM");

            // for the above input output will be => "1 3 N"
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }

    public class Rover
    {
        /// <summary>
        /// Process the command and return the final position
        /// </summary>
        /// <param name="commands">A list of commands</param>
        /// <returns>Current Position after executing the commands</returns>
        public string Execute(string commands)
        {
            return null;
        }
        
    }
}
