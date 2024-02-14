using RealEstate.DTOs.BottomGridDTO;
using RealEstate.DTOs.CategoryDTO;

namespace RealEstate.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetByIdBottomGridDto> GetBottomGrid(int id);
    }
}
