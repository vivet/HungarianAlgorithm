# HungarianAlgorithm v1.0.1
[![Build Status](https://travis-ci.org/vivet/HungarianAlgorithm.svg?branch=master)](https://travis-ci.org/vivet/HungarianAlgorithm)
[![NuGet](https://img.shields.io/nuget/dt/HungarianAlgorithm.svg)](https://www.nuget.org/packages/HungarianAlgorithm/)

Implemenation of the Hungarian Algorithm.  
The Hungarian method is a combinatorial optimization algorithm that solves the assignment problem in polynomial time and which anticipated later primal-dual methods.

#### Usage:
```csharp
var costs origins = new int[x,y]();
var result = HungarianAlgorithm.FindAssignments(costs);
```
