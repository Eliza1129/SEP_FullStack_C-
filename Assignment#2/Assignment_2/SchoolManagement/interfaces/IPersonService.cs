namespace SchoolManagement.interfaces;
using System.Collections.Generic;
public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
}