using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Repositories.BottomGridRepository;
using RealEstate.Repositories.StatisticsRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticsRepository.ActiveCategoryCount());
        }

        [HttpGet("BuyCount")]
        public IActionResult BuyCount()
        {
            return Ok(_statisticsRepository.BuyCount());
        }

        [HttpGet("RentCount")]
        public IActionResult RentCount()
        {
            return Ok(_statisticsRepository.RentCount());
        }

        [HttpGet("DailyRentCount")]
        public IActionResult DailyRentCount()
        {
            return Ok(_statisticsRepository.DailyRentCount());
        }

        [HttpGet("WeeklyRentCount")]
        public IActionResult WeeklyRentCount()
        {
            return Ok(_statisticsRepository.WeeklyRentCount());
        }

        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticsRepository.PassiveCategoryCount());
        }
    }
}
