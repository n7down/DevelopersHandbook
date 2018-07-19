#include "singlylinkedlist.h"

#include <gtest/gtest.h>
#include <string>

class SinglyLinkedListTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST(SinglyLinkedListTest, append_data_to_singly_linked_list)
{
	SinglyLinkedList<int> d;
	d.append(0);
	
	SinglyLinkedList<int> e;
	e.append(0);

	EXPECT_TRUE(d == e) << d.print() << " and " << e.print() << " should be equal";
}

TEST(SinglyLinkedListTest, remove_from_tail_data_from_singly_linked_list)
{
	// TODO: fix this
	SinglyLinkedList<int> d;
	d.append(0);
	d.removeFromTail();
	
	SinglyLinkedList<int> e;

	EXPECT_TRUE(d == e) << d.print() << " and " << e.print() << " should be equal";
}

