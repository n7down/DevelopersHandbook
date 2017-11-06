# Substring of Identical Characters
Find the longest substring of identical characters in a very long string.

Example:
```
s1 = "1111aa994bbbb1111AAAAAFF?<mmMaaaaaaaaaaaaaaaaaaaaaaaaabf"
```
The longest substring in s1 is `"aaaaaaaaaaaaaaaaaaaaaaaaa"` having a length of `25`, made of character, `"a"`,  with its corresponding ascii code equals to `97`, and having its starting index `29` and the ending one `53`.

The results using an array in the following order: `[97, 25, 29, 53]`.

## Notes
Using the following [template #1](https://discuss.leetcode.com/topic/30941/here-is-a-10-line-template-that-can-solve-most-substring-problems/2) and [template #2](https://discuss.leetcode.com/topic/71662/sliding-window-algorithm-template-to-solve-all-the-leetcode-substring-search-problem) to find the substring