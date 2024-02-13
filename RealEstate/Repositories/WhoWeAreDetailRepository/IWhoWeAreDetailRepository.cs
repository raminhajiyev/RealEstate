using RealEstate.DTOs.WhoWeAreDetailDTO;

namespace RealEstate.Repositories.WhoWeAreDetailRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllDetailAsync();
        void CreateDetail(CreateWhoWeAreDetailDto createDetailDto);
        void DeleteDetail(int id);
        void UpdateDetail(UpdateWhoWeAreDetailDto updateDetailDto);
        Task<GetByIdWhoWeAreDetailDto> GetDetail(int id);
    }
}
