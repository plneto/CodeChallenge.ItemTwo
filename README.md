# Code Challenge

## 2. How would you rate the quality of the following piece of code? Can you provide an alternative?

```c#
if (message is MessageA)
{
    var messageA = message as MessageA;
    messageA?.MyCustomMethodOnA();
}
else if (message is MessageB)
{
    var messageB = message as MessageB;
    messageB?.MyCustomMethodOnB();
    messageB?.SomeAdditionalMethodOnB();
}
else if (message is MessageC)
{
    var messageC = message as MessageC;
    messageC?.MyCustomMethodOnC();
}
```

## Answer

The code snippet provided is of low quality and inefficient; it doesn't take advantage of OOP principles and can be simplified.

OOP principles that can be applied:
- **Inheritance** - All message types should inherit from the same `IBaseMessage` interface and have the same contract.
- **Encapsulation** - The internal methods, such as `MyCustomMethodOnA()`, should be encapsulated inside its message class.
- **Abstraction** - Only the `DoSomething()` method should be made public without exposing unnecessary methods.
- **Polymorphism** - We should be able to execute the `DoSomething()` method without knowing the type of its concrete implementation.

By having each message type (MessageA, MessageB, and MessageC) inherit from the same interface, each message implementation can encapsulate its logic inside the `DoSomething()` method. See example below:

```c#
public interface IBaseMessage
{
    void DoSomething();
}

public class MessageA : IBaseMessage 
{
    public void DoSomething()
    {
        MyCustomMethodOnA();
    }
    
    private static void MyCustomMethodOnA()
    {
        // implementation
    }
}
```

The `DoSomething()` method can then be executed without the message object being casted to its type. See example below:

```c#
public void SendMessage(IBaseMessage message)
{
    message.DoSomething();
}
```

The suggested implementation also folllows the Liskov Substitution Principle (LSP) — Objects should be replaceable by their subtypes.

The full solution is provided in this repository.
