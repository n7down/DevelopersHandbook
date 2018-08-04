#include "binarysearchtree.h"

#include <gtest/gtest.h>
#include <vector>

class BinarySearchTreeTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST_F(BinarySearchTreeTest, insert_data_into_tree)
{
	BinarySearchTree<int> t;
	t.insert(1);
	t.insert(0);
	t.insert(2);
}

