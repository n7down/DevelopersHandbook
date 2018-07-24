#ifndef NODE_H 
#define NODE_H 

template <class T>
class Node 
{
private:

public:
	T d;
	Node<T> *next;

	Node(T data)
	{
		this->d = data;
		this->next = 0;
	}
};

#endif
