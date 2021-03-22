# 0x0A. C# - Generics
## Resources :books:
### Read or watch:

* [Generics (C# Programming Guide) (Read sections “Introduction to Generics” up to and including “Generics and Arrays”)]()
* [Generics in .NET]()
* [C# Generics Tutorial: Whats and Whys]()
* [Access Modifiers (C# Programming Guide)]()
* [Covariance and Contravariance in Generics]()
* [Covariance and Contravariance with C#]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What are generics and what are their purpose
* What common generic classes and interfaces are provided in the .NET class library
* When and how to create generic classes
* When and how to create generic methods
* How access modifiers affect a class and its members
* What is the default(T) expression used for
* What is covariance and contravariance
## Requirements :white_check_mark:
### General
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task.
* Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Queue](./0-queue/)** - Create a new class called Queue<T>
- [x] **[1. Enqueue](./1-enqueue/)** - Based on 0-queue, within Queue<T>, create a public class called Node with the following properties
- [x] **[2. Dequeue](./2-dequeue/)** - Based on 1-enqueue, add a new method Dequeue() to the class Queue<T> that removes the first node in the queue and returns its value
- [x] **[3. Peek](./3-peek/)** - Based on 2-dequeue, add a new method Peek() to the class Queue<T> that returns the value of the first node of the queue without removing the node
- [x] **[4. Print](./4-print/)** - Based on 3-peek, add a new method Print() to the class Queue<T> that prints the queue, starting from the head
- [x] **[5. Concatenate](./5-concatenate/)** - Based on 4-print, create a method Concatenate() that concatenates all values in the queue only if the queue is of type String or Char
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/santiagopemo) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
