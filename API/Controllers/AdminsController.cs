using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        IAdminService _adminService;
        public AdminsController(IAdminService adminService )
        {
            _adminService=adminService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Thread.Sleep(1000);

            var result = _adminService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Admin admin)
        {
            var result = _adminService.Add(admin);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("remove")]
        public IActionResult Remove(Admin admin)
        {
            var result = _adminService.Remove(admin);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Admin admin)
        {
            var result = _adminService.Update(admin);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
