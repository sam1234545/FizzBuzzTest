using NUnit.Framework;

namespace FizzBuzzTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void GivenInput_3_returnFizz()
        {
            //arrange
            int value = 3;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizz", actual);
        }

        [Test]
        public void GivenInput_5_returnBuzz()
        {
            //arrange
            int value = 5;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("buzz", actual);

        }
        [Test]
        public void GivenInput_6_returnFizz()
        {
            //arrange
            int value = 6;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizz", actual);
        }
        [Test]
        public void GivenInput9_returnFizz()
        {
            //arrange
            int value = 9;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizz", actual); ;
        }

        [Test]
        public void GivenInput10_returnBuzz()
        {
            //arrange
            int value = 10;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("buzz", actual); ;
        }

        [Test]
        public void GivenInput_Value_return_thisValue([Values(1,2,4,7,8,11,13,14)] int value)
        {
            //arrange
    
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual(value, actual); ;
        }

        [Test]
        public void GivenInput_Divisibleby3_returnFizz([Values(3, 6, 9, 12)] int value)
        {
            //arrange
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual("fizz", actual); ;
        }

        private object FizzBuzzTest(int value)
        {
            if (value % 3 == 0 ) return "fizz";
            if (value % 5 == 0 ) return "buzz";
            return value; 
        }
    }
}