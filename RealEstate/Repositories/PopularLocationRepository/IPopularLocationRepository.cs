using RealEstate.DTOs.CategoryDTO;
using RealEstate.DTOs.PopularLocationDTO;

namespace RealEstate.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIdPopularLocationDto> GetPopularLocation(int id);
    }
}
