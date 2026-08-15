
using NUnit.Framework.Legacy;

namespace SkillFactory.AllHomeWorks.Tests;

public class Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        
        [Test]
        public void TestAddictional()
        {
            int a = 10;
            int b = 2;
            int result = _calculator.Additional(a, b);

            ClassicAssert.AreEqual(12, result);
        }

        [Test]
        public void TestSubtraction()
        {
            int a = 10;
            int b = 2;
            int result = _calculator.Subtraction(a, b);

            ClassicAssert.AreEqual(8, result);
        }

        [Test]
        public void TestMultiplication()
        {
            int a = 10;
            int b = 2;
            int result = _calculator.Multiplication(a, b);

            ClassicAssert.AreEqual(20, result);
        }

        [Test]
        public void TestDivision()
        {
            int a = 10;
            int b = 2;
            int result = _calculator.Division(a, b);

            ClassicAssert.AreEqual(5, result);
        }

        [Test]
        public void TestDivision_ThrowsDivideByZeroException()
        {
            int a = 10;
            int b = 0;

            Assert.Throws<DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}