namespace RealEstate_Dapper_UI.DTOs.UserContactDto
{
    public class Last4MessagesDto
    {
        public int UserContactId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
