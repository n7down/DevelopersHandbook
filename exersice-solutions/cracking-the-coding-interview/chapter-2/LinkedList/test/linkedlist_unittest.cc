#include <gtest/gtest.h>

TEST(LinkedList, compare_linked_lists_with_equal_operator)
{}

TEST(LinkedList, compare_linked_lists_with_not_equal_operator)
{}

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
{}

