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
	LinkedList<int> d;
	d.append(0).append(0);
	d.removeDuplicates();

	LinkedList<int> e;
	e.append(0);

	EXPECT_TRUE(d == e) << d.print() " and " e.print() " should be equal";
	
}
