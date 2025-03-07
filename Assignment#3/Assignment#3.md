### 04 Generics
1. Describe the problem generics address.
- Generics address the problem of type safety and code reuse. They allow developers to create classes, methods, and data structures that operate on different data types while ensuring type correctness at compile-time, reducing the need for explicit type casting and minimizing runtime errors.
2. How would you create a list of strings, using the generic List class?
```csharp
List<string> myList = new List<string>();
```
3. How many generic type parameters does the Dictionary class have?
- The Dictionary class has two generic type parameters: one for the key and one for the value.
4. True/False. When a generic class has multiple type parameters, they must all match. `False`
5. What method is used to add items to a List object?
- `Add` method is used to add items to a List object.
6. Name two methods that cause items to be removed from a List.
- `Remove(T item)` is removing the first occurrence of a specific object from the List.
- `RemoveAt(int index)` is removing the element from the specified index. 
7. How do you indicate that a class has a generic type parameter?
-By specifying a type parameter inside angle brackets (`<>`) after the class name.
8. True/False. Generic classes can only have one generic type parameter. `False`
9. True/False. Generic type constraints limit what can be used for the generic type. `True `
10. True/False. Constraints let you use the methods of the thing you are constraining to. `True`