using ContactRepo.Repository;
using Microsoft.AspNetCore.Mvc;
using ContactRepo.Models;
namespace ContactRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ContactsController : ControllerBase
    {
        IContactsRepository contactsRepository;
        
        public ContactsController(IContactsRepository _contactsRepository)
        {
            contactsRepository=_contactsRepository;

        }
        [HttpPost("createcontact")]
        public IActionResult CreateContact(Contacts contacts)
        {
            contactsRepository.Add(contacts);
            return Ok("Record is Added");
        }
        [HttpPut("UpdateRecord")]
        public IActionResult UpdateContact(Contacts contacts)
        {
            contactsRepository.Update(contacts);
            return Ok("record has been updated");
        }
        [HttpDelete("Delete Id")]
        public IActionResult RemoveContact(int Id)
        {
            contactsRepository.Remove(Id);
            return Ok("Record is Removed");
        }

        [HttpGet("Search{Id:int}")]
        public IActionResult SearchContact(int Id)
        {
            var Findc=contactsRepository.Find(Id);
            if(Findc==null)
            {
                return Ok("Record not found");
            }
            else
            {
                return Ok(Findc);
            }
        }
        [HttpGet("ContactList")]
        public IActionResult GetAllContact()
        {
            var t=contactsRepository.GetAll();
            if(t==null)
            {
                return Ok("No Record Inserted");
            }
            else
            {
                return Ok(t);
            }
        }


    }
}