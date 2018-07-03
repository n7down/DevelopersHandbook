#include "linkedlist.h"

#include <gtest/gtest.h>
#include <iostream>

class LinkedListTest : public ::testing::Test 
{
protected:
	virtual void SetUp()
	{
		fails = 0;
	}

	virtual void TearDown()
	{
		if(fails > 0)
		{
			std::cerr << fails << " test cases FAILED" << std::endl;
		}
		else
		{
			std::cout << "All test case PASSED" << std::endl;
		}
	}

public:
	unsigned fails;
};

TEST_F(LinkedListTest, check_count_of_nodes)
{
	LinkedList ll0;

	EXPECT_EQ(ll0.count(), 0) << "count should be 0";
	fails += ::testing::Test::HasFailure();

	LinkedList ll1;
	ll1.append(0);

	EXPECT_EQ(ll1.count(), 1) << "count should be 1";
	fails += ::testing::Test::HasFailure();

	LinkedList ll2;
	ll2.append(0).append(1);

	EXPECT_EQ(ll2.count(), 2) << "count should be 2";
	fails += ::testing::Test::HasFailure();
}

TEST_F(LinkedListTest, compare_linked_lists_with_equal_operator)
{
	LinkedList ll0;
	ll0.append(0);

	LinkedList ll1;
	ll1.append(0);

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll2;
	ll2.append(0);

	LinkedList ll3;
	ll3.append(1);

	EXPECT_FALSE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should not be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll4;

	LinkedList ll5;
	ll5.append(0);

	EXPECT_FALSE(ll4 == ll5) << ll4.print() << " and " << ll5.print() << " should not be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll6;
	ll6.append(0);
	
	LinkedList ll7;

	EXPECT_FALSE(ll6 == ll7) << ll6.print() << " and " << ll7.print() << " should not be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll8;
	ll8.append(0).append(1);

	LinkedList ll9;
	ll9.append(2).append(3);

	EXPECT_FALSE(ll8 == ll9) << ll8.print() << " and " << ll9.print() << " should not be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll10;
	
	LinkedList ll11;

	EXPECT_TRUE(ll10 == ll11) << ll10.print() << " and " << ll11.print() << " should be equal";	
	fails += ::testing::Test::HasFailure();

	LinkedList ll12;
	ll12.append(0);

	LinkedList ll13;
	ll13.append(0).append(1);

	EXPECT_TRUE(ll12 == ll13) << ll12.print() << " and " << ll13.print() << " should not be equal";	
	fails += ::testing::Test::HasFailure();
}

TEST_F(LinkedListTest, compare_linked_lists_with_not_equal_operator)
{
	LinkedList ll0;

	LinkedList ll1;

	EXPECT_FALSE(ll0 != ll1) << ll0.print() << " and " << ll1.print() << " should be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll2;
	ll2.append(0);

	LinkedList ll3;

	EXPECT_TRUE(ll2 != ll3) << ll2.print() << " and " << ll3.print() << " should not be equal";
	fails += ::testing::Test::HasFailure();

	LinkedList ll4;

	LinkedList ll5;
	ll5.append(0);

	EXPECT_TRUE(ll4 != ll5) << ll4.print() << " and " << ll5.print() << " should not be equal";	
	fails += ::testing::Test::HasFailure();
}

TEST_F(LinkedListTest, check_if_linked_lists_are_empty)
{
	LinkedList ll0;
	EXPECT_TRUE(ll0.empty()) << "linked list should be empty";
	fails += ::testing::Test::HasFailure();

	LinkedList ll1;
	ll1.append(0);
	EXPECT_FALSE(ll1.empty()) << "linked list should not be empty";	
	fails += ::testing::Test::HasFailure();
}

TEST_F(LinkedListTest, append_elements_to_linked_list)
{
	LinkedList ll0;
	ll0.append(0);
	
	LinkedList ll1;
	ll1.append(0);

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";	
	fails += ::testing::Test::HasFailure();

	LinkedList ll2;
	ll2.append(0).append(1);

	LinkedList ll3;
	ll3.append(0).append(1);

	EXPECT_TRUE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should be equal";	
	fails += ::testing::Test::HasFailure();

	LinkedList ll4;
	ll4.append(0).append(1).append(2);

	LinkedList ll5;
	ll5.append(0).append(1).append(2);

	EXPECT_TRUE(ll4 == ll5) << ll4.print() << " and " << ll5.print() << " should be equal";	
	fails += ::testing::Test::HasFailure();
}

TEST_F(LinkedListTest, remove_from_tail)
{
	LinkedList ll0;
	ll0.append(0);
	ll0.removeFromTail();

	LinkedList ll1;

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";
}

int main(int argc, char **argv) {
	::testing::InitGoogleTest(&argc, argv);
	return RUN_ALL_TESTS();
}
