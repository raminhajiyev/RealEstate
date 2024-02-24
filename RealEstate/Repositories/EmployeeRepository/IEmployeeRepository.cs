using RealEstate.DTOs.CategoryDTO;
using RealEstate.DTOs.EmployeeDTO;

namespace RealEstate.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
    }
}
