#include <gtest/gtest.h>
#include <stdexcept>

#include "insertionsort.h"

namespace
{
	bool isEqual(int a[], int b[], int size)
	{
		for(int i = 0; i < size; i++)
		{
			if(a[i] != b[i])
			{
				return false;
			}
		}
		return true;
	}

	TEST(InsertionSortTest, EmptyArray)
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

	TEST(InsertionSortTest, ArrayWithOneElement)
	{
		int d[] = { 1 };
		int e[] = { 1 };
		InsertionSort::sort(d, 1);
		ASSERT_TRUE(isEqual(d, e, 1));
	}

	TEST(InsertionSortTest, ArrayWithTwoElements)
	{
		int d[] = { 2, 1 };
		int e[] = { 1, 2 };
		InsertionSort::sort(d, 2);
		ASSERT_TRUE(isEqual(d, e, 2));
	}
}
