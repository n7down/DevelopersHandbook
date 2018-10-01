#include <gtest/gtest.h>

#include "urlify.h"

TEST(Urlify, replace_spaces_with_precent_20)
{
	std::string s0("Mr.    John      Smith     ");
	std::string actual = Urlify::urlifyString(s0);
	std::string expected("Mr.%20John%20Smith");
	ASSERT_TRUE(actual == expected) << actual + " should equal " + expected;
}
