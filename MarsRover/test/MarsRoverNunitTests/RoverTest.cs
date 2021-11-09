using System;
using NUnit.Framework;

namespace MarsRoverNUnitTests
{
    public class RoverTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartHere()
        {
            var sut = new Rover();

            var result = sut.CurrentDirection();

            Assert.That(result, Is.EqualTo("0 0 N"));
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