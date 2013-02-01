using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace StringCalculatorDojo1
{
    [TestFixture]
    public class StringCalculatorTest
    {
        private StringCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new StringCalculator();
        }

        [Test]
        public void AddWithEmptyInputReturnsZero()
        {
            int value = calculator.Add(String.Empty);
            Assert.AreEqual(0, value, "Expected return of zero with empty input");
        }

        [Test]
        public void AddWithOneInputReturnsInputValueAsInteger()
        {
            int value = calculator.Add("1");
            Assert.AreEqual(1, value, "Expected return of one with one");
        }

        [Test]
        public void AddWithTwoNumbersAsInputReturnsSumOfInputNumbers()
        {
            int sum = calculator.Add("1,2");
            Assert.AreEqual(3, sum, "Expected return of three");
        }

        [Test]
        public void AddWithManyNumbersAsInputReturnsSumOfInputNumbers()
        {
            int sum = calculator.Add("1,2,3,4");
            Assert.AreEqual(10, sum);
        }

        [Test]
        public void AddNumbersAsInputWithNewlineDelimiterReturnsSumOfInputNumbers()
        {
            int sum = calculator.Add("1\n2,3");
            Assert.AreEqual(6, sum);
        }

        [Test]
        [ExpectedException]
        public void AddInvalidInput()
        {
            int sum = calculator.Add("1,\n");
        }

        [Test]
        public void AddNumbersAsInputWithDifferentDelimiterReturnsSumOfInputNumbers()
        {
            int sum = calculator.Add("//;\n1;2");
            Assert.AreEqual(3, sum);
        }


        [Test]
        public void fooTest()
        {
            string fooreturn = calculator.foo("//;\n1;2");
            Assert.AreEqual("1;2", fooreturn);
        }
    }
}
