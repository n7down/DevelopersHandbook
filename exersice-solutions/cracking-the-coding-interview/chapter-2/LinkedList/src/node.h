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
		data = d;
	}
};

#endif;
