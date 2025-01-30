using TaskCollaborationSystem.Console.Entities.Interface;
namespace TaskCollaborationSystem.ConsoleApp.Entities
{

   public class MemberTask : IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
    }
}
