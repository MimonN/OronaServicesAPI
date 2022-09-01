using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace OronaServicesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public ContactUsController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContactUs()
        {
            var contactUs = await _repository.ContactUs.GetAllContactUsAsync();
            var contactUsResult = _mapper.Map<IEnumerable<ContactUsDto>>(contactUs);
            return Ok(contactUsResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactUs(int id)
        {
            var contactUs = await _repository.ContactUs.GetContactUsAsync(id);
            if (contactUs == null)
            {
                return NotFound();
            }
            var contactUsResult = _mapper.Map<ContactUsDto>(contactUs);
            return Ok(contactUsResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactUs([FromBody] ContactUsForCreationDto contactUs)
        {
            if(contactUs == null)
            {
                return BadRequest("ContactUs object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var contactUsEntity = _mapper.Map<ContactUs>(contactUs);
            contactUsEntity.CreateTime = DateTime.Now;
            contactUsEntity.State = "New";
            _repository.ContactUs.CreateContactUs(contactUsEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContactUs(int id, [FromBody] ContactUsForUpdateDto contactUs)
        {
            if (contactUs == null)
            {
                return BadRequest("ContactUs object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var contactUsEntity = await _repository.ContactUs.GetContactUsAsync(id);

            if (contactUsEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(contactUs, contactUsEntity);
            _repository.ContactUs.UpdateContactUs(contactUsEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContactUs(int id)
        {
            var contactUs = await _repository.ContactUs.GetContactUsAsync(id);
            if(contactUs == null)
            {
                return NotFound();
            }

            _repository.ContactUs.DeleteContactUs(contactUs); 
            await _repository.SaveAsync();

            return NoContent();
        }
        
    }
}
