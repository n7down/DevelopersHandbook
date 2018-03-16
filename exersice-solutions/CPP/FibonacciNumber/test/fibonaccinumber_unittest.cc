#include "fibonaccinumber.h"

#include <gtest/gtest.h>
#include <string>

TEST(fibonaccinumberTests, fib_where_step_is_0)
{
	int steps = 0;
	int e = 0;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_1)
{
	int steps = 1;
	int e = 1;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_2)
{
	int steps = 2;
	int e = 1;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_3)
{
	int steps = 3;
	int e = 2;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_4)
{
	int steps = 4;
	int e = 3;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_5)
{
	int steps = 5;
	int e = 5;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_6)
{
	int steps = 6;
	int e = 8;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_7)
{
	int steps = 7;
	int e = 13;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_8)
{
	int steps = 8;
	int e = 21;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}

TEST(fibonaccinumberTests, fib_where_step_is_15)
{
	int steps = 15;
	int e = 610;
	int a = FibonacciNumber::fib(steps);
	ASSERT_TRUE(a == e) << "actual: " + std::to_string(a);
}
