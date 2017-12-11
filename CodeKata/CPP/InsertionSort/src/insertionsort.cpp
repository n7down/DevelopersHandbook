#include <stdexcept>

#include "insertionsort.h"

void InsertionSort::swap(int d[], int a, int b)
{	
	int tmp = d[a];
	d[a] = d[b];
	d[b] = tmp;
}

void InsertionSort::sort(int d[], int size)
{
	if(size == 0)
	{
		throw std::invalid_argument("empty array");
	}
	int i = 1;
	while(i < size)
	{
		int j = i;
		while(j < 0 && d[j-1] > d[j])
		{
			swap(d, j-1, j);
			j--;
		}
		i++;
	}
}
