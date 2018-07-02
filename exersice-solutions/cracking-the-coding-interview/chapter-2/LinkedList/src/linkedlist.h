#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "node.h"

#include <string>

class LinkedList
{
private:
	Node *head;
	Node *tail;
public:
	LinkedList();
	~LinkedList();
	std::string print();
	void append(int d);
	void remove(int d);
	bool operator ==(const LinkedList &l) const;
};

#endif 
