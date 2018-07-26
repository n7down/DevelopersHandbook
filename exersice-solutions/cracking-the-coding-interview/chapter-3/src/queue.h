#ifndef QUEUE_H
#define QUEUE_H

#include "node.h"

#include <string>
#include <sstream>
#include <exception>

template <class T>
class Queue
{
private:
	Node<T> *head;
	Node<T> *tail;
	int c;

public:
	Queue()
	{
		this->head = 0;
		this->tail = 0;
		this->c = 0;
	}

	bool isEmpty() const
	{
		if(c == 0)
		{
			return true;
		}
		return false;
	}

	void add(T data)
	{
		Node<T> *n = new Node<T>(data);
		if(c == 0)
		{
			this->head = n;
			this->tail = n;
		}
		else 
		{
			n->next = head;
			this->head = n;
		}
		c++;
	}

	T remove()
	{
		int data;
		if(c == 0)
		{
			throw std::length_error("queue is empty");
		}
		else if(c == 1)
		{
			Node<T> *current = this->head;
			data = current->data;
			this->head = 0;
			this->tail = 0;
			delete current;
		}

		// TODO: check if c == 2 set head and tail to the same element
	
		else
		{
			Node<T> *current = this->head->next;
			Node<T> *currentPrev = this->head;
			while(current != this->tail)
			{
				current = current->next;
				currentPrev = currentPrev->next;
			}
			currentPrev->next = 0;
			data = current->data;
			delete current;
		}
		c--;
		return data;
	}

	T peek()
	{
		if(this->tail == NULL)
		{
			throw std::length_error("queue is empty");
		}
		return this->tail->data;
	}

	bool isEquals(const Queue<T> &q) const
	{
		Node<T> *ch = this->head;
		Node<T> *lh = q.head;

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

	bool operator ==(const Queue<T> &q) const
	{
		return isEquals(q);
	}

	bool operator !=(const Queue<T> &q) const
	{
		return !isEquals(q);
	}

	std::string print() const
	{
		std::stringstream ss;
		Node<T> *current = this->head;
		ss << "[ ";
		while(current)
		{
			ss << std::to_string(current->data) << " ";
			current = current->next;
		}
		ss << "]";
		return ss.str();
	}

	~Queue()
	{
		Node<T> *current = this->head;
		while(current)
		{
			Node<T> *t = current;
			current = current->next;
			t->next = 0;
			delete t;
		}
	}
};

#endif
