#ifndef BINARYSEARCHTREENODE_H 
#define BINARYSEARCHTREENODE_H

#include <cstddef>

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
		this->left = NULL;
		this->right = NULL;
		this->data = d;
		this->visited = false;
	}

	void insert(int d)
	{
		if(d < this->data)
		{
			if(this->left == NULL)
			{
				this->left = new BinarySearchTreeNode<T>(d);
			}
			else
			{
				this->left->insert(d);	
			}
		}
		else
		{
			if(this->right == NULL)
			{
				this->right = new BinarySearchTreeNode<T>(d);
			}
			else
			{
				this->right->insert(d);
			}
		}
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
