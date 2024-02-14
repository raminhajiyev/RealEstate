using Dapper;
using RealEstate.DTOs.WhoWeAreDetailDTO;
using RealEstate.DTOs.WhoWeAreServiceDTO;
using RealEstate.Models.DapperContext;

namespace RealEstate.Repositories.WhoWeAreServiceRepository
{
    public class WhoWeAreServiceRepository : IWhoWeAreServiceRepository
    {
        private readonly Context _context;
        public WhoWeAreServiceRepository(Context context)
        {
            _context = context;
        }
        public async void CreateService(CreateWhoWeAreServiceDto createWhoWeAreServiceDto)
        {

            string query = "insert into WhoWeAreServices(ServiceName, Status) values(@serviceName,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", createWhoWeAreServiceDto.ServiceName);
            parameters.Add("@status", createWhoWeAreServiceDto.Status);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteService(int id)
        {
            string query = "delete from WhoWeAreServices where WhoWeAreServiceId=@WhoWeAreServiceId";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreServiceId", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From WhoWeAreServices";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreServiceDto> GetService(int id)
        {
            string query = "Select * From WhoWeAreServices where WhoWeAreServiceId=@WhoWeAreServiceId";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreServiceId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreServiceDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateWhoWeAreServiceDto updateWhoWeAreServiceDto)
        {
            string query = "Update WhoWeAreServices set ServiceName=@serviceName, Status=@status where WhoWeAreServiceId=@WhoWeAreServiceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", updateWhoWeAreServiceDto.ServiceName);
            parameters.Add("@status", updateWhoWeAreServiceDto.Status);
            parameters.Add("@WhoWeAreServiceId", updateWhoWeAreServiceDto.WhoWeAreServiceId);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
