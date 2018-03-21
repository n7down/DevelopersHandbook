#include <stdexcept>

#include "windowslidingtechnique.h"

int WindowSlidingTechnique::maxSum(int i[], int s, int k)
{
	if(s < k)
	{
		throw std::invalid_argument("size is invalid");
	}

	int maxValue = 0;
	int start = 0;
	int end = k;
	do
	{
		int value = 0;
		for(int a = start; a < end; a++)
		{
			value += i[a]; 
		}
		if(value > maxValue)
		{
			maxValue = value;
		}
		start++;
		end++;
	} while(end <= s);

	return maxValue;
}
