using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface ISignUpRepository
    {
        public List<Child> GetAllChildren();
        public List<Parent> GetAllParents();
        public void AddChild(Child child);
    }
}
