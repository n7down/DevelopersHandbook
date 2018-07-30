#ifndef BINARYSEARCHTREENODE_H 
#define BINARYSEARCHTREENODE_H 

template <class T>
class BinarySeachTreeNode 
{
private:
	T data;
	BinarySeachTreeNode<T> children[];

public:
	BinarySeachTreeNode(T d)
	{
		this->data = d;
		this->children = new BinarySeachTreeNode<T>[2];
	}

	virtual ~BinarySeachTreeNode();
};

#endif 
