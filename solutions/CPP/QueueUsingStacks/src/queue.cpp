#include "queue.h"

void Queue::update()
{
	if(b.size() == 0)
	{
		while(a.size() > 0)
		{
			int d = a.top();
			a.pop();
			b.push(d);
		}
	}
}

int Queue::top()
{
	update();
	return b.top();
}

void Queue::enqueue(int i)
{
	a.push(i);
}

int Queue::dequeue()
{
	update();
	int r = b.top();
	b.pop();
	return r;
}

int Queue::size()
{
	return a.size() + b.size();
}
