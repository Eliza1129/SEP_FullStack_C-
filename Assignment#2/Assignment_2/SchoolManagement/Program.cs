// See https://aka.ms/new-console-template for more information

using System;

namespace SchoolManagement.Models;
class Program
{
    static void Main()
    {
        // Creating a Department
        Department csDept = new Department("Computer Science");

        // Creating an Instructor
        Instructor profJohn = new Instructor("John Doe", new DateTime(2000, 2, 11), 50000, new DateTime(2005, 8, 1));
        profJohn.AssignDepartment(csDept);

        // Creating a Student
        Student bob = new Student("Bob Jin", new DateTime(2003, 2, 15));

        // Creating Courses
        Course oop = new Course("Object-Oriented Programming");
        Course dbms = new Course("Database Management Systems");

        // Student Enrolling in Courses
        bob.EnrollInCourse(oop);
        bob.EnrollInCourse(dbms);

        // Assigning Grades
        bob.SetGrade(oop, 'A');
        bob.SetGrade(dbms, 'B');

        // Display Outputs
        Console.WriteLine($"Instructor Salary: {profJohn.CalculateSalary()}");
        Console.WriteLine($"Bob's GPA: {bob.CalculateGPA()}");

        // Display enrolled students
        oop.DisplayStudents();
        dbms.DisplayStudents();
    }
}
