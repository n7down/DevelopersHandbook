# Additional Kata

## Table Of Contents
1. [Tip And Tricks](#tips-and-tricks)
1. [Arrays](#arrays)
2. [Binary](#binary)

<a name="tips-and-tricks"></a>
## Tips And Tricks
Understand the substring template with the following: [template #1](https://discuss.leetcode.com/topic/30941/here-is-a-10-line-template-that-can-solve-most-substring-problems/2) and [template #2](https://discuss.leetcode.com/topic/71662/sliding-window-algorithm-template-to-solve-all-the-leetcode-substring-search-problem)

<a name="arrays"></a>
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

<a name="binary"></a>
## Binary 
- [x] [Sum of Two Integers](https://leetcode.com/problems/sum-of-two-integers/)
- [x] [Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/)
- [x] [Counting Bits](https://leetcode.com/problems/counting-bits/)
- [x] [Missing Number](https://leetcode.com/problems/missing-number/)
- [x] [Reverse Bits](https://leetcode.com/problems/reverse-bits/)

Some helpful utility snippets:

- Test k<sup>th</sup> bit is set: `num & (1 << k) != 0`.
- Set k<sup>th</sup> bit: `num |= (1 << k)`.
- Turn off k<sup>th</sup> bit: `num &= ~(1 << k)`.
- Toggle the k<sup>th</sup> bit: `num ^= (1 << k)`.
- To check if a number is a power of 2, `num & num - 1 == 0`.


