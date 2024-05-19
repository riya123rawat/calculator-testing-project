using calculator_testing;
    using Xunit;

namespace calculator_testing_tests
    {
        public class CalcTests
        {
            private readonly Calc _calculator;

            public CalcTests()
            {
                _calculator = new Calc();
            }

            [Fact]
            public void Addition_TwoNumbers_ReturnsSum()
            {
                double result = _calculator.Addition(5.0, 3.0);
                Assert.Equal(8.0, result);
            }

            [Fact]
            public void Addition_MultipleNumbers_ReturnsSum()
            {
                double result = _calculator.Addition(1.0, 2.0, 3.0, 4.0, 5.0);
                Assert.Equal(15.0, result);
            }

            [Fact]
            public void Subtraction_TwoNumbers_ReturnsDifference()
            {
                double result = _calculator.Subtraction(10.0, 4.0);
                Assert.Equal(6.0, result);
            }

            [Fact]
            public void Subtraction_MultipleNumbers_ReturnsDifference()
            {
                double result = _calculator.Subtraction(20.0, 5.0, 3.0);
                Assert.Equal(12.0, result);
            }

            [Fact]
            public void Multiplication_TwoNumbers_ReturnsProduct()
            {
                double result = _calculator.Multiplication(7.0, 6.0);
                Assert.Equal(42.0, result);
            }

            [Fact]
            public void Division_TwoNumbers_ReturnsQuotient()
            {
                double result = _calculator.Division(15.0, 3.0);
                Assert.Equal(5.0, result);
            }

            [Fact]
            public void Division_DivideByZero_ThrowsDivideByZeroException()
            {
                Assert.Throws<DivideByZeroException>(() => _calculator.Division(10.0, 0.0));
            }
        }
    }