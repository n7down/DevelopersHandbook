using System;

namespace Enumerable
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string Lastname { get; private set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            Lastname = lastName;
        }

        public bool Equals(Person p)
        {
            if(p.FirstName != FirstName)
            {
                return false;
            }
            if(p.Lastname != Lastname)
            {
                return false;
            }
            return true;
        }
    }
}
