# 01 Introduction to C# and Data Types
# Understanding Data Types
## Test your Knowledge
### 1. What type would you choose for the following “numbers”?
- **A person’s telephone number** `string`
- **A person’s height** `double`
- **A person’s age** `int` 
- **A person’s gender (Male, Female, Prefer Not To Answer)** `enum`
- **A person’s salary** `decimal` 
- **A book’s ISBN** `string`
- **A book’s price**  `decimal`
- **A book’s shipping weight** `float` 
- **A country’s population**  `long`
- **The number of stars in the universe** `ulong` 
- **The number of employees in each of the small or medium businesses in the UK (up to about 50,000 employees per business)** 
`int`
### 2. What are the difference between value type and reference type variables? What is boxing and unboxing?
- Value types store actual values, while reference types store references to values.
- Value types are stored on the stack, whereas reference types are stored on the heap.
- Boxing is the process of converting a value type into an object.
- Unboxing extracts the value type from the object.
### 3. What is meant by the terms managed resource and unmanaged resource in .NET
- managed resources are handled by the .NET Garbage Collector, requiring no manual clearnup. Also, they are objects fully controlled by the .NET runtime which is the CLR. It's stored in .NET managed heap. 
- unmanaged rescources are not managed by .NET and must be manually released using Dispose() or using. It's stored in Opreating system memory.
### 4. Whats the purpose of Garbage Collector in .NET?
The Garbage Collector in .NET automates memory management. It tracks, reclaims, and compacts memory to prevent memory leaks.

# Practice Number Sizes and Ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

code in the project file(02UnderstandingTypes)

# Controlling Flow and Converting Types

## Test Your Knowledge

1. What happens when you divide an `int` variable by 0? 
- Diving  an `int` by zero will cause a runtime error and it will crash the program. 
2. What happens when you divide a `double` variable by 0?
- Diving a double by zero won't throw an exception. The results will be infinity for positive numbers, -Infinity for negative numbers and NaN. 

3. What happens when you overflow an `int` variable, that is, set it to a value beyond its range?
- In unchecked mode (default), integer overflow wraps around to the opposite end, leading to incorrect values.
- In checked mode, integer overflow throws an OverflowException, preventing incorrect calculations.
- Using checked blocks helps detect overflows and avoid unexpected behavior in calculations.

4. What is the difference between `x = y++`; and `x = ++y;`?
- for `x = y++`, starts with `x = y` and then `y = y + 1`(***post-increment***)
- `x = ++y` starts with `y = y + 1` and then `x = y`(***pre-increment***)
5. What is the difference between `break`, `continue`, and `return` when used inside a loop statement?
- `break` statement immediately terminates the loop which it appears and any remaining interations of the loop will not execute. The next statement after the loop continues execution.
- `continue` statement skips the rest of the current iteration and moves directly to the next iteration of the loop. It doesn't exit the loop, instead, it skips executing the remaining code in the loop body for the current iteration. The loop continues executing from the next iteration as normal.
- `return` statement completely exits the method in which it is called, stopping the loop and the entire function. If return is inside a loop, it not only terminates the loop but also terminates the entire method execution.
6. What are the three parts of a `for` statement, and which of them are required?
- a for loop consists of three parts, 
for (initialization; condition; iteration){
  // loop
}
- required: condition. It controls when the loop should stop. The lopp runs as long as this condition evaluates to true. 
7. What is the difference between the `=` and `==` operators?
- `=` operator is used to assign a value to a variable. The right side is evaluated first and then stored in the left side variable. It doesn't return a boolean.
-  `==` operators is used to compare two values. It returns a boolean like true or false to indicate whether the values are equal.What's more, it commonly used in conditional statements. 
8. Does the following statement compile? for ( ; true; ) ;
- The following statement will compile. However, this for loop misses the initialization and iteration parts, but the required condition is true, making it an infinite loop. 
9. What does the underscore `_`represent in a switch expression?
- In a switch expression, _ acts as a default case to handle all unmatched values.
10. What interface must an object implement to be enumerated over by using the foreach
statement?
- If an object must be used in a foreach loop, it must implement `IEnumerable` or `IEnumerable<T>`.


