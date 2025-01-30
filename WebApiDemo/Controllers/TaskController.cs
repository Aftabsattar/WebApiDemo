using Microsoft.AspNetCore.Mvc;
using TaskCollaborationSystem.Console.Entities;
using TaskCollaborationSystem.ConsoleApp.Entities;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;
namespace WebApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        static IManager<MemberTask> taskManager = new Mangers<MemberTask>();
        [HttpPost]
        public string AddTask(MemberTask task)
        {
            return taskManager.Add(task);
        }
        [HttpGet]
        public List<MemberTask>ViewTask()
        {
            return taskManager.View();
        }
        [HttpGet]
        public string RemoveTask(string taskName)
        {
            return taskManager.Remove(taskName);
        }
        [HttpPost]
        public string UpdateTask(string taskName, MemberTask updatedTask)
        {
            return taskManager.Update(taskName, updatedTask);
        }
    }
}
