#include <vector>
#include <bitset>

#include "countingbits.h"

std::vector<int> CountingBits::countBits(int num)
{
	std::vector<int> result;
	for(int i = 0; i < num + 1; i++)
	{
		std::bitset<32> b(i);
		result.push_back(b.count());
	}
	return result;
}
