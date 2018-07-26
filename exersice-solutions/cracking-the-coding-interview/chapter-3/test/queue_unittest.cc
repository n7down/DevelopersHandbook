#include "queue.h"

#include <gtest/gtest.h>
#include <string>

class QueueTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST_F(QueueTest, check_add_operator_adds_elements_to_a_queue)
{
	Queue<int> q0;
	q0.add(0);

	Queue<int> e0;
	e0.add(0);

	EXPECT_TRUE(q0 == e0) << q0.print() << " and " << e0.print() << " should be equal";

	q0.add(1);

	EXPECT_TRUE(q0 != e0) << q0.print() << " and " << e0.print() << " should not be equal";
}

TEST_F(QueueTest, check_remove_operator_removes_elements_from_a_queue)
{
	Queue<int> q0;
	q0.add(0);
	q0.add(1);
	int d0 = q0.remove();

	Queue<int> e0;
	e0.add(0);

	EXPECT_TRUE(d0 == 0) << "d0 should equal 0";
	EXPECT_TRUE(q0 == e0) << q0.print() << " " << e0.print() << " should be equal";

	try
	{
		q0.remove();
		FAIL() << "expected std::length_error";
	}
	catch(std::length_error const & err)
	{
		EXPECT_EQ(err.what(), std::string("queue is empty"));
	}
	catch(...)
	{
		FAIL() << "expected std::length_error";
	}
}

TEST_F(QueueTest, check_peek_operator_shows_first_element_in_queue)
{
	Queue<int> q0;
	q0.add(0);

	EXPECT_TRUE(q0.peek() == 0) << "q0 peek should be 0";

	q0.add(1);

	EXPECT_TRUE(q0.peek() == 0) << "q0 peek should be 0";

	q0.remove();

	EXPECT_TRUE(q0.peek() == 1) << "q0 peek should be 1";

	q0.remove();
	
	try
	{
		q0.peek();
		FAIL() << "expected std::length_error";
	}
	catch(std::length_error const & err)
	{
		EXPECT_EQ(err.what(), std::string("queue is empty"));
	}
	catch(...)
	{
		FAIL() << "expected std::length_error";
	}
}

TEST_F(QueueTest, check_isEmpty_operator_checks_if_queue_is_empty)
{
	Queue<int> q0;
	
	EXPECT_TRUE(q0.isEmpty()) << "q0 isEmpty should be true";

	q0.add(0);

	EXPECT_TRUE(q0.isEmpty()) << "q0 isEmpty should not be true";
}

TEST_F(QueueTest, compare_two_queues_are_equal)
{
	Queue<int> q0;
	q0.add(0);

	Queue<int> e0;
	e0.add(0);

	EXPECT_TRUE(q0 == e0) << q0.print() << " " << e0.print() << " should be equal";

	q0.add(0);

	e0.add(0);

	EXPECT_TRUE(q0 == e0) << q0.print() << " " << e0.print() << " should be equal";
}

TEST_F(QueueTest, compare_two_queues_are_not_equal)
{
	Queue<int> q0;
	q0.add(0);

	Queue<int> e0;

	EXPECT_TRUE(q0 != e0) << q0.print() << " " << e0.print() << " should not be equal";

	q0.add(1);

	e0.add(0);

	EXPECT_TRUE(q0 != e0) << q0.print() << " " << e0.print() << " should not be equal";
}

