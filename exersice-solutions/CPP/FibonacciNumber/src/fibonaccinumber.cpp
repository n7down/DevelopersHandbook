#include "fibonaccinumber.h"

int FibonacciNumber::fib(int steps)
{
	if(steps <= 0)
	{
		return 0;
	}
	else if(steps == 1)
	{
		return 1;
	}
	return fib(steps - 1) + fib(steps - 2);
}
