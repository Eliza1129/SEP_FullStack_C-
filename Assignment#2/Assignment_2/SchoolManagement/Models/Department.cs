using SchoolManagement.interfaces;

namespace SchoolManagement.Models;

using System;

public class Department : IDepartmentService
{
    public string DepartmentName { get; private set; }
    public Instructor Head { get; private set; }
    public decimal Budget { get; private set; }

    public Department(string departmentName)
    {
        DepartmentName = departmentName;
    }

    public void AssignHead(Instructor instructor)
    {
        Head = instructor;
        Console.WriteLine($"{instructor.Name} is now the head of {DepartmentName}.");
    }

    public void AllocateBudget(decimal amount)
    {
        if (amount < 0) throw new ArgumentException("Budget cannot be negative");
        Budget = amount;
    }
}
