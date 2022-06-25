using NUnit.Framework;
using System.Collections;
using System.IO;
using System.Text;

namespace FizzBuzzTest
{
    public class Tests
    {
        private const string buzz = "buzz";
        private const string fizz = "fizz";

        [Test]
        public void GivenInput_Value_return_thisValue([Values(1,2,4,7,8,11,13,14,16,17)] int value)
        {
            //arrange
    
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual(value, actual); ;
        }

        [Test]
        public void GivenInput_Divisibleby3_returnFizz([Values(3, 6, 9, 12,18)] int value)
        {
            //arrange
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizz", actual); ;
        }
        [Test]
        public void GivenInput_Mulitiple_of_5_returnBuzz([Values(5, 10,20)] int value)
        {
            //arrange
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("buzz", actual); ;
        }

        [Test]
        public void GivenInput_15_returnFizzBuzz([Values(15,30)] int value)
        {
            //arrange
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizzbuzz", actual); ;
        }

        private object FizzBuzzTest(int value)
        {
            
            StringBuilder stream = new StringBuilder(); 
            if (value % 3 == 0 ) stream.Append(fizz) ;
            if (value % 5 == 0) stream.Append(buzz);
            if ( stream.Length > 0 ) return stream.ToString();
            return value; 
        }
    }
}