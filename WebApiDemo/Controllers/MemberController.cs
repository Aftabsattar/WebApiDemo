using Microsoft.AspNetCore.Mvc;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;
using TaskCollaborationSystem.ConsoleApp.Entities;
using TaskCollaborationSystem.Console.Entities;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        static IManager<Member> manager = new Mangers<Member>();
        [HttpPost]
        public string Add(Member obj)
        {
            return manager.Add(obj);
        }
        [HttpGet]
        public List<Member> View()
        {
            return manager.View();
        }
        [HttpGet]
        public string Remove(string objName)
        {
            return manager.Remove(objName);
        }
        [HttpPost]
        public string Update(string objName, Member updatedObj)
        {
            return manager.Update(objName, updatedObj);
        }
    }
}

