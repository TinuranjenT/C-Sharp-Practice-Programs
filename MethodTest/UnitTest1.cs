using Microsoft.VisualStudio.TestPlatform.TestHost;
using Methods;
using Moq;

namespace MethodTest
{
    [TestFixture]
    public class Tests
    {
      
        [Test]      //method within this class are test methods
        public void AdditionMethodTest()
        {
            //Arrange
            var add = new MathOperations();    
            //Act
            int addResult = add.Addition(10, 20);
            //Assert
            Assert.AreEqual(30, addResult);
        }

        [Test]
        public void AdditionOfTwoNegativeNubersTest()
        {
            //Arrange
            var add = new MathOperations();
            //Act
            int addResult = add.Addition(-1, -2);
            //Assert
            Assert.AreEqual(-3, addResult);
        }


        [Test]
        public void AdditionWithNonIntegerInputA()
        {
            // Arrange
            double a = 5.5; // non-integer input
            int b = 10;
            var add = new MathOperations();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => add.Addition((int)a, b));
        }

        [Test]
        public void AdditionWithNonIntegerInputB()
        {
            // Arrange
            int a = 5;
            double b = 10.5; // non-integer input
            var mathOperations = new MathOperations();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => mathOperations.Addition(a, (int)b));
        }

        [Test]
        public void AdditionWithLargeValuesShouldNotOverflow()
        {
            // Arrange
            int a = int.MaxValue - 1;
            int b = 1;
            var mathOperations = new MathOperations();

            // Act
            int result = mathOperations.Addition(a, b);

            // Assert
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void AdditionWithMaxIntValueAndPositive()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 1;
            var mathOperations = new MathOperations();

            // Act & Assert
            Assert.Throws<OverflowException>(() => mathOperations.Addition(a, b));
        }
        [Test]
        public void AdditionWithIntegersShouldReturnIntegerResult()
        {
            // Arrange
            int a = 5;
            int b = 10;
            var mathOperations = new MathOperations();

            // Act
            int result = mathOperations.Addition(a, b);

            // Assert
            Assert.IsInstanceOf<int>(result);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SubtractionMethodTest()
        {
            var mockTesting = new Mock<Testing>();
            mockTesting.Setup(x => x.TempNumber()).Returns(50);
            var sub = new MathOperations();
            int subResult = sub.Subtraction(20, 10, mockTesting.Object);
            Assert.AreEqual(20, subResult);
        }

    }
}