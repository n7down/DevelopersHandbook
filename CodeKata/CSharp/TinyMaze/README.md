# Tiny Maze
A tiny maze solver.

A maze is represented by the following matrix:
```
[[:S 0 1]
 [1  0 1]
 [1  0 :E]]
```
- _S_ : start of the maze
- _E_ : end of the maze
- _1_ : This is a wall that you cannot pass through
- _0_ : A free space that you can move through.

The goal is the get to the end of the maze. A solved maze will have a
_:x_ in the start, the path, and the end of the maze, like the following:
```
[[:x :x 1]
 [1  :x 1]
 [1  :x :x]]
```

## Prerequisites
- [.Net Core 2](https://www.microsoft.com/net/download/)

## Getting Started 
1. Clone this directory
2. Run `dotnet test` from inside the directory