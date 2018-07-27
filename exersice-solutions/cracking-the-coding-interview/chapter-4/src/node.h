#ifndef NODE_H
#define NODE_H

template <class T>
class Node
{
private:
	T data;
	Node<T> children[];

public:
	Node(T d)
	{
		this->data = d;
		this->children = new Node<T>[2];
	}

	virtual ~Node();
};

#endif 
