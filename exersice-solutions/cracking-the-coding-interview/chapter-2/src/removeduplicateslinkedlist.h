#ifndef REMOVEDUPLICATESLINKEDLIST
#define REMOVEDUPLICATESLINKEDLIST

#include "linkedlist.h"

#include <vector>
#include <algorithm>

template <class T>
class RemoveDuplicatesLinkedList : public LinkedList<T>
{
public:
	void removeDuplicates()
	{
		Node<T> *current = this->head;
		std::vector<T> d;
		while(current)
		{
			T data = current->data;
			if(std::find(d.begin(), d.end(), data) != d.end())
			{
				// TODO: remove the item	
			}
			else
			{
				d.push_back(data);
			}
			current = current->next;
		}
	}

private:
};

#endif 
