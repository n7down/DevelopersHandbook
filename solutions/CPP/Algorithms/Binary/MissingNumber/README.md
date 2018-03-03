# Missing Number

Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

Example 1
```
Input: [3,0,1]
Output: 2
```

Example 2
```
Input: [9,6,4,2,3,5,7,0,1]
Output: 8
```
## Prerequisites
- [cmake](https://cmake.org/)
- [googletest](https://github.com/google/googletest)

## Getting Started 
1. Run `mkdir build`
2. Run `cd build`
3. Run `cmake -DCMAKE_BUILD_TYPE=Debug ..` to build debug symbols
4. Run `./bin/all_test` to run test case

## Solution

Intuition
We can harness the fact that XOR is its own inverse to find the missing element in linear time.

Algorithm
Because we know that nums contains nn numbers and that it is missing exactly one number on the range [0..n-1][0..n−1], we know that nn definitely replaces the missing number in nums. Therefore, if we initialize an integer to nn and XOR it with every index and value, we will be left with the missing number. Consider the following example (the values have been sorted for intuitive convenience, but need not be):

|     |   |   |   |   |
|-----|---|---|---|---|
|Index|	0 |	1 |	2 |	3 |
|Value|	0 |	1 |	3 |	4 |

```
missing=4∧(0∧0)∧(1∧1)∧(2∧3)∧(3∧4)=(4∧4)∧(0∧0)∧(1∧1)∧(3∧3)∧2=0∧0∧0∧0∧2=2
```
