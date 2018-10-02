#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "node.h"

#include <string>
#include <sstream>

template <class T>
class LinkedList
{
private:
	int c;
	
	std::string printData(int d)
	{
		return std::to_string(d);
	}

	std::string printData(std::string d)
	{
		return d;
	}
	
public:
	Node<T> *head;
	Node<T> *tail;
	
	LinkedList()
	{
		this->head = NULL;
		this->tail = NULL;
		this->c = 0;
	}

	void clear()
	{
		Node<T> *n = this->head;
		while(n)
		{
			Node<T> *d = n;
			n->prev = NULL;
			n = n->next;
			delete d;
		}
		this->head = NULL;
		this->tail = NULL;
		c = 0;
	}
	
	bool equals(const LinkedList<std::string> &l) const
	{
		Node<T> *ch = this->head;
		Node<T> *lh = l.head;

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

	bool equals(const LinkedList<int> &l) const
	{
		Node<T> *ch = this->head;
		Node<T> *lh = l.head;

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

	bool empty()
	{
		if(this->head == NULL)
		{
			return true;
		}
		return false; 
	}

	std::string print()
	{
		std::stringstream ss;
		ss << "[ ";
		Node<T> *current = this->head;
		while(current != NULL)
		{
			ss << printData(current->data) << " "; 
			current = current->next;
		}
		ss << "]";
		return ss.str();
	}

	LinkedList& append(T d)
	{
		Node<T> *n = new Node<T>(d);
		if(c == 0)
		{
			this->head = n;
			this->tail = n;
		}
		else
		{
			n->prev = this->tail;
			this->tail->next = n;
			this->tail = n;
		}
		c++;

		return *this;
	}

	LinkedList& removeFromTail()
	{
		if(c != 0)
		{
			Node<T> *d = this->tail;
			int v = d->data;
			if(c == 1)
			{
				head = NULL;
				tail = NULL;
			}
			else
			{
				this->tail = tail->prev;
				this->tail->next = NULL;
			}
			delete d;
			c--;
		}
		return *this;
	}

	int count()
	{
		return c;
	}

	bool operator ==(const LinkedList &l) const
	{
		return equals(l);
	}

	bool operator !=(const LinkedList &l) const
	{
		return !equals(l);
	}
	
	~LinkedList()
	{
		clear();	
	}
};

#endif 
