#include <cstdint>
#include <gtest/gtest.h>
#include <cstdint>
#include <string>
#include <stdio.h>

#include "reversebits.h"

TEST(ReverseBitsTests, reverseBits)
{
	uint32_t expected = 964176192; 
	uint32_t actual = ReverseBits::reverseBits(43261596);
	ASSERT_TRUE(expected == actual) << "actual: " + std::to_string(actual);
}
