#include <vector>
#include <string>
#include <sstream>
#include <gtest/gtest.h>

#include "countingbits.h"

std::string printVector(std::vector<int> v)
{
	std::stringstream ss;
	ss << "[ ";
	for(std::vector<int>::const_iterator i = v.begin(); i != v.end(); ++i)
	{
		ss << std::to_string(*i);
		ss << " ";
	}
	ss << "]";
	return ss.str();
}

TEST(CountingBitsTest, countBits)
{
	int expectedInts[] = { 0, 1, 1, 2, 1, 2 };
	std::vector<int> expected (expectedInts, expectedInts + sizeof(expectedInts) / sizeof(int));
	std::vector<int> actual = CountingBits::countBits(5);
	ASSERT_TRUE(expected == actual) << "actual: " + printVector(actual);
}
