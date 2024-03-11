using RealEstate.DTOs.ContactDTO;

namespace RealEstate.Repositories.ContactRepository
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4MessagesDto>> GetLast4Messages();
        void CreateContact(CreateContactDto createContactDto);
        void DeleteContact(int id);
        Task<GetByIdContactDto> GetByIdContact(int id);
    }
}
