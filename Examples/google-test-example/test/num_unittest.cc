#include <gtest/gtest.h>

#include "num.h"

namespace 
{
	TEST(Num, DefaultConstructor)
	{
		Num n;
		EXPECT_EQ(0, n.getNum()); 
	}

	TEST(Num, Set)
	{
		Num n(1);
		EXPECT_EQ(1, n.getNum());
	}
}
