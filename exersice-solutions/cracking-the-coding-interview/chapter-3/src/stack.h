#ifndef STACK_H 
#define STACK_H

#include "node.h"

#include <string>
#include <excption>
#include <sstream>

template <class T>
class Stack
{
private:
	Node<T> *head;
	T d;
	int c;

public:
	Stack(T data)
	{
		this->head = 0;
		this->d = data;
		this->c = 0;
	}

	bool isEmpty()
	{
		if(c == 0)
		{
			return true;
		}
		return false;
	}

	T pop()
	{
		if(isEmpty)
		{
			// throw exception
		}
		c--;
	}

	void push(T data)
	{
		c++;
	}

	T peek()
	{}

	bool isEqual(Stack<T> s)
	{}

	std::string print()
	{
		Node<T> *current = head;
		std::stringstream ss;
		ss << "[ ";
		while(current != NULL)
		{
			ss << current->data << " ";
			current = current->next;
		}
		ss << "]";
		return ss.str();
	}
};

#endif
