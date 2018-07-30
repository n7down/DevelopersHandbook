#include "binarysearchtree.h"

#include <gtest/gtest.h>

class BinarySearchTreeTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST_F(BinarySearchTreeTest, failing_test)
{
	EXPECT_TRUE(false);
}
