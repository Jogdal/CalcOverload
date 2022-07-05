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
    }
}