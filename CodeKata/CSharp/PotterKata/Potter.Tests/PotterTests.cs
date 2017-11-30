using NUnit.Framework;

namespace Potter.Tests
{
    [TestFixture]
    public class PotterTests
    {
        [TestCase(new int[] {1, 0, 0, 0, 0}, 8)]
        [TestCase(new int[] {0, 1, 0, 0, 0}, 8)]
        [TestCase(new int[] {0, 0, 1, 0, 0}, 8)]
        [TestCase(new int[] {0, 0, 0, 1, 0}, 8)]
        [TestCase(new int[] {0, 0, 0, 0, 1}, 8)]
        [TestCase(new int[] {2, 0, 0, 0, 0}, 16)]
        [TestCase(new int[] {0, 2, 0, 0, 0}, 16)]
        [TestCase(new int[] {0, 0, 2, 0, 0}, 16)]
        [TestCase(new int[] {0, 0, 0, 2, 0}, 16)]
        [TestCase(new int[] {0, 0, 0, 0, 2}, 16)]
        public void Check_book_prices_without_discounts(int[] bookArray, double expectedPrice)
        {
            Potter potter = new Potter(bookArray);
            Assert.That(potter.Price, Is.EqualTo(expectedPrice));
        }

        [TestCase(new int[] {1, 1, 0, 0, 0}, 15.2)]
        [TestCase(new int[] {1, 1, 1, 0, 0}, 21.6)]
        [TestCase(new int[] {1, 1, 1, 1, 0}, 25.6)]
        [TestCase(new int[] {1, 1, 1, 1, 1}, 30)]
        [TestCase(new int[] {1, 1, 1, 2, 2}, 39.9)]
        public void Check_book_prices_with_discounts(int[] bookArray, double expectedPrice)
        {
            Potter potter = new Potter(bookArray);
            Assert.That(potter.Price, Is.EqualTo(expectedPrice));
        }
    }
}
