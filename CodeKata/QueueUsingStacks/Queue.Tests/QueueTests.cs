using System;
using Xunit;

namespace Queue.Tests
{
    public class QueueTests
    {
        [Fact]
        public void Given_QueueOfElements_Expect_ReturnCorrectSizeOfQueue()
        {
            Queue q = new Queue();
            Assert.True(q.Size() == 0);
            q.Enqueue('t');
            Assert.True(q.Size() == 1);
            q.Enqueue('e');
            Assert.True(q.Size() == 2);
        }

        [Fact]
        public void Given_QueueOfElements_Expect_QueueContainsElements()
        {
            Queue q = new Queue();
            Assert.False(q.Contains('t'));
            q.Enqueue('t');
            Assert.True(q.Contains('t'));
            q.Enqueue('e');
            Assert.True(q.Contains('e'));
            q.Enqueue('s');
            Assert.True(q.Contains('s'));
        }

        [Fact]
        public void Given_QueueOfElements_Expect_DequeueElements()
        {
            Queue q = new Queue();
            q.Enqueue('t');
            q.Enqueue('e');
            q.Enqueue('s');
            q.Enqueue('t');
            Assert.True(q.Dequeue() == 't');
            Assert.True(q.Dequeue() == 'e');
            Assert.True(q.Dequeue() == 's');
            Assert.True(q.Dequeue() == 't');
        }

        [Fact]
        public void Given_EmptyQueue_Expect_EmptyDequeueElements()
        {
            Queue q = new Queue();
            Assert.True(q.Dequeue() == ' ');
        }

        [Fact]
        public void Given_QueueOfElements_Expect_PeekElement()
        {
            Queue q = new Queue();
            q.Enqueue('t');
            q.Enqueue('j');
            Assert.True(q.Peek() == 't');
            Assert.True(q.Dequeue() == 't');
            Assert.True(q.Peek() == 'e');
            Assert.True(q.Dequeue() == 'e');
        }

        [Fact]
        public void Given_EmptyQueue_Expect_EmptyPeekElements()
        {
            Queue q = new Queue();
            Assert.True(q.Peek() == ' ');
        }
    }
}
