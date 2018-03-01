#include <bitset>

#include "sum.h"

int Sum::getSum(int a, int b)
{
	int sum = a ^ b;
	int carry = a & b;
	while(carry != 0)
	{
		carry = carry << 1;
		a = sum;
		b = carry;
		sum = a ^ b;
		carry = a & b;
	}
	return sum;
}
