using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        IWordService _wordService;
        public WordsController(IWordService wordService)
        {
            _wordService= wordService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);

            var result = _wordService.GetAll();
            if (result.Success )
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpGet("getallbycategoryid")]

        public IActionResult GetAllByCategoryId(int id)
        {
            var result = _wordService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int wordId)
        {
            var result = _wordService.GetById(wordId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Word word)
        {
            var result = _wordService.Add(word);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("remove")]
        public IActionResult Remove(Word word)
        {
            var result = _wordService.Remove(word);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Word word)
        {
            var result = _wordService.Update(word);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
