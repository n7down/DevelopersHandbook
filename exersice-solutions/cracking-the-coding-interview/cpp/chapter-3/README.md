# Chapter 3 - Stacks and Queues
Contains all exercises for chapter 3.

## Prerequisites
- [cmake](https://cmake.org/)
- [googletest](https://github.com/google/googletest)

## Getting Started
1. Run `mkdir build`
2. Run `cd build`
3. Run `cmake -DCMAKE_BUILD_TYPE=Debug ..` to build debug symbols
4. Run `make`
5. Run `./bin/all_test` to run test cases

## Exercises
- [ ] 3.1 - Three in One
 - Describe how you could use a single array to implement three stacks.
- [ ] 3.2 - Stack Min
 - how would you design a stack which, in addition to push and pop, has a function min which returns the minimum element? Push, pop and min should all operate in O(1) time.
- [ ] 3.3 - Stack of Plates
 - Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure `SetOfStacks` that mimics this. `SetOfStacks` should be composed of several stacks and should create a new stack once the previous one exceeds capacity. `SetOfStacks.push()` and `SetOfStacks.pop()` should behave identically to a single stack (that is, pop() should return the same values as it would if there were just a single stack). Follow up - Implement a function `popAt(int index)` which performs a pop operations on a specific sub-stack.
- [ ] 3.4 - Queue via Stacks
 - Implement a `MyQueue` class which implements a queue using two stacks.
- [ ] 3.5 - Sort Stack
 - Write a program to sort a stack such that the smallest item are ono the top. You can use an additional temporyary stack, but you may not copy the elements into any other data structure (such as an array). The stack supports the following operations: `push`, `pop`, `peek`, and `isEmpty`.
- [ ] 3.6 - Animal Shelter
 - An animal shelter, which holds only dogs and cats, operates on a strictly "first in, first out" basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter, or they can select whether they would perfer a dog or a cat (and will receive the oldest animal of that type). They cannot select which specific animal they would like. Create a data structures to maintain this system and implement operations such as `enqueue`, `dequeueAny`, `dequeueDog`, and `dequeueCat`. You may use the built-in `LinkedList` data structure.
