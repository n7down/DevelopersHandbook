#include <gtest/gtest.h>

#include "num.h"

namespace 
{
	TEST(Num, DefaultConstructor)
	{
		const Num n;
		EXPECT_EQ(0, n.getNum()); 
	}

	TEST(Num, Set)
	{
		const Num n(1);
		EXPECT_EQ(1, n.getNum();
	}
}
