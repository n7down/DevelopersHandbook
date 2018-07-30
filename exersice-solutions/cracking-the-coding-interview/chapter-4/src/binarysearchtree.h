#ifndef BINARYSEARCHTREE_H 
#define BINARYSEARCHTREE_H 

#include "binarysearchtree.h"

#include <vector>

template <class T>
class BinarySearchTree 
{
private:
	BinarySeachTreeNode<T> root;
	
public:
	BinarySearchTree()
	{
		this->root = 0;
	}

	// TODO: create min heap tree
	void insert(T data);

	std::vector<T> depthFirstSearch();

	std::vector<T> breadthFirstSearch();

	T extractMin();

	virtual ~BinarySearchTree();
};

#endif
