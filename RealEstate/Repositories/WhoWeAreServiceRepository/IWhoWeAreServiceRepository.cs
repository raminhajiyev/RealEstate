using RealEstate.DTOs.WhoWeAreDetailDTO;
using RealEstate.DTOs.WhoWeAreServiceDTO;

namespace RealEstate.Repositories.WhoWeAreServiceRepository
{
    public interface IWhoWeAreServiceRepository
    {
        Task<List<ResultWhoWeAreServiceDto>> GetAllServiceAsync();
        void CreateService(CreateWhoWeAreServiceDto createWhoWeAreServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateWhoWeAreServiceDto updateWhoWeAreServiceDto);
        Task<GetByIdWhoWeAreServiceDto> GetService(int id);
    }
}
