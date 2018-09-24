using System.Collections;
using Enumerable;

public class People : IEnumerable
{
    private Person[] _people;
    
    public People(Person[] pArray)
    {
        _people = new Person[pArray.Length];
        for(int i = 0; i < pArray.Length; i++) 
        {
            _people[i] = pArray[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator) GetEnumerator();
    }

    public IEnumerator GetEnumerator()
    {
        return new PeopleEnum(_people);
    }
}