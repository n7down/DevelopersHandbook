#include "node.h"
#include "linkedlist.h"

#include <string>
#include <sstream>

LinkedList::LinkedList()
{
	this->head = NULL;
	this->tail = NULL;
	this->c = 0;
}

bool LinkedList::equals(const LinkedList &l) const
{
	Node *ch = this->head;
	Node *lh = l.head;

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

bool LinkedList::empty()
{
	if(this->head == NULL)
	{
		return true;
	}
	return false; 
}

std::string LinkedList::print()
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

LinkedList& LinkedList::append(int d)
{
	Node *n = new Node(d);
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

LinkedList& LinkedList::removeFromTail()
{
	return *this;
}

void LinkedList::remove(int d)
{}

int LinkedList::count()
{
	return c;
}

bool LinkedList::operator ==(const LinkedList &l) const
{
	return equals(l);	
}

bool LinkedList::operator !=(const LinkedList &l) const
{
	return !equals(l);
}

LinkedList::~LinkedList()
{
	Node *n = head;
	while(n)
	{
		Node *d = n;
		n->prev = NULL;
		n = n->next;
		delete d;
	}
	tail = NULL;
	c = 0;
}
