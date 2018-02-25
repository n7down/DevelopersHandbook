#include <gtest/gtest.h>
#include <string>

#include "numberof1bits.h"

TEST(NumberOf1BitsTests, HammingWeight)
{
	int expected = 3;
	int actual = NumberOf1Bits::hammingWeight(00000000000000000000000000001011);
	ASSERT_TRUE(expected == actual) <<  "actual: " + std::to_string(actual);
}
