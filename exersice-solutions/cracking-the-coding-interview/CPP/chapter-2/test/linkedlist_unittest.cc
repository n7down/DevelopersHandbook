#include "linkedlist.h"

#include <gtest/gtest.h>
#include <iostream>
#include <string>

class LinkedListTest : public ::testing::Test 
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST_F(LinkedListTest, check_count_of_nodes)
{
	LinkedList<int> ll0;

	EXPECT_EQ(ll0.count(), 0) << "count should be 0";

	LinkedList<int> ll1;
	ll1.append(0);

	EXPECT_EQ(ll1.count(), 1) << "count should be 1";

	LinkedList<int> ll2;
	ll2.append(0).append(1);

	EXPECT_EQ(ll2.count(), 2) << "count should be 2";
}

TEST_F(LinkedListTest, clear_linked_lists)
{
	LinkedList<int> ll0;
	ll0.append(0).append(1);
	ll0.clear();

	LinkedList<int> ll1;

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << "should be equal";
}

TEST_F(LinkedListTest, compare_linked_lists_with_equal_operator)
{
	LinkedList<int> ll0;
	ll0.append(0);

	LinkedList<int> ll1;
	ll1.append(0);

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";

	LinkedList<int> ll2;
	ll2.append(0);

	LinkedList<int> ll3;
	ll3.append(1);

	EXPECT_FALSE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should not be equal";

	LinkedList<int> ll4;

	LinkedList<int> ll5;
	ll5.append(0);

	EXPECT_FALSE(ll4 == ll5) << ll4.print() << " and " << ll5.print() << " should not be equal";

	LinkedList<int> ll6;
	ll6.append(0);
	
	LinkedList<int> ll7;

	EXPECT_FALSE(ll6 == ll7) << ll6.print() << " and " << ll7.print() << " should not be equal";

	LinkedList<int> ll8;
	ll8.append(0).append(1);

	LinkedList<int> ll9;
	ll9.append(2).append(3);

	EXPECT_FALSE(ll8 == ll9) << ll8.print() << " and " << ll9.print() << " should not be equal";

	LinkedList<int> ll10;
	
	LinkedList<int> ll11;

	EXPECT_TRUE(ll10 == ll11) << ll10.print() << " and " << ll11.print() << " should be equal";	

	LinkedList<int> ll12;
	ll12.append(0);

	LinkedList<int> ll13;
	ll13.append(0).append(1);

	EXPECT_FALSE(ll12 == ll13) << ll12.print() << " and " << ll13.print() << " should not be equal";	
}

TEST_F(LinkedListTest, compare_linked_lists_with_not_equal_operator)
{
	LinkedList<int> ll0;

	LinkedList<int> ll1;

	EXPECT_FALSE(ll0 != ll1) << ll0.print() << " and " << ll1.print() << " should be equal";

	LinkedList<int> ll2;
	ll2.append(0);

	LinkedList<int> ll3;

	EXPECT_TRUE(ll2 != ll3) << ll2.print() << " and " << ll3.print() << " should not be equal";

	LinkedList<int> ll4;

	LinkedList<int> ll5;
	ll5.append(0);

	EXPECT_TRUE(ll4 != ll5) << ll4.print() << " and " << ll5.print() << " should not be equal";	
}

TEST_F(LinkedListTest, check_if_linked_lists_are_empty)
{
	LinkedList<int> ll0;
	EXPECT_TRUE(ll0.empty()) << "linked list should be empty";

	LinkedList<int> ll1;
	ll1.append(0);
	EXPECT_FALSE(ll1.empty()) << "linked list should not be empty";	
}

TEST_F(LinkedListTest, append_elements_to_linked_list)
{
	LinkedList<int> ll0;
	ll0.append(0);
	
	LinkedList<int> ll1;
	ll1.append(0);

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";	

	LinkedList<int> ll2;
	ll2.append(0).append(1);

	LinkedList<int> ll3;
	ll3.append(0).append(1);

	EXPECT_TRUE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should be equal";	

	LinkedList<int> ll4;
	ll4.append(0).append(1).append(2);

	LinkedList<int> ll5;
	ll5.append(0).append(1).append(2);

	EXPECT_TRUE(ll4 == ll5) << ll4.print() << " and " << ll5.print() << " should be equal";	
}

TEST_F(LinkedListTest, remove_from_tail)
{
	LinkedList<int> ll0;
	ll0.append(0).removeFromTail();

	LinkedList<int> ll1;

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";

	LinkedList<int> ll2;
	ll2.append(0).append(1).removeFromTail();

	LinkedList<int> ll3;
	ll3.append(0);

	EXPECT_TRUE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should be equal";
}

TEST_F(LinkedListTest, compare_linked_lists_strings)
{
	LinkedList<std::string> ll0;

	LinkedList<std::string> ll1;

	EXPECT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";

	LinkedList<std::string> ll2;
	ll2.append("a1");

	LinkedList<std::string> ll3;
	ll3.append("a1");

	EXPECT_TRUE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should be equal";

	LinkedList<std::string> ll4;
	ll4.append("a1");
	
	LinkedList<std::string> ll5;
	
	EXPECT_FALSE(ll4 == ll5) << ll4.print() << " and " << ll5.print() << " should be equal";

	LinkedList<std::string> ll6;
	ll6.append("a1").append("a2");

	LinkedList<std::string> ll7;
	ll7.append("a1").append("a2");

	EXPECT_TRUE(ll6 == ll7) << ll6.print() << " and " << ll7.print() << " should be equal";

	LinkedList<std::string> ll8;
	ll8.append("a1");

	LinkedList<std::string> ll9;
	ll9.append("a1").append("a2");

	EXPECT_FALSE(ll8 == ll9) << ll8.print() << " and " << ll9.print() << " should be equal";
}
