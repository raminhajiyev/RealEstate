using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.DTOs.WhoWeAreDetailDTO;
using RealEstate.DTOs.WhoWeAreServiceDTO;
using RealEstate.Repositories.WhoWeAreDetailRepository;
using RealEstate.Repositories.WhoWeAreServiceRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreServiceController : ControllerBase
    {
        private readonly IWhoWeAreServiceRepository _serviceRepository;

        public WhoWeAreServiceController(IWhoWeAreServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateWhoWeAreServiceDto servicehoWeAreServiceDto)
        {
            _serviceRepository.CreateService(servicehoWeAreServiceDto);
            return Ok("New data has been added successfully");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("Data has been deleted successfully");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateWhoWeAreServiceDto updateWhoWeAreServiceDto)
        {
            _serviceRepository.UpdateService(updateWhoWeAreServiceDto);
            return Ok("Data has been updated successfully");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdService(int id)
        {
            var values = await _serviceRepository.GetService(id);
            return Ok(values);
        }
    }
}
