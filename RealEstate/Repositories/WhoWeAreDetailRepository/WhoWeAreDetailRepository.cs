using Dapper;
using RealEstate.DTOs.CategoryDTO;
using RealEstate.DTOs.WhoWeAreDetailDTO;
using RealEstate.Models.DapperContext;

namespace RealEstate.Repositories.WhoWeAreDetailRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;
        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }
        public async void CreateDetail(CreateWhoWeAreDetailDto createDetailDto)
        {

            string query = "insert into WhoWeAreDetail(Title, Subtitle, Description1, Description2) values(@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createDetailDto.Title);
            parameters.Add("@subtitle", createDetailDto.Subtitle);
            parameters.Add("@description1", createDetailDto.Description1);
            parameters.Add("@description2", createDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteDetail(int id)
        {
            string query = "delete from WhoWeAreDetail where WhoWeAreDetailId=@WhoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreDetailId", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllDetailAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreDetailDto> GetDetail(int id)
        {
            string query = "Select * From WhoWeAreDetail where WhoWeAreDetailId=@WhoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateDetail(UpdateWhoWeAreDetailDto updateDetailDto)
        {
            string query = "Update WhoWeAreDetail set Title=@title, Subtitle=@subtitle, Description1=@description1, Description2=@description2 where WhoWeAreDetailId=@WhoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateDetailDto.Title);
            parameters.Add("@subtitle", updateDetailDto.Subtitle);
            parameters.Add("@description1", updateDetailDto.Description1);
            parameters.Add("@description2", updateDetailDto.Description2);
            parameters.Add("@WhoWeAreDetailId", updateDetailDto.WhoWeAreDetailId);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }
    }
}
