using Domain;
using NUnit.Framework;
using Services;

namespace UnitTests
{
    public class AddServiceTests
    {
        private AddService _service;

        [SetUp]
        public void Setup()
        {
            //_service = new AddService();
        }

        [Test]
        public void Test1()
        {
            var input = new AddDTO { Num1 = 1, Num2 = 2 };
            var expectedResult = 3;

            var result = _service.AddAsync(input, default).Result;
            Assert.AreEqual(expectedResult, result);
        }
    }
}