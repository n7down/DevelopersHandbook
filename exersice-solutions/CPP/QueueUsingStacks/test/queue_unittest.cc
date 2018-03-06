#include <gtest/gtest.h>

#include "queue.h"

TEST(QueueTest, EnqueueElements)
{
	Queue q;
	q.enqueue(1);
	q.enqueue(2);
	ASSERT_TRUE(q.top() == 1) << "expected top element is 2";
	ASSERT_TRUE(q.size() == 2) << "expected size is 2";
}

TEST(QueueTest, DequeueElement)
{
	Queue q;
	q.enqueue(1);
	q.enqueue(2);
	ASSERT_TRUE(q.size() == 2) << "expected size is 2";
	ASSERT_TRUE(q.dequeue() == 1) << "expected dequeue element is 2";
	ASSERT_TRUE(q.size() == 1) << "expected size is 1";
	ASSERT_TRUE(q.dequeue() == 2) << "expected dequeue element is 1";
	ASSERT_TRUE(q.size() == 0) << "expected size is 0";
}

TEST(QueueTest, Size)
{
	Queue q;
	q.enqueue(1);
	q.enqueue(2);
	ASSERT_TRUE(q.size() == 2) << "expected size is 2";
	q.dequeue();
	ASSERT_TRUE(q.size() == 1) << "expected size is 1";
}
