# Hungarian Algorithm
[![Build Status](https://travis-ci.org/vivet/HungarianAlgorithm.svg?branch=master)](https://travis-ci.org/vivet/HungarianAlgorithm)
[![NuGet](https://img.shields.io/nuget/dt/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)
[![NuGet](https://img.shields.io/nuget/v/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)

The Hungarian algorithm is a combinatorial optimization method, that solves the assignment problem in polynomial time, and which anticipated later primal-dual methods. In other words, based on a matrix of possible combinations of costs, the algorithm returns an ordered collcetion of matches, having the lowest combined cost.

##### Using the algorithm
```csharp
int[,] costs = new int[x,y]();
int[] result = HungarianAlgorithm.FindAssignments(costs);
```
