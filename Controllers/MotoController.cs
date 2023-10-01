using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotorcycleRacing.Payloads.Requests;
using MotorcycleRacing.Service.Implements;
using MotorcycleRacing.Service.Interfaces;

namespace MotorcycleRacing.Controllers
{
    [Route("/api/moto")]
    [ApiController]
    public class MotoController : ControllerBase
    {
        private readonly IMotoService motoService;
        public MotoController()
        {
            motoService = new MotoService();
        }
        [HttpPost("addData")]
        public IActionResult AddData(MotoRequest request)
        {
            return Ok(motoService.AddData(request));
        }
        [HttpGet("getData")]
        public IActionResult GetData()
        {
            return Ok(motoService.GetData());
        }
    }
}
