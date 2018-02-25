#include <cstdint>
#include <gtest/gtest.h>
#include <cstdint>
#include <string>

#include "reversebits.h"

TEST(ReverseBitsTests, reverseBits)
{
	uint32_t expected; // = 00111001011110000010100101000000;
	uint32_t actual = 2; // = ReverseBits::reverseBits(00000010100101000001111010011100);
	ASSERT_TRUE(expected == actual) << "actual: " + std::to_string(actual);
}
