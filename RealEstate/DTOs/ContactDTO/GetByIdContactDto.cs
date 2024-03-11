namespace RealEstate.DTOs.ContactDTO
{
    public class GetByIdContactDto
    {
        public int UserContactId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
