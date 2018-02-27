using SimpleCalculator;
using Xunit;

namespace SimpleCalcuator.Tests
{
    public class StringTokenizerTestss
    {
        [Fact]
        public void String_tokenizer_check_next_elements()
        {
            StringTokenizer stringTokenizer = new StringTokenizer("2+2");
            char element = stringTokenizer.NextElement();
            Assert.Equal('2', element);
            element = stringTokenizer.NextElement();
            Assert.Equal('+', element);
            element = stringTokenizer.NextElement();
            Assert.Equal('2', element);
        }

        [Fact]
        public void String_tokenizer_check_has_elements()
        {
            StringTokenizer stringTokenizer = new StringTokenizer("2+2");
            Assert.True(stringTokenizer.HasElements());
            stringTokenizer.NextElement();
            Assert.True(stringTokenizer.HasElements());
            stringTokenizer.NextElement();
            Assert.True(stringTokenizer.HasElements());
            stringTokenizer.NextElement();
            Assert.False(stringTokenizer.HasElements());
        }

        public static void Main(string[] args)
        {}
    }
}

    