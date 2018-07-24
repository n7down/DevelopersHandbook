#include "stack.h"

#include <gtest/gtest.h>
#include <string>

class StackTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST(StackTest, failing_test)
{
	EXPECT_TRUE(false);
}

