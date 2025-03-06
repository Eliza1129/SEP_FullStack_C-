using SchoolManagement.Models;

namespace SchoolManagement.interfaces;

public interface IDepartmentService
{
    void AssignHead(Instructor instructor);
    void AllocateBudget(decimal amount);
}