using Dapper;
using RealEstate.DTOs.CategoryDTO;
using RealEstate.DTOs.PopularLocationDTO;
using RealEstate.Models.DapperContext;

namespace RealEstate.Repositories.PopularLocationRepository
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;
        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            string query = "insert into PopularLocation(CityName, ImageUrl) values(@cityName,@imageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", createPopularLocationDto.CityName);
            parameters.Add("@imageUrl", createPopularLocationDto.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocation(int id)
        {
            string query = "delete from PopularLocation where PopularLocationId=@PopularLocationId";
            var parameters = new DynamicParameters();
            parameters.Add("@PopularLocationId", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdPopularLocationDto> GetPopularLocation(int id)
        {
            string query = "Select * From PopularLocation where PopularLocationId=@PopularLocationId";
            var parameters = new DynamicParameters();
            parameters.Add("@PopularLocationId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdPopularLocationDto>(query, parameters);
                return values;
            }
        }

        public async void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            string query = "Update PopularLocation set CityName=@cityName, ImageUrl=@imageUrl where PopularLocationId=@PopularLocationId";
            var parameters = new DynamicParameters();
            parameters.Add("@PopularLocationId", updatePopularLocationDto.PopularLocationId);
            parameters.Add("@cityName", updatePopularLocationDto.CityName);
            parameters.Add("@imageUrl", updatePopularLocationDto.ImageUrl);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
