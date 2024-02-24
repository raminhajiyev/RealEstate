namespace RealEstate.DTOs.EmployeeDTO
{
    public class UpdateEmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
