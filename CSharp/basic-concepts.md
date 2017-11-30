# Basic concepts

## Describe composition over inheritance

## Object oriented design
Object-oriented design is the process of planning a system of interacting objects for the purpose of solving a software problem.

## What garbage collection is and/or memory management
The .NET Framework's garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the common language runtime allocates memory for the object from the managed heap. As long as address space is available in the managed heap, the runtime continues to allocate space for new objects. However, memory is not infinite. Eventually the garbage collector must perform a collection in order to free some memory. The garbage collector's optimizing engine determines the best time to perform a collection, based upon the allocations being made. When the garbage collector performs a collection, it checks for objects in the managed heap that are no longer being used by the application and performs the necessary operations to reclaim their memory.

## What the call stack is vs the heap
The stack is the memory set aside as scratch space for a thread of execution. When a function is called, a block is reserved on the top of the stack for local variables and some bookkeeping data. When that function returns, the block becomes unused and can be used the next time a function is called. The stack is always reserved in a LIFO (last in first out) order; the most recently reserved block is always the next block to be freed. This makes it really simple to keep track of the stack; freeing a block from the stack is nothing more than adjusting one pointer.

The heap is memory set aside for dynamic allocation. Unlike the stack, there's no enforced pattern to the allocation and deallocation of blocks from the heap; you can allocate a block at any time and free it at any time. This makes it much more complex to keep track of which parts of the heap are allocated or free at any given time; there are many custom heap allocators available to tune heap performance for different usage patterns.

## Can describe basic programming constructs and idioms regardless of language:

### Branching

### Boolean Logic

### Looping

### Scope

### Functions

### Static vs Non-Static
A static variables belonging to the class is not an instances of the class.

If, in all instances of the class this variable should be identical, use a static variable.

If not, use an instance variable.

A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated. In other words, you cannot use the new keyword to create a variable of the class type.

### Variables and variable binding

### Declaration vs initialization vs instantiation

### Data types

### What they are, what are they used for

### Casting or coercing types into other types

### Generics (C#)
Generics allow you to delay the specification of the data type of programming elements in a class or a method, until it is actually used in the program. In other words, generics allow you to write a class or method that can work with any data type.

You write the specifications for the class or the method, with substitute parameters for data types. When the compiler encounters a constructor for the class or a function call for the method, it generates code to handle the specific data type. A simple example would help understanding the concept:

```
using System;
using System.Collections.Generic;

namespace GenericApplication
{
   public class MyGenericArray<T>
   {
      private T[] array;
      public MyGenericArray(int size)
      {
         array = new T[size + 1];
      }

      public T getItem(int index)
      {
         return array[index];
      }

      public void setItem(int index, T value)
      {
         array[index] = value;
      }
   }

   class Tester
   {
      static void Main(string[] args)
      {

         //declaring an int array
         MyGenericArray<int> intArray = new MyGenericArray<int>(5);

         //setting values
         for (int c = 0; c < 5; c++)
         {
            intArray.setItem(c, c*5);
         }

         //retrieving the values
         for (int c = 0; c < 5; c++)
         {
            Console.Write(intArray.getItem(c) + " ");
         }

         Console.WriteLine();

         //declaring a character array
         MyGenericArray<char> charArray = new MyGenericArray<char>(5);

         //setting values
         for (int c = 0; c < 5; c++)
         {
            charArray.setItem(c, (char)(c+97));
         }

         //retrieving the values
         for (int c = 0; c< 5; c++)
         {
            Console.Write(charArray.getItem(c) + " ");
         }
         Console.WriteLine();

         Console.ReadKey();
      }
   }
}
```
### LINQ / Function composition
A Microsoft .NET Framework component that adds native data querying capabilities to .NET languages

### Strong vs Weak typing
Weak and Strong Typing can be often be confused with dynamic and static languages. Weak typed languages can lead to philosophical questions like what does the number 2 added to the word ‘two’ give you? Things like this are possible with a weak typed language.

```
a = 2
b = "2"

concatenate(a, b) // Returns "22"
add(a, b) // Returns 4
```

Traditionally languages may place restriction on what transaction may occur for example in a strong typed language adding a string and integer will result in a type error as shown below.

```
>>> a = 10
>>> b = 'ten'
>>> a + b
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
TypeError: unsupported operand type(s) for +: 'int' and 'str'
>>>
```

### Static vs Dynamic Languages
Dynamic languages are languages that don’t necessarily need variables to be declared before they are used. Examples of dynamic languages are Python, Ruby, and PHP. So in dynamic languages the following is possible:

```
num = 10
```

Static languages are languages that variables need to be declared before use and type checking is done at compile time. Examples of static languages include Java, C, and C++. So in static languages the following is enforced:

```
static int awesomeNumber;
awesomeNumber = 10;
```

### Enums (C#)
The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.

### Nullable (C#)
Nullable types are instances of the System.Nullable<T> struct. A nullable type can represent the correct range of values for its underlying value type, plus an additional null value. For example, a Nullable<Int32>, pronounced "Nullable of Int32," can be assigned any value from -2147483648 to 2147483647, or it can be assigned the null value. A Nullable<bool> can be assigned the values truefalse, or null. The ability to assign null to numeric and Boolean types is especially useful when you are dealing with databases and other data types that contain elements that may not be assigned a value. For example, a Boolean field in a database can store the values true or false, or it may be undefined.

```
class NullableExample
{
    static void Main()
    {
        int? num = null;

        // Is the HasValue property true?
        if (num.HasValue)
        {
            System.Console.WriteLine("num = " + num.Value);
        }
        else
        {
            System.Console.WriteLine("num = Null");
        }

        // y is set to zero
        int y = num.GetValueOrDefault();

        // num.Value throws an InvalidOperationException if num.HasValue is false
        try
        {
            y = num.Value;
        }
        catch (System.InvalidOperationException e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}
```

### Kinds of equality