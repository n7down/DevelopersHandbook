#include <gtest/gtest.h>
#include <stdexcept>
#include <vector>

#include "insertionsort.h"

namespace
{
	template<typename T, size_t N>
	std::vector<T> arrayToVec(const T (&data)[N] )
	{
	    return std::vector<T>(data, data+N);
	}

	TEST(InsertionSort, EmptyArray)
	{
		try {
			std::vector<int> d;			
			InsertionSort::sort(d);
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
		static const int a[] = { 1 };
		static const int b[] = { 1 };
		std::vector<int> d = arrayToVec(a);
		std::vector<int> e = arrayToVec(b);
		InsertionSort::sort(d);
		ASSERT_TRUE(d == e);
	}

	TEST(InsertionSort, ArrayWithTwoElements)
	{
		static const int a[] = { 2, 1 };
		static const int b[] = { 1, 2 };
		std::vector<int> d = arrayToVec(a);
		std::vector<int> e = arrayToVec(b);
		ASSERT_TRUE(d == e);
	}
}
