namespace SchoolManagement.Models;
using System;
using System.Collections.Generic;

public abstract class Person
{
    private string _name;
    private DateTime _birthDate;
    private decimal _salary;
    private List<string> _addresses = new List<string>();

    public Person(string name, DateTime birthDate, decimal salary)
    {
        _name = name;
        _birthDate = birthDate;
        Salary = salary;
    }

    public string Name => _name;
    public DateTime BirthDate => _birthDate;

    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0) throw new ArgumentException("Salary cannot be negative");
            _salary = value;
        }
    }

    public void AddAddress(string address) => _addresses.Add(address);
    public List<string> GetAddresses() => _addresses;

    public int CalculateAge() => DateTime.Now.Year - BirthDate.Year;

    public abstract decimal CalculateSalary();
}
