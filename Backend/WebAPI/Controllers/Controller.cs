// # API endpoints

using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextController : ControllerBase
    {
        private readonly ITextService _textService;

        public TextController(ITextService textService)
        {
            _textService = textService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var texts = _textService.GetAll();
            return Ok(texts);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ListItemDTO newText)
        {
            _textService.Add(newText);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ListItemDTO updatedText)
        {
            _textService.Update(id, updatedText);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _textService.Delete(id);
            return Ok();
        }
    }
}
