#ifndef QUEUE_H
#define QUEUE_H

#include "node.h"

#include <string>

template <class T>
class Queue
{
private:
	Node<T> *head;
	Node<T> *tail;

public:
	Queue()
	{
		this->head = 0;
		this->tail = 0;
	}

	void add(T data)
	{}

	T remove()
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
