#include <gtest/gtest.h>

#include "unique.h"

TEST(Unique, strings_are_not_unique)
{
	std::string s0("test");
	ASSERT_FALSE(Unique::isUnique(s0)) << "'test' is not unique";

	std::string s1("another test");
	ASSERT_FALSE(Unique::isUnique(s1)) << "'another test' is not unique";
}

TEST(Unique, strings_are_unique)
{
	std::string s0("te");
	ASSERT_TRUE(Unique::isUnique(s0)) << "'te' is unique";

	std::string s1("rew");
	ASSERT_TRUE(Unique::isUnique(s1)) << "'rew' is unique";
}
