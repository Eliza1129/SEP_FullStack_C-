using SchoolManagement.interfaces;

namespace SchoolManagement.Models;

using System;
using System.Collections.Generic;


public class Student : Person, IStudentService
{
    private List<(Course, char)> _enrolledCourses = new List<(Course, char)>();

    public Student(string name, DateTime birthDate)
        : base(name, birthDate, 0) { }

    public void EnrollInCourse(Course course)
    {
        _enrolledCourses.Add((course, 'F'));
        course.AddStudent(this);
    }

    public void SetGrade(Course course, char grade)
    {
        for (int i = 0; i < _enrolledCourses.Count; i++)
        {
            if (_enrolledCourses[i].Item1 == course)
                _enrolledCourses[i] = (course, grade);
        }
    }

    public double CalculateGPA()
    {
        if (_enrolledCourses.Count == 0) return 0.0;

        Dictionary<char, double> gradePoints = new()
        {
            {'A', 4.0}, {'B', 3.0}, {'C', 2.0}, {'D', 1.0}, {'F', 0.0}
        };

        double totalPoints = 0;
        foreach (var (course, grade) in _enrolledCourses)
        {
            totalPoints += gradePoints[grade];
        }
        return totalPoints / _enrolledCourses.Count;
    }

    public override decimal CalculateSalary() => 0;
}
