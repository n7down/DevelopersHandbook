#include <gtest/gtest.h>

#include "sum.h"

TEST(BinarySumTest, Sum)
{
	int expected = 2;
	int actual = Sum::getSum(1, 1);
	ASSERT_EQ(expected, actual);
}
