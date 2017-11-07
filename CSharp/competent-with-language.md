# Become competent C#

## Notes

### 2016.11.07

#### Look into alternative ways to apply composition or inheritance instead of just classical polymorphism

#### What is cyclomatic complexity?

#### Nesting scope and access to modified closures, define a closure

#### Static vs non static why use one over the other

#### Difference between const and readonly and nothing and why you would use them

#### What is type coercion

#### Difference between compilation and runtime of Strong/Weak Typing and Static/Dynamic Languages

#### Look into covariance vs contravariance

#### LINQ Lazy nature

#### Nullables and Monads

#### Boxing and Uboxing
- [link](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)

## C-Sharp

### Delegates
C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.

Example:
```cs
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
   class TestDelegate
   {
      static int num = 10;
      public static int AddNum(int p)
      {
         num += p;
         return num;
      }

      public static int MultNum(int q)
      {
         num *= q;
         return num;
      }
      public static int getNum()
      {
         return num;
      }

      static void Main(string[] args)
      {
         //create delegate instances
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);

         //calling the methods using the delegate objects
         nc1(25);
         Console.WriteLine("Value of Num: {0}", getNum());
         nc2(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
```
### Lambdas
A lambda expression is an anonymous function that you can use to create delegates or expression tree types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.
To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator =>, and you put the expression or statement block on the other side. For example, the lambda expression x => x * x specifies a parameter that’s named x and returns the value of x squared. You can assign this expression to a delegate type, as the following example shows:

```cs
delegate int del(int i);
static void Main(string[] args)
{
    del myDelegate = x => x * x;
    int j = myDelegate(5); //j = 25
}
```

#### Benefits

Lambda expressions should be short. A complex definition makes the calling code difficult to read.

Lambda basic definition: Parameters => Executed code

What is a Lambda Expression?
- Reduced typing. No need to specify the name of the function, its return type, and its access modifier.
- When reading the code, you don't need to look elsewhere for the method's definition.

```cs
List<int> numbers = new List<int>{11,37,52};
List<int> oddNumbers = numbers.where(n => n % 2 == 1).ToList();
//Now oddNumbers is equal to 11 and 37
```

### Async / Await
The async and await keywords in C# are the heart of async programming. By using those two keywords, you can use resources in the .NET Framework or the Windows Runtime to create an asynchronous method almost as easily as you create a synchronous method. Asynchronous methods that you define by using async and await are referred to as async methods.

When using async and await the compiler generates a state machine in the background.

Here's an example on which I hope I can explain some of the high-level details that are going on:
```cs
public async Task MyMethodAsync()
{
    Task<int> longRunningTask = LongRunningOperationAsync();
    // independent work which doesn't need the result of LongRunningOperationAsync can be done here

    //and now we call await on the task
    int result = await longRunningTask;
    //use the result
    Console.WriteLine(result);
}

public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation
{
    await Task.Delay(1000); //1 seconds delay
    return 1;
}
```
Ok, so what happens here:

1. Task<int> longRunningTask = LongRunningOperationAsync(); starts executing LongRunningOperation
independent work is done on let's assume the Main Thread (Thread ID = 1) then await longRunningTask is reached.
2. Now, if the longRunningTask hasn't finished and it is still running, MyMethodAsync() will return to its calling method, thus the main thread doesn't get blocked. When the longRunningTask is done then a thread from the ThreadPool (can be any thread) will return to MyMethodAsync() in its previous context and continue execution (in this case printing the result to the console).

A second case would be that the longRunningTask has already finished its execution and the result is available. When reaching the await longRunningTaskwe already have the result so the code will continue executing on the very same thread. (in this case printing result to console). Of course this is not the case for the above example, where there's a Task.Delay(1000) involved.

### Tasks
Task Parallelism (Task Parallel Library)

.NET Framework (current version) Other Versions

The Task Parallel Library (TPL) is based on the concept of a task, which represents an asynchronous operation. In some ways, a task resembles a thread or ThreadPool work item, but at a higher level of abstraction. The term task parallelism refers to one or more independent tasks running concurrently. Tasks provide two primary benefits:
- More efficient and more scalable use of system resources.

Behind the scenes, tasks are queued to the ThreadPool, which has been enhanced with algorithms that determine and adjust to the number of threads and that provide load balancing to maximize throughput. This makes tasks relatively lightweight, and you can create many of them to enable fine-grained parallelism.
- More programmatic control than is possible with a thread or work item.

Tasks and the framework built around them provide a rich set of APIs that support waiting, cancellation, continuations, robust exception handling, detailed status, custom scheduling, and more.

#### Creating and running tasks explicitly
A task that does not return a value is represented by the System.Threading.Tasks.Task class. A task that returns a value is represented by the System.Threading.Tasks.Task<TResult> class, which inherits from Task. The task object handles the infrastructure details and provides methods and properties that are accessible from the calling thread throughout the lifetime of the task. For example, you can access the Status property of a task at any time to determine whether it has started running, ran to completion, was canceled, or has thrown an exception. The status is represented by a TaskStatus enumeration.
When you create a task, you give it a user delegate that encapsulates the code that the task will execute. The delegate can be expressed as a named delegate, an anonymous method, or a lambda expression. Lambda expressions can contain a call to a named method, as shown in the following example. Note that the example includes a call to the Task.Wait method to ensure that the task completes execution before the console mode application ends.

```cs
using System;
using System.Threading;
using System.Threading.Tasks;

public class Example
{
   public static void Main()
   {
      Thread.CurrentThread.Name = "Main";

        // Create a task and supply a user delegate by using a lambda expression.
        Task taskA = new Task( () => Console.WriteLine("Hello from taskA."));
        // Start the task.
        taskA.Start();

        // Output a message from the calling thread.
        Console.WriteLine("Hello from thread '{0}'.",
                          Thread.CurrentThread.Name);
        taskA.Wait();
   }
}
// The example displays output like the following:
//       Hello from thread 'Main'.
//       Hello from taskA.
```
### Dynamic
The dynamic type enables the operations in which it occurs to bypass compile-time type checking. Instead, these operations are resolved at run time. The dynamic type simplifies access to COM APIs such as the Office Automation APIs, and also to dynamic APIs such as IronPython libraries, and to the HTML Document Object Model (DOM).

Type dynamic behaves like type object in most circumstances. However, operations that contain expressions of type dynamic are not resolved or type checked by the compiler. The compiler packages together information about the operation, and that information is later used to evaluate the operation at run time. As part of the process, variables of type dynamic are compiled into variables of type object. Therefore, type dynamic exists only at compile time, not at run time.

The following example contrasts a variable of type dynamic to a variable of type object. To verify the type of each variable at compile time, place the mouse pointer over dyn or obj in the WriteLine statements. IntelliSense shows dynamic for dyn and object for obj.
```cs
class Program
{
    static void Main(string[] args)
    {
        dynamic dyn = 1;
        object obj = 1;

        // Rest the mouse pointer over dyn and obj to see their
        // types at compile time.
        System.Console.WriteLine(dyn.GetType());
        System.Console.WriteLine(obj.GetType());
    }
}
```

### Attributes
Attributes provide a powerful method of associating declarative information with C# code (types, methods, properties, and so forth). Once associated with a program entity, the attribute can be queried at run time and used in any number of ways.

Example usage of attributes includes:
- Associating help documentation with program entities (through a Help attribute).
- Associating value editors to a specific type in a GUI framework (through a ValueEditor attribute).

Example:
```cs
// AttributesTutorial.cs
// This example shows the use of class and method attributes.

using System;
using System.Reflection;
using System.Collections;

// The IsTested class is a user-defined custom attribute class.
// It can be applied to any declaration including
//  - types (struct, class, enum, delegate)
//  - members (methods, fields, events, properties, indexers)
// It is used with no arguments.
public class IsTestedAttribute : Attribute
{
    public override string ToString()
    {
        return "Is Tested";
    }
}

// The AuthorAttribute class is a user-defined attribute class.
// It can be applied to classes and struct declarations only.
// It takes one unnamed string argument (the author's name).
// It has one optional named argument Version, which is of type int.
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AuthorAttribute : Attribute
{
    // This constructor specifies the unnamed arguments to the attribute class.
    public AuthorAttribute(string name)
    {
        this.name = name;
        this.version = 0;
    }

    // This property is readonly (it has no set accessor)
    // so it cannot be used as a named argument to this attribute.
    public string Name
    {
        get
        {
            return name;
        }
    }

    // This property is read-write (it has a set accessor)
    // so it can be used as a named argument when using this
    // class as an attribute class.
    public int Version
    {
        get
        {
            return version;
        }
        set
        {
            version = value;
        }
    }

    public override string ToString()
    {
        string value = "Author : " + Name;
        if (version != 0)
        {
            value += " Version : " + Version.ToString();
        }
        return value;
    }

    private string name;
    private int version;
}

// Here you attach the AuthorAttribute user-defined custom attribute to
// the Account class. The unnamed string argument is passed to the
// AuthorAttribute class's constructor when creating the attributes.
[Author("Joe Programmer")]
class Account
{
    // Attach the IsTestedAttribute custom attribute to this method.
    [IsTested]
    public void AddOrder(Order orderToAdd)
    {
        orders.Add(orderToAdd);
    }

    private ArrayList orders = new ArrayList();
}

// Attach the AuthorAttribute and IsTestedAttribute custom attributes
// to this class.
// Note the use of the 'Version' named argument to the AuthorAttribute.
[Author("Jane Programmer", Version = 2), IsTested()]
class Order
{
    // add stuff here ...
}

class MainClass
{
   private static bool IsMemberTested(MemberInfo member)
   {
        foreach (object attribute in member.GetCustomAttributes(true))
        {
            if (attribute is IsTestedAttribute)
            {
               return true;
            }
        }
      return false;
   }

    private static void DumpAttributes(MemberInfo member)
    {
        Console.WriteLine("Attributes for : " + member.Name);
        foreach (object attribute in member.GetCustomAttributes(true))
        {
            Console.WriteLine(attribute);
        }
    }

    public static void Main()
    {
        // display attributes for Account class
        DumpAttributes(typeof(Account));

        // display list of tested members
        foreach (MethodInfo method in (typeof(Account)).GetMethods())
        {
            if (IsMemberTested(method))
            {
               Console.WriteLine("Member {0} is tested!", method.Name);
            }
            else
            {
               Console.WriteLine("Member {0} is NOT tested!", method.Name);
            }
        }
        Console.WriteLine();

        // display attributes for Order class
        DumpAttributes(typeof(Order));

        // display attributes for methods on the Order class
        foreach (MethodInfo method in (typeof(Order)).GetMethods())
        {
           if (IsMemberTested(method))
           {
               Console.WriteLine("Member {0} is tested!", method.Name);
           }
           else
           {
               Console.WriteLine("Member {0} is NOT tested!", method.Name);
           }
        }
        Console.WriteLine();
    }
}
```

Output:
```cs
Attributes for : Account
Author : Joe Programmer
Member GetHashCode is NOT tested!
Member Equals is NOT tested!
Member ToString is NOT tested!
Member AddOrder is tested!
Member GetType is NOT tested!

Attributes for : Order
Author : Jane Programmer Version : 2
Is Tested
Member GetHashCode is NOT tested!
Member Equals is NOT tested!
Member ToString is NOT tested!
Member GetType is NOT tested!
```
### Reflection
Reflection provides objects (of type Type) that describe assemblies, modules and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties. If you are using attributes in your code, reflection enables you to access them.

```cs
// Using GetType to obtain type information:
int i = 42;
System.Type type = i.GetType();
System.Console.WriteLine(type);
```
### Garbage Collection
The .NET Framework's garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the common language runtime allocates memory for the object from the managed heap. As long as address space is available in the managed heap, the runtime continues to allocate space for new objects. However, memory is not infinite. Eventually the garbage collector must perform a collection in order to free some memory. The garbage collector's optimizing engine determines the best time to perform a collection, based upon the allocations being made. When the garbage collector performs a collection, it checks for objects in the managed heap that are no longer being used by the application and performs the necessary operations to reclaim their memory.

### Anonymous types / Object and Array initializers

#### Anonymous types
Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first. The type name is generated by the compiler and is not available at the source code level. The type of each property is inferred by the compiler.

```cs
var v = new { Amount = 108, Message = "Hello" };  

// Rest the mouse pointer over v.Amount and v.Message in the following  
// statement to verify that their inferred types are int and string.  
Console.WriteLine(v.Amount + v.Message);  
```

#### Object and Array initializers
This example shows three different ways to initialize different kinds of arrays: single-dimensional, multidimensional, and jagged:

```cs
// Single-dimensional array (numbers).
int[] n1 = new int[4] {2, 4, 6, 8};
int[] n2 = new int[] {2, 4, 6, 8};
int[] n3 = {2, 4, 6, 8};
// Single-dimensional array (strings).
string[] s1 = new string[3] {"John", "Paul", "Mary"};
string[] s2 = new string[] {"John", "Paul", "Mary"};
string[] s3 = {"John", "Paul", "Mary"};

// Multidimensional array.
int[,] n4 = new int[3, 2] { {1, 2}, {3, 4}, {5, 6} };
int[,] n5 = new int[,] { {1, 2}, {3, 4}, {5, 6} };
int[,] n6 = { {1, 2}, {3, 4}, {5, 6} };

// Jagged array.
int[][] n7 = new int[2][] { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
int[][] n8 = new int[][] { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
int[][] n9 = { new int[] {2,4,6}, new int[] {1,3,5,7,9} };
```


### Serialization
Serialization is the process of converting an object into a stream of bytes in order to store the object or transmit it to memory, a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed. The reverse process is called deserialization.

The easiest way to make a class serializable is to mark it with the SerializableAttribute as follows:
```cs
[Serializable]  
public class MyObject {  
  public int n1 = 0;  
  public int n2 = 0;  
  public String str = null;  
}  
```

### Standard language keywords
Keywords are predefined, reserved identifiers that have special meanings to the compiler. They cannot be used as identifiers in your program unless they include @ as a prefix. For example, @if is a valid identifier but if is not because if is a keyword:

```cs
abstract
as
base
bool
break
byte
case
catch
char
checked
class
const
continue
decimal
default
delegate
do
double
else
enum
event
explicit
extern
false
finally
fixed
float
for
foreach
goto
if
implicit
in
in (generic modifier)
int
interface
internal
is
lock
long
namespace
new
null
object
operator
out
out (generic modifier)
override
params
private
protected
public
readonly
ref
return
sbyte
sealed
short
sizeof
stackalloc
static
string
struct
switch
this
throw
true
try
typeof
uint
ulong
unchecked
unsafe
ushort
using
virtual
void
volatile
while
```

## Javascript

### Babel configuration basics
[Babel configuration basics](https://www.twilio.com/blog/2015/08/setting-up-react-for-es6-with-webpack-and-babel-2.html)

#### Stages
Any transforms in stage-x presets are changes to the language that haven’t been approved to be part of a release of Javascript (such as ES6/ES2015).

[Babel plugins](https://babeljs.io/docs/plugins/)

#### .babelrc
Babel will look for a .babelrc in the current directory of the file being transpiled. If one does not exist, it will travel up the directory tree until it finds either a .babelrc, or a package.json with a "babel": {} hash within.

[how to use babelrc](https://babeljs.io/docs/usage/babelrc/)

#### plugins
[Babel plugins](https://babeljs.io/docs/plugins/)

### Promises
A Promise is a proxy for a value not necessarily known when the promise is created. It allows you to associate handlers to an asynchronous action's eventual success value or failure reason. This lets asynchronous methods return values like synchronous methods: instead of the final value, the asynchronous method returns a promise for the value at some point in the future.

A Promise is in one of these states:

pending: initial state, not fulfilled or rejected.
fulfilled: meaning that the operation completed successfully.
rejected: meaning that the operation failed.
A pending promise can either be fulfilled with a value, or rejected with a reason (error). When either of these happens, the associated handlers queued up by a promise's then method are called. (If the promise has already been fulfilled or rejected when a corresponding handler is attached, the handler will be called, so there is no race condition between an asynchronous operation completing and its handlers being attached.)

```
'use strict';
var promiseCount = 0;

function testPromise() {
    var thisPromiseCount = ++promiseCount;

    var log = document.getElementById('log');
    log.insertAdjacentHTML('beforeend', thisPromiseCount +
        ') Started (<small>Sync code started</small>)<br/>');

    // We make a new promise: we promise a numeric count of this promise, starting from 1 (after waiting 3s)
    var p1 = new Promise(
        // The resolver function is called with the ability to resolve or
        // reject the promise
        function(resolve, reject) {
            log.insertAdjacentHTML('beforeend', thisPromiseCount +
                ') Promise started (<small>Async code started</small>)<br/>');
            // This is only an example to create asynchronism
            window.setTimeout(
                function() {
                    // We fulfill the promise !
                    resolve(thisPromiseCount);
                }, Math.random() * 2000 + 1000);
        }
    );

    // We define what to do when the promise is resolved/fulfilled with the then() call,
    // and the catch() method defines what to do if the promise is rejected.
    p1.then(
        // Log the fulfillment value
        function(val) {
            log.insertAdjacentHTML('beforeend', val +
                ') Promise fulfilled (<small>Async code terminated</small>)<br/>');
        })
    .catch(
        // Log the rejection reason
        function(reason) {
            console.log('Handle rejected promise ('+reason+') here.');
        });

    log.insertAdjacentHTML('beforeend', thisPromiseCount +
        ') Promise made (<small>Sync code terminated</small>)<br/>');
}
```

### Imports
The import statement is used to import functions, objects or primitives that have been exported from an external module, another script, etc.
```
import defaultMember from "module-name";
import * as name from "module-name";
import { member } from "module-name";
import { member as alias } from "module-name";
import { member1 , member2 } from "module-name";
import { member1 , member2 as alias2 , [...] } from "module-name";
import defaultMember, { member [ , [...] ] } from "module-name";
import defaultMember, * as name from "module-name";
import "module-name";
```

### Destructuring
Destructuring is a convenient way of extracting values from data stored in (possibly nested) objects and Arrays. It can be used in locations that receive data (such as the left-hand side of an assignment). How to extract the values is specified via patterns (read on for examples).

[Destructuring](http://exploringjs.com/es6/ch_destructuring.html)

```
const obj = { first: 'Jane', last: 'Doe' };
const {first: f, last: l} = obj;
    // f = 'Jane'; l = 'Doe'

// {prop} is short for {prop: prop}
const {first, last} = obj;
    // first = 'Jane'; last = 'Doe'
```

### Rest spread
This plugin allows Babel to transform rest properties for object destructuring assignment and spread properties for object literals.

[Rest Spread](http://www.datchley.name/es6-rest-spread-defaults-and-destructuring/)

### Hoisting
[Hoisting](http://www.adequatelygood.com/JavaScript-Scoping-and-Hoisting.html)

### Let / const / var

#### Let
The let statement declares a block scope local variable, optionally initializing it to a value.

Let allows you to declare variables that are limited in scope to the block, statement, or expression on which it is used. This is unlike the var keyword, which defines a variable globally, or locally to an entire function regardless of block scope.

[Let](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/let)

#### const
Constants are block-scoped, much like variables defined using the let statement. The value of a constant cannot change through re-assignment, and it can't be redeclared.
This declaration creates a constant that can be either global or local to the function in which it is declared. An initializer for a constant is required; that is, you must specify its value in the same statement in which it's declared (which makes sense, given that it can't be changed later).

The const declaration creates a read-only reference to a value. It does not mean the value it holds is immutable, just that the variable identifier cannot be reassigned. For instance, in case the content is an object, this means the object itself can still be altered.

#### var
The variable statement declares a variable, optionally initializing it to a value.

Variable declarations, wherever they occur, are processed before any code is executed. The scope of a variable declared with var is its current execution context, which is either the enclosing function or, for variables declared outside any function, global.

### Arrow functions
An arrow function expression has a shorter syntax compared to function expressions and does not bind its own this, arguments, super, or new.target. Arrow functions are always anonymous. These function expressions are best suited for non-method functions and they can not be used as constructors.

```
var a = [
  "Hydrogen",
  "Helium",
  "Lithium",
  "Beryl­lium"
];

var a2 = a.map(function(s){ return s.length });

var a3 = a.map( s => s.length );
```

### Classes and Prototypes
Object-oriented to the core, JavaScript features powerful, flexible OOP capabilities. This article starts with an introduction to object-oriented programming, then reviews the JavaScript object model, and finally demonstrates concepts of object-oriented programming in JavaScript. This article does not describe the newer syntax for object-oriented programming in ECMAScript 6.

```
var Person = function (firstName) {
  this.firstName = firstName;
};

Person.prototype.sayHello = function() {
  console.log("Hello, I'm " + this.firstName);
};

var person1 = new Person("Alice");
var person2 = new Person("Bob");

// call the Person sayHello method.
person1.sayHello(); // logs "Hello, I'm Alice"
person2.sayHello(); // logs "Hello, I'm Bob"
```

### The “this” keyword
[This](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/this)

### Object literals and JSON
JavaScript object literal is a comma-separated list of name-value pairs wrapped in curly braces. Object literals encapsulate data, enclosing it in a tidy package. This minimizes the use of global variables which can cause problems when combining code.

The following demonstrates an example object literal:

```
var myObject = {
    sProp: 'some string value',
    numProp: 2,
    bProp: false
};
```

Object literal property values can be of any data type, including array literals, functions, and nested object literals. Here is another object literal example with these property types

```
var Swapper = {
    // an array literal
    images: ["smile.gif", "grim.gif", "frown.gif", "bomb.gif"],
    pos: { // nested object literal
        x: 40,
        y: 300
    },
    onSwap: function() { // function
        // code here
    }
};
```

### Dot notation and bracket notation for accessing fields
[Property accessors](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Property_Accessors)

### Standard language keywords
In JavaScript, some identifiers are reserved words and cannot be used as variables or function names.

```
abstract
arguments
boolean
break
byte
case
catch
char
class*
const
continue
debugger
default
delete
do
double
else
enum*
eval
export*
extends*
false
final
finally
float
for
function
goto
if
implements
import*
in
instanceof
int
interface
let
long
native
new
null
package
private
protected
public
return
short
static
super*
switch
synchronized
this
throw
throws
transient
true
try
typeof
var
void
volatile
while
with
yield
```

### Collections
[Collections](https://msdn.microsoft.com/en-us/library/dn479050(v=vs.94).aspx)