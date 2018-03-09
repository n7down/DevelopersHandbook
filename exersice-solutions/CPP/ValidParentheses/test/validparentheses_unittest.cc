#include "validparentheses.h"

#include <gtest/gtest.h>
#include <string>

TEST(ValidParenthesesTests, isValid)
{
	std::string s = "{}";
	bool actual = ValidParentheses::isValid(s);
	ASSERT_TRUE(actual);

	s = "[]";
	actual = ValidParentheses::isValid(s);
	ASSERT_TRUE(actual);
	
	s = "()";
	actual = ValidParentheses::isValid(s);
	ASSERT_TRUE(actual);
	
	s = "([])";
	actual = ValidParentheses::isValid(s);
	ASSERT_TRUE(actual);

	s = "{{[[(({}))]]}}";
	actual = ValidParentheses::isValid(s);
	ASSERT_TRUE(actual);

	s =  "{}()[]";
	actual = ValidParentheses::isValid(s);
	ASSERT_TRUE(actual);

	s = "{)}";
	actual = ValidParentheses::isValid(s);
	ASSERT_FALSE(actual);

	s = "[)";
	actual = ValidParentheses::isValid(s);
	ASSERT_FALSE(actual);
}
