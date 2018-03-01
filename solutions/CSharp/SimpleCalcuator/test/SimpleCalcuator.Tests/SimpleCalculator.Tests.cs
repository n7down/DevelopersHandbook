using SimpleCalculator;
using Xunit;

namespace SimpleCalcuator.Tests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void Simple_calculator_one_number_calculation_test()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator("3");
            Assert.Equal(3, simpleCalculator.Calculate());
        }

        [Fact]
        public void Simple_calculator_two_numbers_calculation_test()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator("2+2");
            Assert.Equal(4, simpleCalculator.Calculate());
        }

        [Fact]
        public void Simple_calculator_three_numbers_calcuate_test()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator("2+2-1");
            Assert.Equal(3, simpleCalculator.Calculate());
        }

        [Fact]
        public void Simple_calculator_four_numbers_calculate_test()
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator("2+2-3+5");
            Assert.Equal(6, simpleCalculator.Calculate());
        }

        [Fact]
        public void String_tokenizer_check_length()
        {
            StringTokenizer stringTokenizer = new StringTokenizer("2+2-3+5");
            Assert.Equal(7, stringTokenizer.Length);
        }

    }
}
