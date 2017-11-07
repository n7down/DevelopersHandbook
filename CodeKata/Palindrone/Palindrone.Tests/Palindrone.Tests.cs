using Xunit;

namespace Palindrone.Tests
{
    public class PalindroneTests
    {
        [Fact]
        public void Check_one_letter_that_is_palindrone()
        {
            Palindrone palindrone = new Palindrone("a");
            Assert.True(palindrone.IsValid());
        }

        [Fact]
        public void Check_two_letter_that_is_palindrone()
        {
            Palindrone palindrone = new Palindrone("aa");
            Assert.True(palindrone.IsValid());
        }

        [Fact]
        public void Check_two_letter_that_is_not_palindrone()
        {
            Palindrone palindrone = new Palindrone("ab");
            Assert.False(palindrone.IsValid());
        }

        [Fact]
        public void Check_three_letter_that_is_palindrone()
        {
            Palindrone palindrone = new Palindrone("bab");
            Assert.True(palindrone.IsValid());
        }

        [Fact]
        public void Check_three_letter_that_is_not_palindrone()
        {
            Palindrone palindrone = new Palindrone("abc");
            Assert.False(palindrone.IsValid());
        }

        [Fact]
        public void Check_four_letter_that_is_palindrone()
        {
            Palindrone palindrone = new Palindrone("abba");
            Assert.True(palindrone.IsValid());
        }

        [Fact]
        public void Check_four_leeter_that_is_not_palindrone()
        {
            Palindrone palindrone = new Palindrone("abcd");
            Assert.False(palindrone.IsValid());
        }

        [Fact]
        public void Check_five_letter_that_is_palindrone()
        {
            Palindrone palindrone = new Palindrone("hannah");
            Assert.True(palindrone.IsValid());
        }
    }
}