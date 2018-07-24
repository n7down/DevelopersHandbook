#ifndef STACK_H 
#define STACK_H

#include "node.h"

#include <string>

template <class T>
class Stack
{
private:
	Node<T> *head;

public:
	Stack()
	{
		this->head = 0;
	}

	T pop()
	{}

	void push(T data)
	{}

	T peek()
	{}

	bool isEmpty()
	{}

	bool isEqual()
	{}

	std::string print()
	{}
};

#endif
