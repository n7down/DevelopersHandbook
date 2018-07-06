#include "runnertechnique.h"

LinkedList<int> RunnerTechnique::run(LinkedList<int> &l)
{
	Node<int> *n = l.head;
	Node<int> *runner = l.head;

	while(n != NULL)
	{
		n = n->next;
		runner = runner->next->next;
	}
	n = n->next;
	runner = l.head;

	LinkedList<int> r;
	while(n != NULL)
	{
		r.append(runner->data);
		r.append(n->data);
		runner = runner->next;
		n = n->next;
	}
	return r;
}
