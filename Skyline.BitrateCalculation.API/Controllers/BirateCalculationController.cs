using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Skyline.BitrateCalculation.API.Database;
using Skyline.BitrateCalculation.API.DTOs;
using Skyline.BitrateCalculation.API.Models;
using Skyline.BitrateCalculation.API.Services.IRepository;

namespace Skyline.BitrateCalculation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirateCalculationController : ControllerBase
    {
        private readonly IVideoRepository _videoRepository;

        public BirateCalculationController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _videoRepository.GetAllVideos();

            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetByDevice(int id) 
        {
            var data = _videoRepository.GetVideo(id);

            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody]string json) 
        {
            var data = _videoRepository.AddVideo(json);

            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]string json)
        {
            var data = _videoRepository.UpdateVideo(id, json);

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _videoRepository.DeleteVideo(id);

            return Ok();
        }
    }
}
