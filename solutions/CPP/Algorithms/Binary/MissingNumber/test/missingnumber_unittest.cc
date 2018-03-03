#include <gtest/gtest.h>
#include <string>

#include "missingnumber.h"

TEST(MissingNumberTest, findMissingNumber)
{
	int a[] = { 0, 1, 2, 3, 5, 6 };
	int size = sizeof(a)/sizeof(a[0]);
	int expected = 4;
	int actual = MissingNumber::findMissingNumber(a, size);
	ASSERT_TRUE(expected == actual) << "actual: " + std::to_string(actual);
}
