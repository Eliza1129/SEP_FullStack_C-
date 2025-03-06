using SchoolManagement.interfaces;

namespace SchoolManagement.Models;
using SchoolManagement.interfaces;
using System;
using System.Collections.Generic;

public class Course : ICourseService
{
    public string CourseName { get; private set; }
    private List<Student> students = new List<Student>();

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public void AddStudent(Student student) => students.Add(student);

    public void DisplayStudents()
    {
        Console.WriteLine($"Students enrolled in {CourseName}:");
        foreach (var student in students)
            Console.WriteLine(student.Name);
    }
}
