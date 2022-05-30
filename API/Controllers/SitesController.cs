using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        ISiteService _siteService;
        public SitesController(ISiteService siteService)
        {
            _siteService = siteService;
        }


        [HttpPost("add")]
        public IActionResult Add(Site site)
        {
            var result = _siteService.Add(site);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Site site)
        {
            var result = _siteService.Delete(site);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Site site)
        {
            var result = _siteService.Update(site);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
