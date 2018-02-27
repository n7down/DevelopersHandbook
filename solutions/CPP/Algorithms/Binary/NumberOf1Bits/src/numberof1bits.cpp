#include <string>
#include <bitset>
#include <iostream>

#include "numberof1bits.h"

int NumberOf1Bits::hammingWeight(uint32_t n)
{
	int bits = 0;
	int mask = 1;
	for(int i = 0; i < 32; i++)
	{
		if((n & mask) != 0)
		{
			bits++;
		}
		mask <<= 1;
	}
	return bits;
}
