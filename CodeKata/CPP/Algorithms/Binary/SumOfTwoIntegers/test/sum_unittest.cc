#include <gtest/gtest.h>

#include "sum.h"

TEST(BinarySumTest, Sum1Plus1)
{
	int expected = 2;
	int actual = Sum::getSum(1, 1);
	ASSERT_EQ(expected, actual);
}

TEST(BinarySumTest, Sum2Plus1)
{
	int expected = 3;
	int actual = Sum::getSum(2, 1);
	ASSERT_EQ(expected, actual);

}
