#ifndef BINARYSEARCHTREENODE_H 
#define BINARYSEARCHTREENODE_H 

template <class T>
class BinarySearchTreeNode 
{
private:
	T data;
	BinarySearchTreeNode<T> children[];

public:
	BinarySearchTreeNode(T d)
	{
		this->data = d;
		this->children = new BinarySearchTreeNode<T>[2];
	}

	BinarySearchTreeNode<T> getLeftNode()
	{
		return children[0];
	}

	BinarySearchTreeNode<T> getRightNode()
	{
		return children[1];
	}

	virtual ~BinarySearchTreeNode();
};

#endif 
