#include <gtest/gtest.h>

#include "permutation.h"

TEST(Permutation, check_permutation_when_permutation_exists)
{
	std::string s0("testtest");
	std::string s1("test");
	ASSERT_TRUE(Permutation::checkPermutation(s0, s1)) << "there is a permutation in 'testtest' with 'test'";

	std::string s2("there is a car");
	std::string s3("car");
	ASSERT_TRUE(Permutation::checkPermutation(s1, s2)) << "there is a permutation in 'there is a car' with 'car'";
}

TEST(Permutation, check_permutation_when_permutation_does_not_exist)
{
	std::string s0("abc");
	std::string s1("def");
	ASSERT_FALSE(Permutation::checkPermutation(s0, s1)) << "there is no permutation with 'abc' and 'def'";

	std::string s2("car");
	std::string s3("desk");
	ASSERT_FALSE(Permutation::checkPermutation(s2, s3)) << "there is no permutation with 'car' and 'desk'";
}
