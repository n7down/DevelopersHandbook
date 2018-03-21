# Programming Concepts

## Table Of Contents
1. [Software Development Process]()
2. [Testing Methodologies]()
3. [Types of Testing]()
4. [TDD]()

## Writing Code
When writing solutions in software there are four things to keep in mind:
1. Ensure that the code is a full representation of the solution and must remain consistent within the language, platform, curent architecture, and all the warts of the current system.
2. The code must solve the problem set for you by the customer.
3. Code must fit well into the existing system and should not increate rigidity, fragility, or opactiy of the system and must follow solid engineering principles.
4. Code must be readable by other programmers. This does not simply meen nice comments. Rather it reavels your intent.

## Debugging

## Practice

## TDD
The Three Laws of TDD
1. You are not allowed to write any production code until you have first written a failing unit test. 
2. You are not allowed to write more of a unit test than is sufficient to fail—and not compiling is failing. 
3. You are not allowed to write more production code that is sufficient

## Sequence
- Understand the [sliding window technique]()

### Corner Cases
- Empty sequence.
- Sequence with 1 or 2 elements.
- Sequence with repeated elements.

## Array
### Corner Cases
- Empty sequence.
- Sequence with 1 or 2 elements.
- Sequence with repeated elements.

## Binary
### Study Links
- [Bits, Bytes, Building With Binary](https://medium.com/basecs/bits-bytes-building-with-binary-13cb4289aafa)

### Helpful utility snippets:
- Test k<sup>th</sup> bit is set: `num & (1 << k) != 0`.
- Set k<sup>th</sup> bit: `num |= (1 << k)`.
- Turn off k<sup>th</sup> bit: `num &= ~(1 << k)`.
- Toggle the k<sup>th</sup> bit: `num ^= (1 << k)`.
- To check if a number is a power of 2, `num & num - 1 == 0`.

### Corner Cases
- Check for overflow/underflow.
- Negative numbers.

