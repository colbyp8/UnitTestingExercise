using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 7, 2, 14)] //Add test data <-------
        [InlineData(-5, 3, 5, 3)] //Add test data <-------
        [InlineData(8, 8, 8, 24)] //Add test data <-------

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:


            //Arrange

            Calculator tester = new Calculator();

            //Act
            int actual = tester.Add(num1, num2, num3);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]
        [InlineData(-5, -5, 0)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator tester = new Calculator();

            //Act
            double actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(7, 5, 35)]
        [InlineData(3, 9, 27)]
        [InlineData(-9, 8, -72)]
        [InlineData(-9, -8, 72)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator tester = new Calculator();

            //Act
            int actual = tester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(72, -9, -8)]
        [InlineData(-72, -9, 8)]
        [InlineData(35, 7, 5)]
        [InlineData(49, 7, 7)]
        [InlineData(100, 25, 4)]
        public void DivideTest(int num1, int num2, double expected)
        {
            //Arrange
            Calculator tester = new Calculator();

            //Act
            double actual = tester.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
