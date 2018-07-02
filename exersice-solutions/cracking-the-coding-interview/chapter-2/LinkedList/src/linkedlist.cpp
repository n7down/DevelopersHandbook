#include "node.h"
#include "linkedlist.h"

#include <string>
#include <sstream>

LinkedList::LinkedList()
{
	this->head = NULL;
	this->tail = NULL;
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
	Node *head = this->head;
	ss << "[ ";
	while(head != NULL)
	{
		ss << std::to_string(head->data) << " "; 
		head = head->next;
	}
	ss << "]";
	return ss.str();
}

LinkedList& LinkedList::append(int d)
{
	return *this;
}

void LinkedList::remove(int d)
{}

bool LinkedList::operator ==(const LinkedList &l) const
{
	return false;
}

bool LinkedList::operator !=(const LinkedList &l) const
{
	return false;
}

LinkedList::~LinkedList()
{}
