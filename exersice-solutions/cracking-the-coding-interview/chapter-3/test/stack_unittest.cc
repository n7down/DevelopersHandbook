#include "stack.h"

#include <gtest/gtest.h>
#include <string>

class StackTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST_F(StackTest, check_isEmpty_operator)
{
	Stack<int> s0;

	EXPECT_TRUE(s0.isEmpty() == true) << s0.print() << " should be empty";

	s0.push(0);

	EXPECT_TRUE(s0.isEmpty() != true) << s0.print() << " should not be empty";
}

TEST_F(StackTest, compare_two_stacks_with_equals_operator)
{
	Stack<int> s0;
	s0.push(0);

	Stack<int> e0;
	e0.push(0);

	EXPECT_TRUE(s0 == e0) << s0.print() << " " << e0.print() << " should be equal";
}

TEST_F(StackTest, compare_two_stacks_with_not_equals_operator)
{
	Stack<int> s0;
	s0.push(0);
	s0.push(1);

	Stack<int> e0;
	e0.push(0);

	EXPECT_TRUE(s0 != e0) << s0.print() << " " << e0.print() << " should not be equal";
}

TEST_F(StackTest, push_data_into_stack)
{
	Stack<int> s0;
	s0.push(0);
	
	Stack<int> e0;
	e0.push(0);

	EXPECT_TRUE(s0 == e0) << s0.print() << " " << e0.print() << " should be equal";

	s0.push(1);

	EXPECT_TRUE(s0 != e0) << s0.print() << " " << e0.print() << " should not be equal";
}

TEST_F(StackTest, pop_data_off_a_stack)
{
	Stack<int> s0;
	try{
		int data = s0.pop();
		FAIL() << "expected std::length_error";
	}
	catch(std::exception const & err)
	{
		EXPECT_EQ(err.what(), std::string("stack is empty"));
	}
	catch(...) 
	{
		FAIL() << "expected std::length_error";
	}

	Stack<int> s1;
	s1.push(0);
	int d1 = s1.pop();

	Stack<int> e1;

	EXPECT_TRUE(d1 == 0) << "d1 from pop() should equal 0";
	EXPECT_TRUE(s1 == e1) << s1.print() << " and " << e1.print() << " should be equal";
}

TEST_F(StackTest, peek_data_on_a_stack)
{
	Stack<int> s0;
	s0.push(0);
	
	EXPECT_TRUE(s0.peek() == 0) << "peek() should equal 0";
}


