﻿namespace RealEstate_Dapper_UI.DTOs.EmployeeDto
{
    public class UpdateEmployeeDto
    {
        public int employeeId { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public bool status { get; set; }
    }
}
