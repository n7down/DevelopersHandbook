#ifndef NODE_H
#define NODE_H

class Node
{
private:
	int data;

public:
	Node *next;
	Node *prev;
	Node(int d)
	{
		data = d;
	}
};

#endif;
