# Student Grading System

This is a beginner-level C# console project designed to calculate the average of student grades and determine their academic status based on performance.

## Features

- Object-oriented structure using encapsulation
- Calculates the average of three grades per student
- Determines academic status:
  - Passed (average ≥ 60)
  - Conditional Pass (average 50–59)
  - Failed (average < 50)
  - Honor Certificate (average ≥ 90)
- Tracks the student with the highest average
- Uses arrays to store multiple student objects

## Technologies Used

- Programming Language: C#
- IDE: Visual Studio 2022
- Project Type: Console Application

## Project Structure

```
StudentGradingSystem/
├── Program.cs        // Handles main logic and user input
├── Student.cs        // Defines the Student class and related methods
├── README.md         // Project documentation
```

## Sample Output

```
Enter number of students: 2

Enter information for student 1:
First Name: Alice
Last Name: Smith
Grade 1: 85
Grade 2: 90
Grade 3: 95

First Name: ALICE
Last Name: SMITH
Average: 90
Status: Honor Certificate

Overall Average: 87.50
Top Student: ALICE SMITH (90.00)
```

## Learning Outcomes

- Working with classes and objects in C#
- Encapsulation using private fields and public properties
- Creating and using methods
- Handling arrays of objects
- Performing basic input/output in console applications
- Implementing logic with conditional statements and loops

## Ideal For

This project is suitable for learners who have recently completed topics such as:

- Variables and data types
- Conditional statements
- Loops
- Methods
- Arrays
- Object-oriented programming basics

## Possible Improvements

- Saving and loading student data from files (e.g., JSON or text)
- Implementing a menu-driven interface
- Creating a graphical version using Windows Forms or WPF
- Adding support for multiple courses or subjects

---

This project was developed for educational purposes to practice foundational C# concepts and object-oriented programming.
