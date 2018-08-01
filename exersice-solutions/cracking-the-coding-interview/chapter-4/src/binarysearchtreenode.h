#ifndef BINARYSEARCHTREENODE_H 
#define BINARYSEARCHTREENODE_H 

template <class T>
class BinarySearchTreeNode 
{
private:
	T data;
	BinarySearchTreeNode<T> *left;
	BinarySearchTreeNode<T> *right;

public:
	BinarySearchTreeNode(T d)
	{
		this->data = d;
	}

	BinarySearchTreeNode<T> *getLeftNode()
	{
		return this->left;
	}

	BinarySearchTreeNode<T> *getRightNode()
	{
		return this->right;
	}

	virtual ~BinarySearchTreeNode();
};

#endif 
