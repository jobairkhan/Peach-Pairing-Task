using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRoverXUnitTests
{
    public class RoverTest
    {
        [Fact]
        public void Initial_position_should_be_0_0_N()
        {
            var sut = new Rover();

            var result = sut.Execute("");

            Assert.Equal("0 0 N", result);
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
