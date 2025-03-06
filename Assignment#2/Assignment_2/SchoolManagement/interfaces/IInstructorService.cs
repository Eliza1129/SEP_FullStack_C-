using SchoolManagement.Models;

namespace SchoolManagement.interfaces;

public interface IInstructorService: IPersonService
{
    void AssignDepartment(Department department);
    int GetYearsOfExperience();
}