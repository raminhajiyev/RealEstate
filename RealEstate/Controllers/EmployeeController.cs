using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.DTOs.BottomGridDTO;
using RealEstate.DTOs.EmployeeDTO;
using RealEstate.Repositories.BottomGridRepository;
using RealEstate.Repositories.EmployeeRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("New data has been added successfully");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Data has been deleted successfully");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Data has been updated successfully");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEmployee(int id)
        {
            var values = await _employeeRepository.GetEmployee(id);
            return Ok(values);
        }

    }
}
