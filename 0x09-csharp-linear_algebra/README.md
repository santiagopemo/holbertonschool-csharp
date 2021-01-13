# 0x09. C# - Linear Algebra
## Resources :books:
### Read or watch:

* [Essence of Linear Algebra Playlist]()
* [Immersive Math (Read chapters 1, 2, 3, 4, 6, 7)]()
* [The True Power of the Matrix (Transformations in Graphics) - Computerphile]()
* [Math Class (System.Math)]()
* [Khan Academy - Linear Algebra]()
* [Linear Algebra in 4 Pages]()
* [GeoGebra 3D Graphing Calculator (Useful for visualizing 3D vectors)]()
## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is linear algebra
* What is a radian
* What is a vector
* What is a vector space
* What is a scalar
* What is a linear transformation
* What is a transformation matrix
* What is transposing
* What is linear independence and linear dependence
* What is a dot product and how to calculate it
* What is a cross product and how to calculate it
* What is a standard basis
* What is a matrix
* What is the identity matrix
* What is the zero matrix
* What is a determinant and how to calculate it
* What is the inverse of a matrix and how to calculate it
## Requirements :white_check_mark:
### .txt Answers
* All your files should end with a new line
* If the answer ends in a decimal, round it to the nearest hundredth
* Vectors and matrices should be formatted with parentheses and commas as shown below:
Vector:
(0, 0.03)
Matrix:
(1, 0, -7.64)
(-9.41, -0.23, 7)
### C# Projects
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following tasks, there are no main files. For each C# task, you can use the variables in the related task prior to it to create your own main files for testing
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags
* You are not allowed to use the Vector or Matrix classes in this project
* You can use the Math class in this project
* If the task’s return value can end in a decimal, round it to the nearest hundredth
## More Info
This project uses radians instead of degrees

## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Pythagoras](./0-pythagoras)** - Calculate the value of the following and write your answer in a text file
- [x] **[1. Magnitude #0 - 2D](./1-magnitude_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[2. Magnitude #1 - 3D](./2-magnitude_3D)** - Calculate the value of the following and write your answer in a text file
- [x] **[3. Magnitude #2](./3-magnitude/)** - Create a method that calculates and returns the length of a given vector
- [x] **[4. Vector addition #0 - 2D](./4-vector_addition_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[5. Vector addition #1 - 3D](./5-vector_addition_3D)** - Calculate the value of the following and write your answer in a text file
- [x] **[6. Vector addition #2](./6-vector_addition/)** - Create a method that adds two vectors and returns the resulting vector
- [x] **[7. Vector-scalar multiplication #0 - 2D](./7-vector_scalar_mul_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[8. Vector-scalar multiplication #1 - 3D](./8-vector_scalar_mul_3D)** - Calculate the value of the following and write your answer in a text file
- [x] **[9. Vector-scalar multiplication #2](./9-vector_scalar_mul/)** - Create a method that multiplies a vector and a scalar and returns the resulting vector
- [x] **[10. Dot product #0 - 2D](./10-dot_product_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[11. Dot product #1 - 3D](./11-dot_product_3D)** - Calculate the value of the following and write your answer in a text file
- [x] **[12. Dot product #2](./12-dot_product/)** - Create a method that calculates dot product of either two 2D or two 3D vectors
- [x] **[13. Matrix addition #0](./13-matrix_addition)** - Calculate the value of the following and write your answer in a text file
- [x] **[14. Matrix addition #1](./14-matrix_addition/)** - Create a method that adds two matrices and returns the resulting matrix
- [x] **[15. Matrix-scalar multiplication #0](./15-matrix_scalar_mul)** - Calculate the value of the following and write your answer in a text file
- [x] **[16. Matrix-scalar multiplication #1](./16-matrix_scalar_mul/)** - Create a method that multiplies a matrix and a scalar and returns the resulting matrix
- [x] **[17. Matrix-matrix multiplication #0](./17-matrix_matrix_mul)** - Calculate the value of the following and write your answer in a text file
- [x] **[18. Matrix-matrix multiplication #1](./18-matrix_matrix_mul/)** - Create a method that multiplies two matrices and returns the resulting matrix
- [x] **[19. Matrix rotation #0](./19-matrix_rotate_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[20. Matrix rotation #1](./20-matrix_rotate_2D/)** - Create a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix
- [x] **[21. Matrix shear #0](./23-matrix_shear_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[22. Matrix shear #1](./24-matrix_shear_2D/)** - Create a method that shears a square 2D matrix by a given shear factor and returns the resulting matrix
- [x] **[23. Transpose matrix](./25-matrix_transpose/)** - Create a method to transpose a matrix and return the resulting matrix
- [x] **[24. Determinant #0](./26-determinant_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[25. Determinant #1](./27-determinant_3D)** - Calculate the value of the following and write your answer in a text file
- [x] **[26. Determinant #3](./28-determinant/)** - Create a method that calculates the determinant of a matrix
- [x] **[27. Cross product #0](./29-cross_product)** - Calculate the value of the following and write your answer in a text file
- [x] **[28. Cross product #1](./30-cross_product/)** - Create a method that calculates the cross product of two 3D vectors and returns the resulting vector
- [x] **[29. Inverse #0](./31-inverse_2D)** - Calculate the value of the following and write your answer in a text file
- [x] **[30. Inverse #1](./32-inverse_3D)** - Calculate the value of the following and write your answer in a text file
- [x] **[31. Inverse #2](./33-inverse_2D/)** - Create a method that calculates the inverse of a 2D matrix and returns the resulting matrix
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/santiagopemo) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
