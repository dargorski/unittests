using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz", TestName = "InputIsDivisibleBy3And5_ReturnsFizzBuzz")]
        [TestCase(9, "Fizz", TestName = "InputIsDivisibleBy3Only_ReturnsFizz")]
        [TestCase(10, "Buzz", TestName = "InputIsDivisibleBy5Only_ReturnsBuzz")]
        [TestCase(4, "4", TestName = "InputIsNotDivisibleBy3Or5_ReturnsSameNumberAsString")]
        public void GetOutput_WhenCalled_ReturnCorrectString(int number, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
