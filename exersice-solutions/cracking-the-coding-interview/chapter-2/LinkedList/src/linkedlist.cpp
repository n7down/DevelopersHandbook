#include "node.h"
#include "linkedlist.h"

#include <string>
#include <sstream>

LinkedList::LinkedList()
{
	this->head = NULL;
	this->tail = NULL;
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
}

void LinkedList::append(int d)
{
	Node *n = new Node(d);
}

void LinkedList::remove(int d)
{}

bool LinkedList::operator ==(const LinkedList &l) const
{}

LinkedList::~LinkedList()
{}
