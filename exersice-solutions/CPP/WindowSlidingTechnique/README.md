# Window Sliding Technique
This technique shows how a nested for loop in few problems can be converted to single for loop and hence reducing the time complexity.

Let’s start with a problem for illustration where we can apply this technique –

Given an array of integers of size ‘n’.
Our aim is to calculate the maximum sum of ‘k’
consecutive elements in the array.

Input  : `arr[] = {100, 200, 300, 400}`
`k = 2`
Output : `700`

Input  : `arr[] = {1, 4, 2, 10, 23, 3, 1, 0, 20}`
k = `4`
Output : `39`
We get maximum sum by adding subarray `{4, 2, 10, 23}`
of size `4`.

Input  : `arr[] = {2, 3}`
k = `3`
Output : Invalid
There is no subarray of size `3` as size of whole
array is `2`.

## Prerequisites
- [cmake](https://cmake.org/)
- [googletest](https://github.com/google/googletest)

## Getting Started
1. Run `mkdir build`
2. Run `cd build`
3. Run `cmake -DCMAKE_BUILD_TYPE=Debug ..` to build debug symbols
4. Run `make`
5. Run `./bin/all_test` to run test cases

