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

void LinkedList::append(int d)
{
	Node *n = new Node(d);
	if(c == 0)
	{
		n->next = NULL;
		n->prev = NULL;
		this->head = n;
		this->tail = n;
	}
	else
	{
		n->next = NULL;
		n->prev = this->tail;
		this->tail->next = n;
		this->tail = n;
	}
	c++;
}

// TODO: implement after append works
// LinkedList& LinkedList::append(int d)
// {}

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
	return false;
}

bool LinkedList::operator !=(const LinkedList &l) const
{
	return false;
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
