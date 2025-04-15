using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare an integer for age
        int age;
        // Initialize the age
        age = 18;

        // Declare a string for name
        string name;
        // Initialize the name
        name = "umair";

        // Declare a boolean for student 
        bool isStudent;
        // Initialize the student 
        isStudent = true;

        // Declare and initialize an integer for marks
        int marks = 90; // Student's exam marks

        // Declare and initialize a string for city
        string city = "islamabad"; // Student's city

        // Declare and initialize a boolean for student
        bool isPassed = true; // Whether user is student is passed

        // Display all values
        Console.WriteLine("Name: " + name); // Show name
        Console.WriteLine("Age: " + age); // Show age
        Console.WriteLine("Is Student: " + isStudent); // Show student 
        Console.WriteLine("Marks: " + marks); // Show marks
        Console.WriteLine("City: " + city); // Show city
        Console.WriteLine("student Passed: " + isPassed); // Show student passed or not

        Console.ReadKey(); 
    }
}
