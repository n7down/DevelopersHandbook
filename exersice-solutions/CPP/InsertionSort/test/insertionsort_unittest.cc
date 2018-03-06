#include <gtest/gtest.h>
#include <stdexcept>
#include <string>
#include <sstream>

#include "insertionsort.h"

namespace
{
	bool isEqual(int a[], int b[], int aSize, int bSize)
	{
		if(aSize != bSize)
		{
			return false;
		}
		for(int i = 0; i < aSize; i++)
		{
			if(a[i] != b[i])
			{
				return false;
			}
		}
		return true;
	}

	std::string printArray(int d[], int size)
	{
		std::stringstream ss;		
		if(size == 0)
		{
			ss <<  "[ ]";
			return ss.str();
		}
		ss << "[ ";
		for(int i = 0; i < size; i++)
		{
			ss << d[i];
			ss << " ";
		}
		ss << "]";
		return ss.str();
	}

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
		int dSize = sizeof(d) / sizeof(int);
		int eSize = sizeof(e) / sizeof(int);
		ASSERT_TRUE(isEqual(d, e, dSize, eSize)) << "expected: " + printArray(e, eSize) + " actual: " + printArray(d, dSize);
	}

	TEST(InsertionSort, ArrayWithTwoElements)
	{
		int d[] = { 2, 1 };
		int e[] = { 1, 2 };
		InsertionSort::sort(d, 2);
		int dSize = sizeof(d) / sizeof(int);
		int eSize = sizeof(e) / sizeof(int);
		ASSERT_TRUE(isEqual(d, e, dSize, eSize)) << "expected: " + printArray(e, eSize) + " actual: " + printArray(d, dSize);
	}
}
