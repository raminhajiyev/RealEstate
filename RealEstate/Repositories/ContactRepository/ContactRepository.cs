using Dapper;
using RealEstate.DTOs.ContactDTO;
using RealEstate.Models.DapperContext;

namespace RealEstate.Repositories.ContactRepository
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;
        public ContactRepository(Context context)
        {
            _context = context;
        }
        public void CreateContact(CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdContactDto> GetByIdContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4MessagesDto>> GetLast4Messages()
        {
            string query = "Select Top(4) * From UserContact order by UserContactId Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4MessagesDto>(query);
                return values.ToList();
            }
        }
    }
}
