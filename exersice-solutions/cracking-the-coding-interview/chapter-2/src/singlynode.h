#ifndef SINGLYNODE_H
#define SINGLYNODE_H

template <class T>
class SinglyNode 
{
private:
	
public:
	T data;
	SinglyNode *next;

	SinglyNode(T d)
	{
		this->data = d;
		this->next = 0;
	}
};

#endif 

