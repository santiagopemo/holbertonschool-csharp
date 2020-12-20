# 0x08. C# - Inheritance
## Resources :books:
### Read or watch:

* [Inheritance in C#]()
* [Inheritance]()
* [C# Inheritance]()
* [Type Checking: “TypeOf()”, “.GetType()”, or “is”?]()
* [Knowing When to Use Override and New Keywords]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is inheritance
* How is polymorphism achieved with inheritance
* What is a base class
* What is a derived class
* How to create a derived class
* How to override a method or property inherited from the base class
* What is the difference between the override and new modifiers
* What are is, .GetType(), TypeOf(), .IsInstanceOfType(), and .IsSubclassOf() and when to use them
## Requirements :white_check_mark:
### General
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* Namespaces should be omitted in this project
* Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. This is one of these](./0-is/)** - Write a method that returns True if the object is an int, otherwise return False
- [x] **[1. For instance](./1-instance/)** - Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False
- [x] **[2. Only subclass](./2-subclass/)** - Write a method that returns True if the object is an instance of a class that inherits from the specified class, otherwise return False. The object must be a subclass; your method cannot return True if the object is an instance of the base class
- [x] **[3. Type](./3-type_get/)** - Write a method that prints the names of the available properties and methods of an object. See example for output format
- [x] **[4. It's not a lesson in classes and inheritance without a Dog](./4-inherit/)** - Write a empty class Dog that inherits from empty class Animal
- [x] **[5. Basic shapes](./5-shape/)** - Write a class Shape
- [x] **[6. Rectangle](./6-shape/)** - Based on 5-shape, write a class Rectangle that inherits from Shape
- [x] **[7. Full rectangle](./7-shape/)** - Based on 6-shape, write a class Rectangle that inherits from Shape
- [x] **[8. Square #1](./8-shape/)** - set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, height, and width to the value
- [x] **[9. Square #2](./9-shape/)** - set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, Height, and Width to the value
- [x] **[10. Liskov](./10-Liskov/)** - In the previous tasks, we created a class Square that inherits from Rectangle. However, what happens if you try to assign a Square’s width and height directly
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/santiagopemo) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
