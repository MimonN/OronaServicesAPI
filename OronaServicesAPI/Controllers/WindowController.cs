using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace OronaServicesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WindowController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public WindowController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWindows()
        {
            var windows = await _repository.Window.GetAllWindowsAsync();
            _logger.LogInfo($"Returned all windows from database.");

            var windowsResult = _mapper.Map<IEnumerable<WindowDto>>(windows);
            return Ok(windowsResult);

        }

        [HttpGet("{id}", Name = "WindowById")]
        public async Task<IActionResult> GetWindowById(int id)
        {
            var window = await _repository.Window.GetWindowByIdAsync(id);
            if (window == null)
            {
                _logger.LogError($"Window with id: {id}, hasn't been found in db.");
                return NotFound();
            }
            else
            {
                _logger.LogInfo($"Returned window with id: {id}");

                var windowResult = _mapper.Map<WindowDto>(window);
                return Ok(windowResult);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateWindow([FromBody] WindowForCreationDto window)
        {
            if (window == null)
            {
                _logger.LogError("Window object sent from client is null.");
                return BadRequest("Window object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid window object sent from client.");
                return BadRequest("Invalid model object");
            }

            var windowEntity = _mapper.Map<Window>(window);

            _repository.Window.CreateWindow(windowEntity);
            await _repository.SaveAsync();

            var createdWindow = _mapper.Map<WindowDto>(windowEntity);

            return CreatedAtRoute("WindowById", new { id = createdWindow.Id }, createdWindow);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWindow(int id, [FromBody] WindowForUpdateDto window)
        {
            if (window == null)
            {
                _logger.LogError("Window object sent from client is null.");
                return BadRequest("Window object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid window object sent from client.");
                return BadRequest("Invalid model object");
            }

            var windowEntity = await _repository.Window.GetWindowByIdAsync(id);
            if (windowEntity == null)
            {
                _logger.LogError($"Window with id: {id}, hasn't been found in db.");
                return NotFound();
            }

            _mapper.Map(window, windowEntity);

            _repository.Window.UpdateWindow(windowEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWindow(int id)
        {
            var window = await _repository.Window.GetWindowByIdAsync(id);
            if (window == null)
            {
                _logger.LogError($"Window with id: {id}, hasn't been found in db.");
                return NotFound();
            }

            
            var oldImage = window.ImgPath;
            if (System.IO.File.Exists(oldImage))
            {
                System.IO.File.Delete(oldImage);
            }

            _repository.Window.DeleteWindow(window);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
