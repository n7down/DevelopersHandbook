# Technical Interview Review
This repository is designed to organize all of the nessesary material and resources to prepare for a successful technical interview.

# Table of Contents
1. [Big-O](#big-o)
2. [Algorithms](#algorithms)
3. [Languages](#languages)
4. [Source Control](#source-control)

# Big-O
## Big-O Complexity Chart
![big-o-complexity-chart](/Images/big-o-complexity-chart.jpg?raw=true)
## Common Data Structure Operations
Data Structure|Time Complexity| | | | | | | |Space Complexity
---|---|---|---|---|---|---|---|---|---
*|Average|*|*|*|Worst|*|*|*|Worst
*|Access|Serach|Insertion|Deletion|Access|Search|Insertion|Deletion|*
Array|Θ(1)|Θ(n)|Θ(n)|Θ(n)|Θ(1)|Θ(n)|Θ(n)|Θ(n)|Θ(n)
Stack|Θ(n)|Θ(n)|Θ(1)|Θ(1)|O(n)|O(n)|O(1)|O(1)|O(n)
Queue|Θ(n)|Θ(n)|Θ(1)|Θ(1)|O(n)|O(n)|O(1)|O(1)|O(n)
Singly-Linked List|Θ(n)|Θ(n)|Θ(1)|Θ(1)|O(n)|O(n)|O(1)|O(1)|O(n)
Doubly-Linked List|Θ(n)|Θ(n)|Θ(1)|Θ(1)|O(n)|O(n)|O(1)|O(1)|O(n)
Skip List|Θ(log(n))|Θ(log(n))|Θ(log(n))|Θ(log(n))|O(n)|O(n)|O(n)|O(n)|O(n log(n))
Hash Table|N/A|Θ(1)|Θ(1)|Θ(1)|N/A|O(n)|O(n)|O(n)|O(n)
Binary Search Tree|Θ(log(n))|Θ(log(n))|Θ(log(n))|Θ(log(n))|O(n)|O(n)|O(n)|O(n)|O(n)
Cartesian Tree|N/A|Θ(log(n))|Θ(log(n))|Θ(log(n))|N/A|O(n)|O(n)|O(n)|O(n)
B-Tree|Θ(log(n))|Θ(log(n))|Θ(log(n))|Θ(log(n))|O(log(n))|O(log(n))|O(log(n))|O(log(n))|O(n)
Red-Black Tree|Θ(log(n))|Θ(log(n))|Θ(log(n))|Θ(log(n))|O(log(n))|O(log(n))|O(log(n))|O(log(n))|O(n)
Splay Tree|N/A|Θ(log(n))|Θ(log(n))|Θ(log(n))|N/A|O(log(n))|O(log(n))|O(log(n))|O(n)
AVL Tree|Θ(log(n))|Θ(log(n))|Θ(log(n))|Θ(log(n))|O(log(n))|O(log(n))|O(log(n))|O(log(n))|O(n)
KD Tree|Θ(log(n))|Θ(log(n))|Θ(log(n))|Θ(log(n))|O(n)|O(n)|O(n)|O(n)|O(n)

## Array Sorting Algorithms
Algorithm|Time Complexity| | |Space Complexity
---|---|---|---|---
*|Best|Average|Worst|Worst
Quicksort|Ω(n log(n))|Θ(n log(n))|O(n^2)|O(log(n))
Mergesort|Ω(n log(n))|Θ(n log(n))|O(n log(n))|O(n)
Timsort|Ω(n)|Θ(n log(n))|O(n log(n))|O(n)
Heapsort|Ω(n log(n))|Θ(n log(n))|O(n log(n))|O(1)
Bubble Sort|Ω(n)|Θ(n^2)|O(n^2)|O(1)
Insertion|Ω(n)|Θ(n^2)|O(n^2)|O(1)
Selection Sort|Ω(n^2)|Θ(n^2)|O(n^2)|O(1)
Tree Sort|Ω(n log(n))|Θ(n log(n))|O(n^2)|O(n)
Shell Sort|Ω(n log(n))|Θ(n(log(n))^2)|O(n(log(n))^2)|O(1)
Bucket Sort|Ω(n+k)|Θ(n+k)|O(n^2)|O(n)
Radix Sort|Ω(nk)|Θ(nk)|O(nk)|O(n+k)
Counting Sort|Ω(n+k)|Θ(n+k)|O(n+k)|O(k)
Cubesort|Ω(n)|Θ(n log(n))|O(n log(n))|O(n)

# Data Structures
- [ ] Stack
- [ ] Queue
- [ ] Singly-Linked List
- [ ] Doubly-Linked List
- [ ] Skip List
- [ ] Hash Table
- [ ] Binary Search Tree
- [ ] Cartesian Tree
- [ ] B-Tree
- [ ] Red-Black Tree
- [ ] Splay Tree
- [ ] AVL Tree
- [ ] KD Tree

# Design Patterns
## Creational
- [ ] Abstract Factory
    - Creates an instance of several families of classes
- [ ] Builder
    - Separates object construction from its representation
- [ ] Factory Method
    - Creates an instance of several derived classes
- [ ] Object Pool
     - Avoid expensive acquisition and release of resources by recycling objects that are no longer in use
- [ ] Prototype
     - A fully initialized instance to be copied or cloned
- [ ] Singleton
     - A class of which only a single instance can exist

## Structural
- [ ] Adapter
     - Match interfaces of different classes
- [ ] Bridge
     - Separates an object’s interface from its implementation
- [ ] Composite
     - A tree structure of simple and composite objects
- [ ] Decorator
    - Add responsibilities to objects dynamically
- [ ] Facade
    - A single class that represents an entire subsystem
- [ ] Flyweight
     - A fine-grained instance used for efficient sharing
- [ ] Private Class Data
     - Restricts accessor/mutator access
- [ ] Proxy
    - An object representing another object

## Behavior
- [ ] Chain of responsibility
     - A way of passing a request between a chain of objects
- [ ] Command
     - Encapsulate a command request as an object
- [ ] Interpreter
     - A way to include language elements in a program
- [ ] Iterator
     - Sequentially access the elements of a collection
- [ ] Mediator
     - Defines simplified communication between classes
- [ ] Memento
    - Capture and restore an object's internal state
- [ ] Null Object
     - Designed to act as a default value of an object
- [ ] Observer
    - A way of notifying change to a number of classes
- [ ] State
     - Alter an object's behavior when its state changes
- [ ] Strategy
    - Encapsulates an algorithm inside a class
- [ ] Template method
    - Defer the exact steps of an algorithm to a subclass
- [ ] Visitor
    - Defines a new operation to a class without change

# Algorithms
## General Tips
- [x] Quicksort
- [x] Mergesort
- [ ] Timsort
- [ ] Heapsort
- [ ] Bubble Sort
- [x] Insertion Sort
- [ ] Selection Sort
- [ ] Tree Sort
- [ ] Shell Sort
- [ ] Bucket Sort
- [ ] Radix Sort
- [ ] Counting Sort
- [ ] Cubesort
## Misc
Understand the substring template with the following: [template #1](https://discuss.leetcode.com/topic/30941/here-is-a-10-line-template-that-can-solve-most-substring-problems/2) and [template #2](https://discuss.leetcode.com/topic/71662/sliding-window-algorithm-template-to-solve-all-the-leetcode-substring-search-problem)
## Arrays
- [x] [Two Sum](https://leetcode.com/problems/two-sum/)
- [ ] [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/)
- [x] [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/description/)
- [x] [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/description/)
- [x] [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/description/)
- [x] [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/description/)
- [ ] [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/)
- [ ] [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/description/)
- [ ] [3Sum](https://leetcode.com/problems/3sum/description/)
- [ ] [Container With Most Water](https://leetcode.com/problems/container-with-most-water/description/)

# Languages
## C-Sharp

# Source Control
## Git

# Books
## Cracking the Code Interview
## Head First Into Design Patterns
## The Clean Coder

# Pluralsight

# Github Resources
- [jwasham/coding-interview-university](https://github.com/jwasham/coding-interview-university)
- [yangshun/tech-interview-handbook](https://github.com/yangshun/tech-interview-handbook)
- [kdn251/interviews](https://github.com/kdn251/interviews)
- [mr-mig/every-programmer-should-know](https://github.com/mr-mig/every-programmer-should-know)
- [donnemartin/interactive-coding-challenges](https://github.com/donnemartin/interactive-coding-challenges#arrays-and-strings)
- [jwasham/computer-science-flash-cards](https://github.com/jwasham/computer-science-flash-cards)
- [k88hudson/git-flight-rules](https://github.com/k88hudson/git-flight-rules)

# Notes
- [bigocheatsheet](http://bigocheatsheet.com/)