using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-4, 7, 15, 18)]
        [InlineData(0, -3, 8, 5)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, -5, 7)]
        [InlineData(0, 5, -5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Substract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 0, 0)]
        [InlineData(2, -5, -10)]
        [InlineData(-3, -5, 15)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();


            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 1)]
        [InlineData(10, -5, -2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SumOfarr()
        {
            //Arrange
            var test = new UnitTestMethods();
            int[] r = new int[6] { 3, 2, 4, 5, 3, 1 };

            //Act
            var actual = test.SumOfArr(r);
            var expected = 18;

            Assert.Equal(expected, actual);

            //Assert

        }

        [Fact]
        
        public void ProductOfOddnums()
        {
            int[] b = new int[4] { 2, 3, 5, 4 };
            //Arrange
            var test = new UnitTestMethods();
            var actual = test.MultiplyOddNums(b);

            //Act
            var expected = 15;
            Assert.Equal(expected, actual);


            //Assert
           
        }
    }
}
