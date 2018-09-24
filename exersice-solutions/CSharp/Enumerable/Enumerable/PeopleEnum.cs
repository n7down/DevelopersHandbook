using System;
using System.Collections;
using Enumerable;

public class PeopleEnum : IEnumerator
{
    public Person[] _people;

    public int position = -1;

    public PeopleEnum(Person[] list)
    {
        _people = list;
    }

    public Person Current
    {
        get
        {
            try
            {
                return _people[position];
            }
            catch(IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public bool MoveNext()
    {
        position++;
        return (position < _people.Length);
    }

    public void Reset()
    {
        position = -1;
    }
}