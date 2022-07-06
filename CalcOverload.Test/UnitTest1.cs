using CalculatorApp;

namespace CalcOverload.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestSimpleAddition()
        {
            double a = 10.5;
            double b = 11.5;
            double sut = Program.OperandAddition(a, b);
            Assert.Equal(a+b, sut);
        }
        [Fact]
        public void TestComplexAddition()
        {
            double[] testingNumbers = new double[] { 10.5, 11.5, 15 };
            double sut = Program.OperandAddition(testingNumbers);

            Assert.Equal( 37, sut);
        }


        [Fact]
        public void TestSimpleSubtraction()
        {
            double a = 20;
            double b = 10;
            double sut = Program.OperandSubtraction(a, b);
            Assert.Equal(a - b, sut);
        }

        [Fact]
        public void TestComplexSubtraction()
        {
            double[] testingNumbers = new double[] { 50.5, 11.5, 15 };
            double sut = Program.OperandSubtraction(testingNumbers);

            Assert.Equal(24, sut);
        }

        [Fact]
        public void TestSimpleMultiplication()
        {
            double a = 20;
            double b = 10;
            double sut = Program.OperandMultiplication(a, b);
            Assert.Equal(a * b, sut);
        }

        [Fact]
        public void TestSimpleDivision()
        {
            double a = 20;
            double b = 10;
            double sut = Program.OperandDivision(a, b);
            Assert.Equal(a / b, sut);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            double a = 10;
            double b = 0;
            double sut = Program.OperandDivision(a, b);
            Assert.Equal( 0, sut );
        }

        [Fact]
        public void TestDivisionWithZero()
        {
            double a = 0;
            double b = 10;
            double sut = Program.OperandDivision(a, b);
            Assert.Equal(0, sut);
        }
    }
}