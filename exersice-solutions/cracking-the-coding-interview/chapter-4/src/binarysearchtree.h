#ifndef BINARYSEARCHTREE_H 
#define BINARYSEARCHTREE_H 

#include "binarysearchtreenode.h"

#include <vector>
#include <string>
#include <sstream>

template <class T>
class BinarySearchTree 
{
private:
	BinarySearchTreeNode<T> *root;
	int c;
	
public:
	BinarySearchTree()
	{
		this->root = 0;
		this->c = 0;
	}

	// TODO: create min heap tree
	void insert(T data)
	{
		if(!this->root)
		{
			this->root = new BinarySearchTreeNode<T>(data);
		}
		else
		{
			BinarySearchTreeNode<T> *current = this->root;
			while(current)
			{
				if(data < current->data)
				{
					current = current->getLeftNode();
				}
				else
				{
					current = current->getRightNode();
				}
			}
			current = new BinarySearchTreeNode(data);
		}
		this->c++;
	}

	std::vector<T> depthFirstSearch();

	std::vector<T> breadthFirstSearch();

	T extractMin();

	std::string print();

	virtual ~BinarySearchTree();
};

#endif
