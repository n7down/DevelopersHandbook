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
- Understand the **Window Sliding Template** which can be used to solve most substring problem. Here is the algorithm:
1. Use two pointers: start and end to represent a window.
2. Move end to find a valid window.
3. When a valid window is found, move start to find a smaller window.

For most substring problem, we are given a string and need to find a substring of it which satisfy some restrictions. A general way is to use a hashmap assisted with two pointers. The template is given below.
Here is the template:
```
int findSubstring(string s){
	vector<int> map(128,0);
	int counter; // check whether the substring is valid
	int begin=0, end=0; //two pointers, one point to tail and one  head
	int d; //the length of substring

	for() { /* initialize the hash map here */ }

	while(end<s.size()){

		if(map[s[end++]]-- ?){  /* modify counter here */ }

		while(/* counter condition */){

			/* update d here if finding minimum*/

			//increase begin to make it invalid/valid again

			if(map[s[begin++]]++ ?){ /*modify counter here*/ }
		}

		/* update d here if finding maximum*/
	}
	return d;
}
```

To check if a window is valid, we use a map to store (char, count) for chars in t. And use counter for the number of chars of t to be found in s. The key part is `m[s[end]]--;`. We decrease count for each char in s. If it does not exist in t, the count will be negative.

To really understand this algorithm, please see my code which is much clearer, because there is no code like `if(map[s[end++]]++>0) counter++;`.
```
string minWindow(string s, string t) {
	unordered_map<char, int> m;
	// Statistic for count of char in t
	for (auto c : t) m[c]++;
	// counter represents the number of chars of t to be found in s.
	size_t start = 0, end = 0, counter = t.size(), minStart = 0, minLen = INT_MAX;
	size_t size = s.size();

	// Move end to find a valid window.
	while (end < size) {
		// If char in s exists in t, decrease counter
		if (m[s[end]] > 0)
			counter--;
		// Decrease m[s[end]]. If char does not exist in t, m[s[end]] will be negative.
		m[s[end]]--;
		end++;
		// When we found a valid window, move start to find smaller window.
		while (counter == 0) {
			if (end - start < minLen) {
				minStart = start;
				minLen = end - start;
			}
			m[s[start]]++;
			// When char exists in t, increase counter.
			if (m[s[start]] > 0)
				counter++;
			start++;
		}
	}
	if (minLen != INT_MAX)
		return s.substr(minStart, minLen);
	return "";
}
```

The code of solving **Longest Substring with At Most Two Distinct Characters** is below:
```
int lengthOfLongestSubstringTwoDistinct(string s) {
	vector<int> map(128, 0);
	int counter=0, begin=0, end=0, d=0;
	while(end<s.size()){
		if(map[s[end++]]++==0) counter++;
		while(counter>2) if(map[s[begin++]]--==1) counter--;
		d=max(d, end-begin);
	}
	return d;
}
```

The code for solving **Longest Substring Without Repeating Characters** is below:
```
int lengthOfLongestSubstring(string s) {
	vector<int> map(128,0);
	int counter=0, begin=0, end=0, d=0;
	while(end<s.size()){
		if(map[s[end++]]++>0) counter++;
		while(counter>0) if(map[s[begin++]]-->1) counter--;
		d=max(d, end-begin); //while valid, update d
	}
	return d;
}
```

The code for solving **Minimum Window Substring** is below:
```
string minWindow(string s, string t) {
	vector<int> map(128,0);
	for(auto c: t) map[c]++;
	int counter=t.size(), begin=0, end=0, d=INT_MAX, head=0;
	while(end<s.size()){
		if(map[s[end++]]-->0) counter--; //in t
		while(counter==0){ //valid
			if(end-begin<d)  d=end-(head=begin);
			if(map[s[begin++]]++==0) counter++;  //make it invalid
		}
	}
	return d==INT_MAX? "":s.substr(head, d);
}
```

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

