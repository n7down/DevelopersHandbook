#include <string>
#include <stack>

#include "validparentheses.h"

bool ValidParentheses::isValid(std::string s) 
{
	std::stack<char> p;

	for(char& c : s) 
	{
		if(c == '{' || c == '[' || c == '(')
		{
			p.push(c);						
		}
		else
		{
			if(c == '}')
			{
				char r = p.top();
				p.pop();
				if(r != '{')
				{
					return false;
				}
			}

			else if(c == ']')
			{
				char r = p.top();
				p.pop();
				if(r != '[')
				{
					return false;
				}
			}

			else if(c == ')')
			{
				char r = p.top();
				p.pop();
				if(r != '(')
				{
					return false;
				}
			}
		}
	}
	return true;
}
