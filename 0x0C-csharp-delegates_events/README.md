# 0x0C. C# - Delegates, Events
## Resources :books:
### Read or watch:

* [Delegates (C# Programming Guide) (Read all sections “Using Delegates”, “Delegates with Named vs Anonymous Methods”, “How to: Combine Delegates”, “How to Declare, Instantiate, and Use a Delegate”)]()
* [Why Delegates? Why Not Call Methods Directly?]()
* [Events (C# Programming Guide) (Read sections “How to Subscribe to and Unsubscribe from Events”, “How to: Raise Base Class Events in Derived Classes”, and “How to: Implement Interface Events”)]()
* [Standard .NET event patterns]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What are delegates and how to use them
* What are anonymous methods and how to use them
* What is multicasting
* What is the difference between delegates and interfaces
* What is a callback
* What are events and how to use them
* What is asynchronous programming
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
- [x] **[0. Universal health](./0-universal_health/)** - Create a public class called Player with the following
- [x] **[1. Damage delegation](./1-damage_delegation/)** - Based on 0-universal_health, create a delegate CalculateHealth that takes a float amount. Write two methods that follow the prototype of the CalculateHealth delegate
- [x] **[2. Validation](./2-validation/)** - Based on 1-damage_delegation, inside the TakeDamage() and HealDamage() methods, calculate the new value of the Player’s hp but do not set the value of hp in these methods
- [x] **[3. Modified behavior](./3-modified_behavior/)** - Based on 2-validation, outside of the Player class, create an enum Modifier with the values Weak, Base, Strong
- [x] **[4. Check yourself](./4-check_yourself/)** - Based on 3-modified_behavior, outside of the Player class, create a new class CurrentHPArgs that inherits from EventArgs with the following
- [x] **[5. Eventful](./5-eventful/)** - Based on 4-check_yourself, create a new method HPValueWarning inside the Player class
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/santiagopemo) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
