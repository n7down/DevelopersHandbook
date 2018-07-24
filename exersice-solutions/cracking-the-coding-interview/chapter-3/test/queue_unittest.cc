#include "queue.h"

#include <gtest/gtest.h>
#include <string>

class QueueTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST(QueueTest, failing_test)
{
	EXPECT_TRUE(false);
}

