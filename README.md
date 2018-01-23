# HungarianAlgorithm
[![Build Status](https://travis-ci.org/vivet/HungarianAlgorithm.svg?branch=master)](https://travis-ci.org/vivet/HungarianAlgorithm)
[![NuGet](https://img.shields.io/nuget/dt/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)
[![NuGet](https://img.shields.io/nuget/v/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)

The Hungarian method is a combinatorial optimization algorithm that solves the assignment problem in polynomial time and which anticipated later primal-dual methods.  

##### Using the algorithm
```csharp
var costs = new int[x,y]();
var result = HungarianAlgorithm.FindAssignments(costs);
```
