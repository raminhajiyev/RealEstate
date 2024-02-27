using Dapper;
using RealEstate.DTOs.CategoryDTO;
using RealEstate.DTOs.EmployeeDTO;
using RealEstate.Models.DapperContext;

namespace RealEstate.Repositories.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;
        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Employee(Name, Title, Mail, Phone, ImageUrl, Status) values(@name, @title, @mail, @phone, @imageurl, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDto.Name);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Mail);
            parameters.Add("@phone", createEmployeeDto.Phone);
            parameters.Add("@imageurl", createEmployeeDto.ImageUrl);
            parameters.Add("@status", createEmployeeDto.Status);
           
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "delete from Employee where EmployeeId=@EmployeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "Select * From Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdEmployeeDto> GetEmployee(int id)
        {
            string query = "Select * From Employee where EmployeeId=@EmployeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "Update Employee set Name=@name,Title=@title, Mail=@mail, Phone=@phone, ImageUrl=@imageurl, Status=@status where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", updateEmployeeDto.EmployeeId);
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phone", updateEmployeeDto.Phone);
            parameters.Add("@imageurl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", updateEmployeeDto.Status);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
