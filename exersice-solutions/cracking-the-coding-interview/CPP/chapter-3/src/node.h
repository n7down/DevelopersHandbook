#ifndef NODE_H 
#define NODE_H 

template <class T>
class Node 
{
private:

public:
	T data;
	Node<T> *next;

	Node(T d)
	{
		this->data = d;
		this->next = 0;
	}
};

#endif
