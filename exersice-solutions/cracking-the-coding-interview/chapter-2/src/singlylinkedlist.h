#ifndef SINGLYLINKEDLIST
#define SINGLYLINKEDLIST

#include "singlynode.h"

#include <string>
#include <sstream>

template<class T>
class SinglyLinkedList 
{
private:
	std::string printData(int d)
	{
		return std::to_string(d);
	}

	std::string printData(std::string d)
	{
		return d;
	}

public:
	SinglyNode<T> *head;
	int c;

	SinglyLinkedList()
	{
		this->head = NULL;
		c = 0;
	}
	
	~SinglyLinkedList()
	{
		SinglyNode<T> *n = head;
		while(n)
		{
			SinglyNode<T> *d = n;
			n = n->next;
			delete d;
		}
		this->head = NULL;
		c = 0;

	}
	
	bool equals(const SinglyLinkedList<std::string> &l) const
	{
		SinglyNode<T> *ch = this->head;
		SinglyNode<T> *lh = l.head;

		while(ch && lh)
		{
			std::string chData = ch->data;
			std::string lhData = lh->data;
			if(chData.compare(lhData) != 0)
			{
				return false;
			}

			ch = ch->next;
			lh = lh->next;
		}

		if(ch && !lh)
		{
			return false;
		}

		if(!ch && lh)
		{
			return false;
		}
		return true;
	}

	bool equals(const SinglyLinkedList<int> &l) const
	{
		SinglyNode<T> *ch = this->head;
		SinglyNode<T> *lh = l.head;

		while(ch && lh)
		{
			if(ch->data != lh->data)
			{
				return false;
			}
			
			ch = ch->next;
			lh = lh->next;
		}

		if(ch && !lh)
		{
			return false;
		}

		if(!ch && lh)
		{
			return false;
		}
		return true;
	}

	std::string print()
	{
		std::stringstream ss;
		ss << " [";
		SinglyNode<T> *n = head;
		while(n != NULL)
		{
			ss << printData(n->data) << " ";
			n = n->next;
		}
		ss << "]";
		return ss.str();
	}

	void append(T d)
	{
		SinglyNode<T> *s = new SinglyNode<T>(d);
		SinglyNode<T> *current = this->head;
		if(c == 0)
		{
			head = s;
		}
		else
		{
			while(current)
			{
				current = current->next;
			}
			current->next = s;
		}
		c++;
	}

	void removeFromTail()
	{
		if(c == 1)
		{
			SinglyNode<T> *current;
			this->head = NULL;
		}
		else
		{
			SinglyNode<T> *current;
			SinglyNode<T> *currentPrev;
			current = this->head->next;
			currentPrev = this->head;
			while(current)
			{
				current = current->next;
				currentPrev = currentPrev->next;
			}
			currentPrev->next = NULL;
		}
		c--;
	}

	bool operator ==(const SinglyLinkedList &l) const
	{
		return equals(l);
	}

	bool operator !=(const SinglyLinkedList &l) const
	{
		return !equals(l);
	}
};

#endif 
