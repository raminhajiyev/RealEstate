namespace RealEstate_Dapper_UI.DTOs.EmployeeDto
{
    public class CreateEmployeeDto
    {
        public string name { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public bool status { get; set; }
    }
}
