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


        [Test]
        public void GivenInput_4_return4()
        {
            //arrange
            int value = 4;
            //act
            var actual = FizzBuzzTest(value);
            //assert
            Assert.AreEqual(4, actual);
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



        private object FizzBuzzTest(int value)
        {
            if (value == 3) return "fizz";
            else if (value == 5) return "buzz";
            return value; 
        }
    }
}