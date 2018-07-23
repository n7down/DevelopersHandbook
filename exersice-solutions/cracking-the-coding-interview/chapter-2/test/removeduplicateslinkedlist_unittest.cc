#include "removeduplicateslinkedlist.h"

#include <gtest/gtest.h>
#include <iostream>
#include <string>

class RemoveDuplicatesTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST(RemoveDuplicatesTest, remove_duplicate_nodes_from_linked_list)
{
	// TODO: fix this
	RemoveDuplicatesLinkedList<int> d0;
	d0.append(0).append(0);
	d0.removeDuplicates();

	RemoveDuplicatesLinkedList<int> e0;
	e0.append(0);

	EXPECT_TRUE(d0 == e0) << d0.print() << " and " << e0.print() << " should be equal";

	RemoveDuplicatesLinkedList<int> d1;
	d1.append(0).append(0).append(0);
	d1.removeDuplicates();

	RemoveDuplicatesLinkedList<int> e1;
	e1.append(0);

	EXPECT_TRUE(d1 == e1) << d1.print() << " and " << e1.print() << " should be equal";
}
