using TaskCollaborationSystem.Console.Entities.Interface;
namespace TaskCollaborationSystem.Console.Entities
{
    public class Phone : IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
       
    }
}
