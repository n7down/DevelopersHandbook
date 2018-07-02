#include "linkedlist.h"

#include <gtest/gtest.h>

TEST(LinkedList, compare_linked_lists_with_equal_operator)
{
	LinkedList ll0;
	ll0.append(0);

	LinkedList ll1;
	ll1.append(0);

	ASSERT_TRUE(ll0 == ll1) << ll0.print() << " and " << ll1.print() << " should be equal";

	LinkedList ll2;
	ll2.append(0);

	LinkedList ll3;
	ll3.append(1);

	ASSERT_FALSE(ll2 == ll3) << ll2.print() << " and " << ll3.print() << " should not be equal";

	LinkedList ll4;

	LinkedList ll5;
	ll5.append(0);

	ASSERT_FALSE(ll4 == ll5) << ll4.print() << " and " << ll5.print() << " should not be equal";

	LinkedList ll6;
	ll6.append(0);
	
	LinkedList ll7;

	ASSERT_FALSE(ll6 == ll7) << ll6.print() << " and " << ll7.print() << " should not be equal";

	LinkedList ll8;
	ll8.append(0).append(1);

	LinkedList ll9;
	ll9.append(2).append(3);

	ASSERT_FALSE(ll8 == ll9) << ll8.print() << " and " << ll9.print() << " should not be equal";

	LinkedList ll10;
	
	LinkedList ll11;

	ASSERT_TRUE(ll10 == ll11) << ll10.print() << " and " << ll11.print() << " should be equal";
}

TEST(LinkedList, compare_linked_lists_with_not_equal_operator)
{
	LinkedList ll0;

	LinkedList ll1;

	ASSERT_FALSE(ll0 != ll1) << ll0.print() << " and " << ll1.print() << " should be equal";

	LinkedList ll2;
	ll2.append(0);

	LinkedList ll3;

	ASSERT_TRUE(ll2 != ll3) << ll2.print() << " and " << ll3.print() << " should not be equal";

	LinkedList ll4;

	LinkedList ll5;
	ll5.append(0);

	ASSERT_TRUE(ll4 != ll5) << ll4.print() << " and " << ll5.print() << " should not be equal";
}

TEST(LinkedList, check_if_linked_lists_are_empty)
{
	LinkedList ll0;
	ASSERT_TRUE(ll0.empty()) << "linked list should be empty";

	LinkedList ll1;
	ll1.append(0);
	ASSERT_FALSE(ll1.empty()) << "linked list should not be empty";
}

TEST(LinkedList, append_one_element_to_linked_list)
{
	LinkedList ll0;
	ll0.append(0);
	
	LinkedList ll1;
	ll1.append(0);

	ASSERT_TRUE(ll0 == ll1) << "compare ll0 " << ll0.print() << " and ll1 " << ll1.print();
}

TEST(LinkedList, append_two_elements_to_linked_list)
{
	LinkedList ll0;
	ll0.append(0).append(1);

	LinkedList ll1;
	ll1.append(0).append(1);

	ASSERT_TRUE(ll0 == ll1) << "compare ll0 " << ll0.print() << " and ll1 " << ll1.print();
}

TEST(LinkedList, append_three_elements_to_linked_list)
{
	LinkedList ll0;
	ll0.append(0).append(1).append(2);

	LinkedList ll1;
	ll1.append(0).append(1).append(2);

	ASSERT_TRUE(ll0 == ll1) << "compare ll0 " << ll0.print() << " and ll1 " << ll1.print();
}

