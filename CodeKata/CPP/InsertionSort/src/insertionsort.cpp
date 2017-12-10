#include <stdexcept>

#include "insertionsort.h"

void InsertionSort::sort(int d[], int size)
{
	if(size == 0)
	{
		throw std::invalid_argument("empty array");
	}
}
