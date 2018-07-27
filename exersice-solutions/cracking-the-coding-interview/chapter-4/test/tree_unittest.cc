#include "tree.h"

#include <gtest/gtest.h>

class TreeTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST_F(TreeTest, failing_test)
{
	EXPECT_TRUE(false);
}
