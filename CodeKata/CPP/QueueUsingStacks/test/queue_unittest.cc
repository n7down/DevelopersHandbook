#include <gtest/gtest.h>

#include "queue.h"

TEST(QueueTest, EnqueueElements)
{}

TEST(QueueTest, DequeueElement)
{}

TEST(QueueTest, Size)
{
	Queue q;
	q.enqueue(1);
	q.enqueue(2);
	ASSERT_TRUE(q.size() == 2) << "expected size of 2";
}
