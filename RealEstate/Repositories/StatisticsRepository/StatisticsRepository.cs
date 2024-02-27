using Dapper;
using RealEstate.DTOs.ProductDTO;
using RealEstate.Models.DapperContext;

namespace RealEstate.Repositories.StatisticsRepository
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;
        public StatisticsRepository(Context context)
        {
            _context = context;
        }
        public int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Category where CategoryStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Employee where Status=1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductByRent()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductBySale()
        {
            throw new NotImplementedException();
        }

        public int BuyCount()
        {
            string query = "Select Count(*) From Category where CategoryName like 'Buy'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
           
        }

        public int CategoryCount()
        {
            throw new NotImplementedException();
        }

        public string CategoryNameByMaxProduct()
        {
            throw new NotImplementedException();
        }

        public string CityNameByMaxProduct()
        {
            throw new NotImplementedException();
        }

        public int DailyRentCount()
        {
            string query = "Select Count(*) From Category where CategoryName like 'Daily Rent'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string EmployeeNameByMaxProduct()
        {
            throw new NotImplementedException();
        }

        public decimal LastProductPrice()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            string query = "Select Count(*) From Category where CategoryStatus=0";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }

        public int RentCount()
        {
            string query = "Select Count(*) From Category where CategoryName like 'Rent'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int WeeklyRentCount()
        {
            string query = "Select Count(*) From Category where CategoryName  like 'Weekly Rent'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }
    }
}
