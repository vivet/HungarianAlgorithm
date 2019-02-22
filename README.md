# Hungarian Algorithm
[![Build status](https://ci.appveyor.com/api/projects/status/399dkyksy1nxfrqm/branch/master?svg=true)](https://ci.appveyor.com/project/vivet/hungarianalgorithm/branch/master)
[![NuGet](https://img.shields.io/nuget/dt/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)
[![NuGet](https://img.shields.io/nuget/v/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)

The Hungarian algorithm is a combinatorial optimization method, that solves the assignment problem in polynomial time, and which anticipated later primal-dual methods. In other words, based on a matrix of possible combinations of costs, the algorithm returns an ordered collcetion of matches, having the lowest combined cost, thus being the most optimal assignment.

***

#### The Algorithm
The example below, shows how to use and apply the algorithm.  
It defines a two-dimensional array, passes it to algorithm, and recieves a result of an array of matched columns for each row (x) passed.
```csharp
int[,] costs = new int[x,y]();
int[] result = HungarianAlgorithm.FindAssignments(costs);
```

#### Square Input Array
The algorithm doesn't always produce the most optimal result, when the input contains more columns (y) than rows (x). To overcome this issue, square the dimensions of the input before passing it to the algorithm, as shown below.  
```csharp
int[,] costs = new int[x,y]();
int[,] squared = costs.SquareArray(costs)
```

***

_Original source-code posted by Alex Regueiro in 2010 ([Link](https://web.archive.org/web/20121106104729/http://noldorin.com:80/programming/HungarianAlgorithm.cs))_
