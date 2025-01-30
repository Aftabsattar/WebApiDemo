using Microsoft.AspNetCore.Mvc;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;
using TaskCollaborationSystem.Console.Entities;
namespace WebApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
       static IManager<Phone> phoneManager = new Mangers<Phone>();
        [HttpPost]
        public string AddPhone(Phone phone)
        {
            return phoneManager.Add(phone);
        }
        [HttpGet]
        public List<Phone> ViewPhone()
        {
            return phoneManager.View();
        }
        [HttpGet]
        public string RemovePhone(string phoneName)
        {
            return phoneManager.Remove(phoneName);
        }
        [HttpPost]
        public string UpdatePhone(string phoneName, Phone updatedPhone)
        {
            return phoneManager.Update(phoneName, updatedPhone);
        }
    }
}
