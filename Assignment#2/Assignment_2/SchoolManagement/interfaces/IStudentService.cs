using SchoolManagement.Models;

namespace SchoolManagement.interfaces;

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}