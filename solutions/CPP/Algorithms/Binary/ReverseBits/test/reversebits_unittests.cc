#include <cstdint>
#include <gtest/gtest.h>
#include <cstdint>
#include <string>

#include "reversebits.h"

TEST(ReverseBitsTests, reverseBits)
{
	uint32_t expected = 43261596; 
	uint32_t actual = ReverseBits::reverseBits(964176192);
	ASSERT_TRUE(expected == actual) << "actual: " + std::to_string(actual);
}
