#ifndef BINARYSEARCHTREENODE_H 
#define BINARYSEARCHTREENODE_H 

template <class T>
class BinarySearchTreeNode 
{
private:
	bool visited;

public:	
	T data;
	BinarySearchTreeNode<T> *left;
	BinarySearchTreeNode<T> *right;

	BinarySearchTreeNode(T d)
	{
		this->data = d;
		this->visited = false;
	}

	bool isVisited()
	{
		return this->visited;
	}

	void visit()
	{
		this->visited = true;
	}

	void reset()
	{
		visited = false;
	}
};

#endif 
