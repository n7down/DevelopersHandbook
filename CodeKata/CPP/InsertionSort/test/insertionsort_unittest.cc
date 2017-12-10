#include <gtest/gtest.h>
#include <stdexcept>

#include "insertionsort.h"

namespace
{
	TEST(InsertionSort, EmptyArray)
	{
		try {
			int d[] = {};
			InsertionSort::sort(d, 0);
			FAIL() << "expected std::invalid_argument";
		}
		catch(std::invalid_argument const & err) {
			EXPECT_EQ(err.what(), std::string("empty array"));
		}
		catch(...) {
			FAIL() << "expected std::invalid_argument";
		}
	}

	TEST(InsertionSort, ArrayWithOneElement)
	{
		int d[] = { 1 };
		int e[] = { 1 };
		InsertionSort::sort(d, 1);
		ASSERT_TRUE(d == e);
	}

	TEST(InsertionSort, ArrayWithTwoElements)
	{
		int d[] = { 2, 1 };
		int e[] = { 1, 2 };
		InsertionSort::sort(d, 2);
		ASSERT_TRUE(d == e);
	}
}
