#ifndef STACK_H
#define STACK_H

#include "node.h"

#include <string>
#include <exception>
#include <sstream>

template <class T>
class Stack
{
private:
	Node<T> *head;
	int c;

public:
	Stack()
	{
		this->head = 0;
		this->c = 0;
	}

	bool isEmpty()
	{
		if(c == 0)
		{
			return true;
		}
		return false;
	}

	T pop()
	{
		if(isEmpty())
		{
			throw std::length_error("stack is empty");
		}
		Node<T> *t = this->head;
		T data = t->data;
		this->head = this->head->next;
		t->next = 0;
		delete t;
		c--;
		return data;
	}

	void push(T data)
	{
		Node<T> *n = new Node<T>(data);
		n->next = this->head;
		this->head = n;
		c++;
	}

	T peek()
	{
		if(head == NULL)
		{
			throw std::length_error("stack is empty");
		}
		return head->data;
	}

	bool isEquals(const Stack<T> &l) const
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

	bool operator ==(const Stack &s) const
	{
		return isEquals(s);
	}

	bool operator !=(const Stack &s) const
	{
		return !isEquals(s);
	}

	std::string print()
	{
		Node<T> *current = head;
		std::stringstream ss;
		ss << "[ ";
		while(current)
		{
			ss << current->data << " ";
			current = current->next;
		}
		ss << "]";
		return ss.str();
	}

	~Stack()
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
