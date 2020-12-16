#include "binarysearchtree.h"

#include <gtest/gtest.h>
#include <vector>
#include <string>
#include <sstream>

class BinarySearchTreeTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

class BinarySearchTreeTestUtils
{
public:
	static std::string printVector(std::vector<int> t)
	{
		std::stringstream ss;
		ss << "[ ";
		for(std::vector<int>::iterator it = t.begin(); it != t.end(); ++it)
		{
			ss << std::to_string(*it);
			ss << " ";
		}
		ss << "]";
		return ss.str();
	}
};

TEST_F(BinarySearchTreeTest, insert_data_into_tree)
{
	BinarySearchTree<int> t;
	t.insert(1);
	t.insert(0);
	t.insert(2);
	std::vector<int> d = t.depthFirstSearch();

	std::vector<int> e;
	e.push_back(1);
	e.push_back(0);
	e.push_back(2);

	EXPECT_TRUE(d == e) << BinarySearchTreeTestUtils::printVector(d) << " and " << BinarySearchTreeTestUtils::printVector(e) << " should be equal";
}

TEST_F(BinarySearchTreeTest, check_breadth_first_search)
{
	EXPECT_TRUE(false);
}

TEST_F(BinarySearchTreeTest, check_depth_first_search)
{
	EXPECT_TRUE(false);
}

TEST_F(BinarySearchTreeTest, check_reset_all)
{
	EXPECT_TRUE(false);
}

TEST_F(BinarySearchTreeTest, check_size_of_tree)
{
	EXPECT_TRUE(false);
}
