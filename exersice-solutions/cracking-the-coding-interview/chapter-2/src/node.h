#ifndef NODE_H
#define NODE_H

#include <string>

template <class T>
class Node
{
private:

public:	
	int data;
	Node<T> *next;
	Node<T> *prev;
	Node(T d) 
	{
		this->data = d;
		this->next = 0;
		this->prev = 0;
	}
};

#endif
