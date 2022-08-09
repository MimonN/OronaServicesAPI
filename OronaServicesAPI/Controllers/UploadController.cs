using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace OronaServicesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public UploadController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Upload()
        {
            var formCollection = await Request.ReadFormAsync();
            var file = formCollection.Files.First();
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(formCollection.Files.First().FileName);
                var fullPath = Path.Combine(pathToSave, fileName + extension);
                var dbPath = Path.Combine(folderName, fileName + extension);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return Ok(new {dbPath});
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("{id}"), DisableRequestSizeLimit]
        public async Task<IActionResult> UpdateImage(int id)
        {
            var window = await _repository.Window.GetWindowByIdAsync(id);
            if (window == null)
            {
                return NotFound();
            }
            var oldImage = window.ImgPath;
            if (System.IO.File.Exists(oldImage))
            {
                System.IO.File.Delete(oldImage);
            }
            var formCollection = await Request.ReadFormAsync();
            var file = formCollection.Files.First();
            var folderName = Path.Combine("Resources", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(formCollection.Files.First().FileName);
                var fullPath = Path.Combine(pathToSave, fileName + extension);
                var dbPath = Path.Combine(folderName, fileName + extension);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return Ok(new { dbPath });
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
