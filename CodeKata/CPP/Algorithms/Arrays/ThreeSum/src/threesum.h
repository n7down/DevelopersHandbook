#ifndef THREESUM_H
#define THREESUM_H

#include <vector>

class Threesum
{
	private:
		std::vector<int> t;

	public:
		static std::vector<std::vector<int> > getThreeSum(std::vector<int>& i);
};

#endif
