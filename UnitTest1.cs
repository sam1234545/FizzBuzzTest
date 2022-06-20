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

        private object FizzBuzzTest(int value)
        {
            return 1;
        }
    }
}