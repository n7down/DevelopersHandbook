#include <gtest/gtest.h>
#include <stdexcept>

#include "windowslidingtechnique.h"

TEST(WindowSlidingTechniqueTest, InvalidInput)
{
	int i[] = { 2, 3 };
	int k = 3;
	int s = 2;
	int e = -1;
	ASSERT_THROW(WindowSlidingTechnique::maxSum(i, s, k), std::invalid_argument);
}
