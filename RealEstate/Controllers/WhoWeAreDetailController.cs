using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.DTOs.CategoryDTO;
using RealEstate.DTOs.WhoWeAreDetailDTO;
using RealEstate.Repositories.CategoryRepository;
using RealEstate.Repositories.WhoWeAreDetailRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {

        private readonly IWhoWeAreDetailRepository _detailRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository detailRepository)
        {
            _detailRepository = detailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> DetailList()
        {
            var values = await _detailRepository.GetAllDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDetail(CreateWhoWeAreDetailDto  createWhoWeAreDetailDto)
        {
            _detailRepository.CreateDetail(createWhoWeAreDetailDto);
            return Ok("New data has been added successfully");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDetail(int id)
        {
            _detailRepository.DeleteDetail(id);
            return Ok("Data has been deleted successfully");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _detailRepository.UpdateDetail(updateWhoWeAreDetailDto);
            return Ok("Data has been updated successfully");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdDetail(int id)
        {
            var values = await _detailRepository.GetDetail(id);
            return Ok(values);
        }
    }
}
