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
		int i = 0;
		while(current)
		{
			T data = current->data;
			if(std::find(d.begin(), d.end(), data) != d.end())
			{
				// if the duplicate is the last element
				if(this->count() == i + 1)
				{
					this->removeFromTail();
				}
			}
			else
			{
				d.push_back(data);
			}
			current = current->next;
			i++;
		}
	}

private:
};

#endif 
