# Chapter-1
Contains all exercises in chapter-1

## Prerequisites
- [.NET Core](https://www.microsoft.com/net/download)

## Getting Started
1. Run `dotnet restore`
2. Run `dotnet test` to run all tests

## Exercises
- [x] 1.1 - Is Unique 
 - Implememnt an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures
- [x] 1.2 - Check Permutation
 - Given two strings, write a method to decide if one is a permutation of the other.
- [x] 1.3 - URLify
 - Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters, and that you are given the "true" length of the string. (Note: If implement in Java, please use a character array so that you can perform this operation in place.)

```
EXAMPLE:
Input: "Mr John Smith          ", 13
Output: "Mr%20John%20Smith"
```
- [ ] 1.4 - Palindrome Permutation
 - Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase that is the same forward and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
```
EXAMPLE
Input: Tact Coa
Output: True (permutation: "taco cat", "atco cta", etc.)
```
- [x] 1.5 - One Away
 - There are three types of edits that that can be performed on strings: insert a character, remove a character, or replace a character. Given two strings, write a function to check if they are one edit (or zero edit) away.
```
EXAMPLE
pale, ple -> true
pales, pale -> true
pale, bale -> true
pale, bake -> false
```
- [x] 1.6 - String Compression
 - Implement a method to perform basic string compression using the counts of repeated characters. For example, the string aabcccccaaa would be a2b1c5a3. If the "compressed" string would not become smaller then the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z).
- [ ] 1.7 - Rotate Matrix
 - Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degreees. Can you do this in place?
- [ ] 1.8 - Zero Matrix
 - Write an algorithm such that if an element in an MxN matrix is 0, its entrie row and column are set to 0.
- [ ] 1.9 - String Rotation
 - Assume you have a meth`isSubstring` which checks if one word is a substring of another. Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to `isSubstring` (e.g., "waterbottle" is a rotation of "erbottlewat").
