#include <stdexcept>

#include "insertionsort.h"

void InsertionSort::sort(std::vector<int> d)
{
	if(d.size() == 0)
	{
		throw std::invalid_argument("empty array");
	}
}
