# Languages

## Table Of Contents
1. [All](#all)
2. [CPP](#cpp) 

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

<a name="c-cpp"></a>
## C/CPP
- [Google C++ Style Guide](https://google.github.io/styleguide/cppguide.html)
- [awesome-cpp](https://github.com/fffaraz/awesome-cpp#standard-libraries)
- [cpp-cheat-sheet](https://github.com/gibsjose/cpp-cheat-sheet)

