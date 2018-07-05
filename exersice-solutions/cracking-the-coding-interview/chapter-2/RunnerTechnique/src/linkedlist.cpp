#include "node.h"
#include "linkedlist.h"

#include <string>
#include <sstream>

template <typename T>
LinkedList<T>::LinkedList()
{
	this->head = NULL;
	this->tail = NULL;
	this->c = 0;
}

template <typename T>
bool LinkedList<T>::equals(const LinkedList<T> &l) const
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

template <typename T>
bool LinkedList<T>::empty()
{
	if(this->head == NULL)
	{
		return true;
	}
	return false; 
}

template <typename T>
std::string LinkedList<T>::print()
{
	std::stringstream ss;
	ss << "[ ";
	while(this->head != NULL)
	{
		ss << std::to_string(this->head->data) << " "; 
		this->head = this->head->next;
	}
	ss << "]";
	return ss.str();
}

template <typename T>
LinkedList<T>& LinkedList<T>::append(T d)
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

template <typename T>
LinkedList<T>& LinkedList<T>::removeFromTail()
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

template <typename T>
int LinkedList<T>::count()
{
	return c;
}

template <typename T>
bool LinkedList<T>::operator ==(const LinkedList<T> &l) const
{
	return equals(l);	
}

template <typename T>
bool LinkedList<T>::operator !=(const LinkedList<T> &l) const
{
	return !equals(l);
}

template <typename T>
LinkedList<T>::~LinkedList()
{
	Node<T> *n = head;
	while(n)
	{
		Node<T> *d = n;
		n->prev = NULL;
		n = n->next;
		delete d;
	}
	this->tail = NULL;
	c = 0;
}
