#include <gtest/gtest.h>
#include <stdexcept>
#include <string>

#include "windowslidingtechnique.h"

TEST(WindowSlidingTechniqueTest, InvalidInput)
{
	int i[] = { 2, 3 };
	int k = 3;
	int s = 2;
	ASSERT_THROW(WindowSlidingTechnique::maxSum(i, s, k), std::invalid_argument);
}

TEST(WindowSlidingTechniqueTest, MaxSumWhereKIs2)
{
	int i[] = { 100, 200, 300, 400 };
	int k = 2;
	int s = 4;
	int e = 700;
	int a = WindowSlidingTechnique::maxSum(i, s, k);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(WindowSlidingTechnique, MaxSumWhereKIs4)
{
	int i[] = { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
	int k = 4;
	int s = 9;
	int e = 39;
	int a = WindowSlidingTechnique::maxSum(i, s, k);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}
