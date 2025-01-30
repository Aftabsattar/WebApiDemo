using TaskCollaborationSystem.ConsoleApp.Managers.Interface;
using TaskCollaborationSystem.Console.Entities.Interface;
namespace TaskCollaborationSystem.Console.Entities
{
    class Mangers<EntityClass> : IManager<EntityClass> where EntityClass : IEntity, new()
    {
        public string Name { get; set; }

        private List<EntityClass> list = new();

        public string Add(EntityClass obj)
        {
            list.Add(obj);
            return $"{obj.Name} added successfully!";
        }

        public string Remove(string objName)
        {
            var obj = list.Find(obj => obj.Name == objName);
            if (obj == null)
            {
                return "objnot found!";
            }
            list.Remove(obj);
            return $"{obj.Name} Removed Successfully!";
        }

        public List<EntityClass> View()
        {
            return list;
        }

        public string Update(string memberName, EntityClass updatedObj)
        {
            var obj = list.FindIndex(obj => obj.Name == memberName);
            if (obj == -1)
            {
               return "objnot found!";
            }
            list[obj] = updatedObj;
            return $"{memberName} Updated Successfully!";
        }
    }
}
