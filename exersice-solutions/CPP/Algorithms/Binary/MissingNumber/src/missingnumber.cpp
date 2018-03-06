#include "missingnumber.h"

int MissingNumber::findMissingNumber(int *n, int size)
{
	int missing = size;
	for(int i = 0; i < size; i++)
	{
		missing ^= i ^ n[i];
	}
	return missing;
}
