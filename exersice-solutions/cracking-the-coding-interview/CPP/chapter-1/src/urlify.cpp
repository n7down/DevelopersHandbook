#include "urlify.h"

#include<string>
#include <regex>

std::string Urlify::urlifyString(std::string s)
{
	s = std::regex_replace(s, std::regex("^ +| +$|( ) +"), "$1");
	s = std::regex_replace(s, std::regex(" "), "%20");
	return s;
}
