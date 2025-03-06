using SchoolManagement.Models;

namespace SchoolManagement.interfaces;
public interface ICourseService
{
    void AddStudent(Student student);
    void DisplayStudents();
}