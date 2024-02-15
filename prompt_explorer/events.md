# Prompts:
1. Provide a console application that covers all the uses of events. Provide exception handling scenarios if they exist.
-> Provides code for a bank application. The code is provided with .NET 6.0+ in mind. I tested the code in .NET Fiddle which was at a lower version.
2. Compilation error (line 35, col 63): Unexpected character '$'. This is the error I got -> Explains the concept of String interpolation and null check, features of .NET 6.0+
3. How does "OnWithdraw?.Invoke(amount);" work?
-> The OnWithdraw?.Invoke(amount); line is using a feature of C# called the null-conditional operator (?.). This operator is used to check if an object is null before calling a method or accessing a property on it.

In this case, OnWithdraw is an event, and events are essentially a type of delegate. A delegate can be thought of as a pointer to a method, so invoking a delegate is like calling a method.

Here’s what’s happening in OnWithdraw?.Invoke(amount);:

OnWithdraw? checks if OnWithdraw is not null. If OnWithdraw is null (meaning no methods have been added to the event), then the rest of the line is ignored, and no exception is thrown.
If OnWithdraw is not null (meaning there is at least one method added to the event), then Invoke(amount) is called. This calls all the methods that have been added to the OnWithdraw event, passing amount as an argument to those methods.
So, the ?. operator is a safe way to call methods or raise events without needing to check for null first. It helps make your code more concise and less prone to null reference exceptions.
4. Use game terms instead of bank terms for the BankAccount code example -> Rewrites the code with a player as the bank account and health as the amount.