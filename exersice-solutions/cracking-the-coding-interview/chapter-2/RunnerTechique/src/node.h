#ifndef NODE_H
#define NODE_H

class Node
{
private:

public:	
	int data;
	Node *next;
	Node *prev;
	Node(int d) 
	{
		this->data = d;
		this->next = 0;
		this->prev = 0;
	}
};

#endif
