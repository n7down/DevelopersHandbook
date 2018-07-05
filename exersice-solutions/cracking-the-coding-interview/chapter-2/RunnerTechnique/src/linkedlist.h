#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "node.h"

#include <string>

template <class T>
class LinkedList
{
private:
	Node<T> *head;
	Node<T> *tail;
	int c;
	bool equals(const LinkedList &l) const;
public:
	LinkedList();
	~LinkedList();
	bool empty();
	std::string print();
	LinkedList& append(T d);
	LinkedList& removeFromTail();
	int count();
	bool operator ==(const LinkedList &l) const;
	bool operator !=(const LinkedList &l) const;
};

#endif 
