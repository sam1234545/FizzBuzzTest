using NUnit.Framework;
using System;
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
        public void Given_Input_Value_return_this_Value([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17)] int value)
        {
            //arrange

            //act
            string actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual(value.ToString(), actual); ;
        }

        [Test]
        public void Given_Input_Divisible_by_3_return_Fizz([Values(3, 6, 9, 12, 18)] int value)
        {
            //arrange
            //act
            string actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizz", actual); ;
        }
        [Test]
        public void Given_Input_Mulitiple_of_5_return_Buzz([Values(5, 10, 20)] int value)
        {
            //arrange
            //act
            string actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("buzz", actual); ;
        }

        [Test]
        public void Given_Input_15_return_FizzBuzz([Values(15, 30)] int value)
        {
            //arrange
            //act
            string actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizzbuzz", actual); ;
        }

        private string FizzBuzzTest(int value)
        {

            StringBuilder stream = new StringBuilder();
            ComputeValueToDisplay(stream,value);
            if (stream.Length > 0) return stream.ToString();
            return value.ToString();
        }

        private void ComputeValueToDisplay(StringBuilder stream, int value)
        {
            if (value % 3 == 0) stream.Append(fizz);
            if (value % 5 == 0) stream.Append(buzz);
        }
    }
        
}