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

***
#### Example Usage
Let's say you want to solve [this example](https://en.wikipedia.org/wiki/Hungarian_algorithm) from Wikipedia where you need to know which is the lowest-cost way to assign cleaning tasks. 

In this example, there are three workers and three tasks. 

+--------+----------------+--------------+--------------+
| Worker | Clean Bathroom | Sweep Floors | Wash Windows |
+========+================+==============+==============+
| Alice  | 8              | 4            | 7            |
+--------+----------------+--------------+--------------+
| Bob    | 5              | 2            | 3            |
+--------+----------------+--------------+--------------+
| Carol  | 9              | 4            | 8            |
+--------+----------------+--------------+--------------+

The lowest total cost is 15. This is the case where:
* Alice cleans the bathroom (8)
* Bob washes the windows (3)
* Carol sweeps the floors (4)

The expected result of FindAssignments is that it returns the positions of 8,3,and 4.

To input this scenario into FindAssignments, the array would look like this:
```csharp
int[,] costs = {{8, 4, 7}, 
                {5, 2, 3},
                {9, 4, 8}};
```
Pass this 2D array to FindAssignments like this:
```csharp
int[] solutionIndexes = HungarianAlgorithm.FindAssignments(costs);
```
The resulting array will hold the indexes of the items that combine for the lowest total cost. 

In this example, result would be [0,2,1];

This is because: 
* in first costs sub-array (representing Alice), 8 is in element 0. 
* in second costs sub-array (representing Bob), 3 is in element 2. 
* in third costs sub-array (representing Carol), 4 is in element 1. 
***
_Original source-code posted by Alex Regueiro in 2010 ([Link](https://web.archive.org/web/20121106104729/http://noldorin.com:80/programming/HungarianAlgorithm.cs))_
