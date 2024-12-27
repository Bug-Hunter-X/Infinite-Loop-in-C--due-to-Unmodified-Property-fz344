# Infinite Loop Bug in C#

This repository demonstrates a common C# coding error that leads to an infinite loop. The issue stems from a condition within a `while` loop that relies on a variable (`MyProperty`) that is never modified within the loop's body, resulting in the loop never terminating. 

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE.
3. Run the `MyMethod` function in `ExampleClass`. 
4. Observe that the program hangs, as the loop continues indefinitely.

## Solution

The solution, provided in `bugSolution.cs`, addresses this by ensuring that `MyProperty` is updated within the loop, allowing the loop's termination condition to eventually become true. 