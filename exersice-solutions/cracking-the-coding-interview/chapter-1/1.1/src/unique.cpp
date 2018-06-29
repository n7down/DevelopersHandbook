#include "unique.h"

#include <string>
#include <vector>
#include <algorithm>

bool Unique::isUnique(std::string s)
{
	std::vector<char> v;
	for(auto iterator = s.begin(); iterator < s.end(); ++iterator)
	{
		if(std::find(v.begin(), v.end(), *iterator) != v.end())
		{
			return false;
		}
		else
		{
			v.push_back(*iterator);
		}
	}
	return true;
}
