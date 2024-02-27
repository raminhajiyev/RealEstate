namespace RealEstate.Repositories.StatisticsRepository
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProduct();
        string CategoryNameByMaxProduct();
        decimal AverageProductByRent();
        decimal AverageProductBySale();
        string CityNameByMaxProduct();
        decimal LastProductPrice();
        int ActiveEmployeeCount();
        int DailyRentCount();
        int RentCount();
        int BuyCount();
        int WeeklyRentCount();
    }
}
