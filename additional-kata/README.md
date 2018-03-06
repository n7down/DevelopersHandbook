#### Corner Cases

- Empty sequence.
- Sequence with 1 or 2 elements.
- Sequence with repeated elements.

## Array

#### Notes

Is the array sorted or partially sorted? If it is, some form of binary search should be possible. This also usually means that the interviewer is looking for a solution that is faster than O(n).

Can you sort the array? Sometimes sorting the array first may significantly simplify the problem. Make sure that the order of array elements do not need to be preserved before attempting a sort.

For questions where summation or multiplication of a subarray is involved, pre-computation using hashing or a prefix/suffix sum/product might be useful.

If you are given a sequence and the interviewer asks for O(1) space, it might be possible to use the array itself as a hash table. For example, if the array only has values from 1 to N, where N is the length of the array, negate the value at that index (minus one) to indicate presence of that number.

#### Practice Questions

- [x] [Two Sum](https://leetcode.com/problems/two-sum/)
- [ ] [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/)
- [x] [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)
- [x] [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/)
- [x] [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/)
- [x] [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/)
- [ ] [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/)
- [ ] [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/)
- [ ] [3Sum](https://leetcode.com/problems/3sum/)
- [ ] [Container With Most Water](https://leetcode.com/problems/container-with-most-water/)

## Binary

#### Study Links

- [Bits, Bytes, Building With Binary](https://medium.com/basecs/bits-bytes-building-with-binary-13cb4289aafa)

#### Notes

Questions involving binary representations and bitwise operations are asked sometimes and you must be absolutely familiar with how to convert a number from decimal form into binary form (and vice versa) in your chosen programming language.

Some helpful utility snippets:

- Test k<sup>th</sup> bit is set: `num & (1 << k) != 0`.
- Set k<sup>th</sup> bit: `num |= (1 << k)`.
- Turn off k<sup>th</sup> bit: `num &= ~(1 << k)`.
- Toggle the k<sup>th</sup> bit: `num ^= (1 << k)`.
- To check if a number is a power of 2, `num & num - 1 == 0`.

#### Corner Cases

- Check for overflow/underflow.
- Negative numbers.

#### Practice Questions

- [x] [Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/)
- [x] [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/)
- [x] [Counting Bits](https://leetcode.com/problems/counting-bits/)
- [x] [Missing Number](https://leetcode.com/problems/missing-number/)
- [x] [Reverse Bits](https://leetcode.com/problems/reverse-bits/)

