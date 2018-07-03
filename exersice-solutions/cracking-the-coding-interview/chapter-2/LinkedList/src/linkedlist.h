#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "node.h"

#include <string>

class LinkedList
{
private:
	Node *head;
	Node *tail;
	int c;
public:
	LinkedList();
	~LinkedList();
	bool empty();
	std::string print();
	LinkedList& append(int d);
	LinkedList& removeFromTail();
	void remove(int d);
	int count();
	bool operator ==(const LinkedList &l) const;
	bool operator !=(const LinkedList &l) const;
};

#endif 
