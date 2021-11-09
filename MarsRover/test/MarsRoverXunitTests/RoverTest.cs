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

            var result = sut.CurrentDirection();

            Assert.Equal("0 0 N", result);
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
