#ifndef TREE_H
#define TREE_H

#include "node.h"

template <class T>
class Tree
{
private:
	Node<T> root;
	
public:
	Tree();
	virtual ~Tree();
};

#endif
