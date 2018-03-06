# Reverse Bits
Reverse bits of a given 32 bits unsigned integer.

For example, given input 43261596 (represented in binary as `00000010100101000001111010011100`), return 964176192 (represented in binary as `00111001011110000010100101000000`).

## Prerequisites
- [cmake](https://cmake.org/)
- [googletest](https://github.com/google/googletest)

## Getting Started
1. Run `mkdir build`
2. Run `cd build`
3. Run `cmake -DCMAKE_BUILD_TYPE=Debug ..` to build debug symbols
4. Run `./bin/all_test` to run test cases

## About Solution
If this function is called many times, you can optimize it to O(1) constant time using bit tweaks.

```
class Solution {
	public:
		uint32_t reverseBits(uint32_t n) {
			n = (n >> 1) & 0x55555555 | (n << 1) & 0xaaaaaaaa;  	// 01010101010101010101010101010101 | 10101010101010101010101010101010
			n = (n >> 2) & 0x33333333 | (n << 2) & 0xcccccccc;		// 00110011001100110011001100110011 | 11001100110011001100110011001100
			n = (n >> 4) & 0x0f0f0f0f | (n << 4) & 0xf0f0f0f0;		// 00001111000011110000111100001111 | 11110000111100001111000011110000
			n = (n >> 8) & 0x00ff00ff | (n << 8) & 0xff00ff00;		// 00000000111111110000000011111111 | 11111111000000001111111100000000
			n = (n >> 16) & 0x0000ffff | (n << 16) & 0xffff0000;	// 00000000000000001111111111111111 | 11111111111111110000000000000000
			return n;
		}
}
```

Basically, the idea is to swap 2 bits, then 4 bits, 8 bits and 16 bits. If a integer binary representation is (abcdefgh) then what the above does is:

abcdefgh — ba dc fe hg — dcba hgfe — hgfedcba

The bitwise and shifting operations are fast and probably all of them can be done in registers.

### Hexidecimal Table
|-|----|
|0|0000|
|1|0001|
|2|0010|
|3|0011|
|4|0100|
|5|0101|
|6|0110|
|7|0111|
|8|1000|
|9|1001|
|A|1010|
|B|1011|
|C|1100|
|D|1101|
|E|1110|
|F|1111|
