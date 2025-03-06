using SchoolManagement.interfaces;

namespace SchoolManagement.Models;

using System;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; private set; }
    private DateTime _joinDate;

    public Instructor(string name, DateTime birthDate, decimal salary, DateTime joinDate)
        : base(name, birthDate, salary)
    {
        _joinDate = joinDate;
    }

    public void AssignDepartment(Department department)
    {
        Department = department;
        department.AssignHead(this);
    }

    public int GetYearsOfExperience() => DateTime.Now.Year - _joinDate.Year;

    public override decimal CalculateSalary() => Salary + (GetYearsOfExperience() * 1000);
}
