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
        public void GivenInput_1_return1()
        {
            //arrange
            int value = 1;
            //act
            var actual =FizzBuzzTest(value);
            //assert
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void GivenInput_2_return2()
        {
            //arrange
            int value = 2;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual(2, actual);
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

        private object FizzBuzzTest(int value)
        {

            if (value == 1 || value == 2) return value; 
            return "fizz";
        }
    }
}