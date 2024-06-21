//Sure, here's an exercise that covers encapsulation, polymorphism, and inheritance:

//### Exercise: Library Management System

//#### Objective
//Create a simple Library Management System that utilizes the concepts of encapsulation, polymorphism, and inheritance.

//#### Requirements

//1. **Encapsulation**
//   - Create a `Book` class with the following private properties: `Title`, `Author`, `ISBN`, and `IsAvailable`.
//   - Provide public methods to get and set these properties as needed.

//2. **Inheritance**
//   - Create a base class `LibraryItem` with common properties such as `ID`, `Title`, and `IsAvailable`.
//   - The `Book` class should inherit from `LibraryItem`.
//   - Create another derived class `Magazine` that also inherits from `LibraryItem` and has additional properties such as `IssueNumber` and `Publisher`.

//3. **Polymorphism**
//   - Create a method `DisplayDetails` in the `LibraryItem` class that can be overridden by the derived classes `Book` and `Magazine`.
//   - Implement the `DisplayDetails` method in both the `Book` and `Magazine` classes to show their specific details.

//4. **Implementation**
//   - In the `Main` method, create a list of `LibraryItem` and add instances of `Book` and `Magazine` to it.
//   - Loop through the list and call the `DisplayDetails` method on each item, demonstrating polymorphism.

//#### Guidelines

//1. **Book Class**
//   - Implement encapsulation by using private fields and public properties.
//   -Inherit from `LibraryItem`.

//2. **Magazine Class**
//   - Inherit from `LibraryItem`.
//   - Add specific properties for `Magazine`.

//3. **LibraryItem Class**
//   - Define common properties.
//   - Implement a virtual method `DisplayDetails`.

//4. **Main Method**
//   - Create instances of `Book` and `Magazine`.
//   - Add them to a list of `LibraryItem`.
//   - Iterate through the list and call `DisplayDetails` on each item.

//#### Example Scenario

//1. **LibraryItem Class**
//   - Properties: `ID`, `Title`, `IsAvailable`
//   - Method: `virtual void DisplayDetails()`

//2. * *Book Class(inherits LibraryItem) * *
//   -Additional Properties: `Author`, `ISBN`
//   - Method: `override void DisplayDetails()`

//3. * *Magazine Class(inherits LibraryItem) * *
//   -Additional Properties: `IssueNumber`, `Publisher`
//   - Method: `override void DisplayDetails()`

//4. * *Main Method Implementation**
//   - Create `Book` and `Magazine` instances.
//   - Add them to a list of `LibraryItem`.
//   - Iterate through the list and display details of each item.

//This exercise will help you practice encapsulation by protecting the internal state of the `Book` and `Magazine` classes, inheritance by creating a common base class, and polymorphism by overriding the `DisplayDetails` method in the derived classes.

using LibraryManagementSystem.Class;

List<LibraryItem> libraryItems = [
    new Book("R001", "Next world", true, "KaveerR", "IS0002K885R222"), 
    new Magazine("2K publish", 1, "R002", "New coding magazine", true)
    ];

foreach (var item in libraryItems)
{
    item.DisplayDetails();
    Console.WriteLine("\n");
}

Console.ReadLine();
