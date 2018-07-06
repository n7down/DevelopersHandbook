# Chapter 2 - Linked Lists
Contains all exercises for chapter 2.

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
- [x] Implement "Runner Technique" 
- The "runner" (or second pointer) technique is used in many linked list problems. The runner technique mean that you iterate through the linked list with two pointers simultaneously, with one ahead of the other. The "fast" node might be ahead by a fixed amount, or it might be hopping multiple nodes for each one node that the "slow" node iterate through.
- For example suppose you had a linked list `a1->a2->...->an->b1->b2->...->bn` and you wanted to rearrange it into `a1->b1->a2->b2->...->an->bn`. You do not know the length of the linked list (but you do know thta the length is an even number).
- You could have one pointer p1 (the fast pointer) move every two elements for every one move that p2 makes. When p1 hits the end of the linked list, p2 will be at the midpoint. Then move p1 back to the front and begin "weaving" the elements. On each iteration, p2 selects an element and inserts it after p1.
- [ ] 2.1 - Remove Duplicates
- Remove duplicates from an unsorrted linked list
- [ ] 2.2 - Return Kth to Last
- Implement an algorithm to find the kth to last element of a singly linked list
