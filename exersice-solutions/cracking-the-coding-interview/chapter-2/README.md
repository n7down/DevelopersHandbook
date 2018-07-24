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
- [x] 2.1 - Remove Duplicates
 - Remove duplicates from an unsorrted linked list
- [ ] 2.2 - Return Kth to Last
 - Implement an algorithm to find the kth to last element of a singly linked list
- [ ] 2.3 - Delete Middle Node
 - Implement an algorithm to delete a node in the middle (i.e. any node but the first and list node, not necessarily the exact middle) of a singly linked list, given only access to that node.
```
Example:
Input: the node c from the linked list a->b->c->d->e->f
Result: nothing is returned, but the new linked list looks like a->b->d->e->f
```
- [ ] 2.4 - Partition
 - Write code to partition a linked list around a value x, such that all nodes less then x come before all nodes greater then or equal to x. If x is contained wihin the list, the vaules of x only need to be after the elements less then x (see below). The partition element x can appear anywhere in the "right partition"; it does not need to appear between the left and right partitions.
```
Example:
Input: 3->5->8->5->10->2->1 (partition = 5)
Output: 3->1->2->10->5->5->8
```
- [ ] 2.5 - Sum Lists
 - You have town numbers represented by a linked list, where each node contains a single digit. The digits are stored in reverse order, such that the 1's digits is at the head of the list. Write a function that adds the two number and returns the sum as a linked list.
```
Example:
Input:(7->1->6) + (5->9->2). That is, 617 + 295
Output: 2->1->9. That is, 912

Follow Up
Suppose the digits are stored in forward order. Repeat the above problem.
Example
Input: (6->1->7) + (2->9->5). That is, 617 + 295.
Output: 9->1->2. That is, 912.
```
- [ ] 2.6 - Palindrone
 - Implement a function to check if a linked list is a palindrone.
- [ ] 2.7 - Intersection
 - Give two (singly) linked lists, determine if the two lists intersect. Return the intersecting node. Note that the intersection is defined based on reference. Return the intersecting node. Note that the intersection is defined based on reference, not value. That is, if the kth node of the first linked list is the exact same node (by reference) as the jth node of the second linked list, then they are intersecting.
- [ ] 2.8 - Loop Detection
 - Given a circular linked list, implement an algorithm that returns the node at the beginning of the loop.
 efinition
 Circular linked: A (currupt) linked list in whicha node's next pointer points to an earlier node, so as to make a loop in the linked list.
 ```
 Example
 Input: A->B->C->D->E->C (the same C as earlier)
 Output: C
 ```
