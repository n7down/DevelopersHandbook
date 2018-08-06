#ifndef BINARYSEARCHTREE_H 
#define BINARYSEARCHTREE_H 

#include "binarysearchtreenode.h"

#include <vector>
#include <string>
#include <sstream>
#include <queue>
#include <stack>

template <class T>
class BinarySearchTree 
{
private:
	BinarySearchTreeNode<T> *root;
	int c;

	void insert(BinarySearchTreeNode<T> *n, T data)
	{
		if(n == NULL)
		{
			n = new BinarySearchTreeNode<T>(data);
		}
		if(data < n->data)
		{
			insert(n->left, data);
		}
		else
		{
			insert(n->right, data);
		}
	}
	
public:
	BinarySearchTree()
	{
		this->root = NULL;
		this->c = 0;
	}

	void insert(T data)
	{
		insert(this->root, data);
		this->c++;
	}

	void resetAll()
	{
		// TODO: reset all of the nodes in the tree
	}

	std::vector<T> breadthFirstSearch();

	std::vector<T> depthFirstSearch() 
	{
		std::vector<T> r;
		std::stack<BinarySearchTreeNode<T> *> s;
		BinarySearchTreeNode<T> *current = this->root;
		r.push_back(current->data);
		s.push(current);
		current->visit();
		while(!s.empty())
		{
			BinarySearchTreeNode<T> *v = s.top();
			s.pop();
			BinarySearchTreeNode<T> *currentLeft = v->left;
			BinarySearchTreeNode<T> *currentRight = v->right;
			if(currentLeft && !currentLeft->isVisited())
			{
				s.push(currentLeft);
				currentLeft->visit();
				r.push_back(currentLeft->data);
			}
			if(currentRight && !currentRight->isVisited())
			{
				s.push(currentRight);
				currentRight->visit();
				r.push_back(currentRight->data);
			}
		}
		resetAll();
		return r;
	}

	T extractMin();

	bool isEquals(BinarySearchTree<T> &t) 
	{
		std::vector<T> r0 = depthFirstSearch();
		std::vector<T> r1 = t.depthFirstSearch();
		if(r0 == r1)
		{
			return true;
		}
		return false;
	}

	bool operator ==(const BinarySearchTree<T> &t) const
	{
		return isEquals(t);
	}

	bool operator !=(const BinarySearchTree<T> &t) const
	{
		return !isEquals(t);
	}	
	
	void destroyTree(BinarySearchTreeNode<T> *l)
	{
		if(l)
		{
			destroyTree(l->left);
			destroyTree(l->right);
			l->left = 0;
			l->right = 0;
			delete l;
		}
	}
	
	std::string print();

	virtual ~BinarySearchTree()
	{
		destroyTree(this->root);
	}
};

#endif
