# 0x0B. C# - Interfaces
## Resources :books:
### Read or watch:

* [C# Interfaces Explained in Simple Terms]()
* [Interfaces (C# Programming Guide)]()
* [Interfaces (Note: This video uses Visual Studio Community, not Visual Studio Code, so while the IDE is different, the concepts are the same.)]()
* [Abstract and Sealed Classes and Class Members]()
* [interface (C# Reference)]()
* [abstract (C# Reference)]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is an interface
* What are interfaces used for
* How do interfaces, classes, and structs differ
* What is an abstract class
* How are interfaces different from abstract classes
* How is an interface implemented explicitly
* What is the as keyword and how to use it
## Requirements :white_check_mark:
### General
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* You can organize and name your files as you like for this project, just ensure you do not push a file containing a Main method, it may conflict with our testing files.
* Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Abstract thinking](./0-abstract_thinking/)** - Create an abstract class called Base containing the following
- [x] **[1. User interface](./1-user_interface/)** - Based on 0-abstract_thinking, create an interface called IInteractive
- [x] **[2. Escape room](./2-doors/)** - Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive
- [x] **[3. Interior decorating](./3-decorations/)** - Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable
- [x] **[4. Key collecting](./4-keys/)** - Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable
- [x] **[5. Iterate and act](./5-iterate_act/)** - You try to open the Front Door. It's locked
- [x] **[6. Better iterating and acting](./6-generic_iteration/)** - Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/santiagopemo) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
