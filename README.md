# Robotics Developer Review
This repository is designed to organize all of the nessesary material and resources to become a successful robotics developer.

# Table of Contents
1. [Big-O](big-o/README.md)
2. [Data Structures](data-structures/README.md)
3. [Design Patterns](design-patterns/README.md)
4. [Algorithms](algorithms/README.md)
5. [Additional Kata](additional-kata/README.md)
6. [Languages](#languages)
	- [All](#all)
	- [C-Sharp](#c-sharp)
	- [C/CPP](#c-cpp)
7. [Robotics](#robotics)
8. [Books](#books)
9. [Github Resources](#github-resources)

## More Code Kata
- [leetcode](https://leetcode.com/problemset/all/)

## Notes
Understand the substring template with the following: [template #1](https://discuss.leetcode.com/topic/30941/here-is-a-10-line-template-that-can-solve-most-substring-problems/2) and [template #2](https://discuss.leetcode.com/topic/71662/sliding-window-algorithm-template-to-solve-all-the-leetcode-substring-search-problem)

<a name="languages"></a>
# Languages

<a name="all"></a>
## All
### Mutable and Immutable Objects
Mutable objects have fields that can be changed, immutable objects have no fields that can be changed after the object is created.

A very simple immutable object is a object without any field. (For example a simple Comparator Implementation).

```
class Mutable{
	private int v;

	public Mutable(int value) {
		this.v = value;
	}

	public int Value
	{
		get
		{
			return v;
		}
		set
		{
			v = value;
		}
	}
}

class Immutable {
	private final int value;

	public Immutable(int value) {
		this.value = value;
	}

	public int Value 
	{
		get { return value; }
		private set;
	}
}
```

<a name="c-sharp"></a>
## C-Sharp 

<a name="c-cpp"></a>
## C/CPP
- [Google C++ Style Guide](https://google.github.io/styleguide/cppguide.html)
- [awesome-cpp](https://github.com/fffaraz/awesome-cpp#standard-libraries)
- [cpp-cheat-sheet](https://github.com/gibsjose/cpp-cheat-sheet)
### Make
### CMake

<a name="robotics"></a>
# Robotics 
- [ROS](https://github.com/ros/ros)
- [ROS2](https://github.com/ros2/ros2)
- [betaflight](https://github.com/betaflight/betaflight)

<a name="books"></a>
# Books
## Programming
- [ ] Cracking the Code Interview
- [ ] Head First Into Design Patterns
- [ ] The Clean Coder
## Robotics

<a name="github-resources"></a>
# Github Resources
- [jwasham/coding-interview-university](https://github.com/jwasham/coding-interview-university)
- [yangshun/tech-interview-handbook](https://github.com/yangshun/tech-interview-handbook)
- [kdn251/interviews](https://github.com/kdn251/interviews)
- [mr-mig/every-programmer-should-know](https://github.com/mr-mig/every-programmer-should-know)
- [donnemartin/interactive-coding-challenges](https://github.com/donnemartin/interactive-coding-challenges#arrays-and-strings)
- [jwasham/computer-science-flash-cards](https://github.com/jwasham/computer-science-flash-cards)
- [k88hudson/git-flight-rules](https://github.com/k88hudson/git-flight-rules)

# Notes
- [bigocheatsheet](http://bigocheatsheet.com/)
