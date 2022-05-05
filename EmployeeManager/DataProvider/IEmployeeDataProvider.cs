using EmployeeManager.Model;
using System.Collections.Generic;

namespace EmployeeManager.DataProvider
{
  public interface IEmployeeDataProvider
  {
    IEnumerable<Employee> LoadEmployees();

    void SaveEmployee(Employee employee);

    IEnumerable<JobRole> LoadJobRoles();
  }
}
