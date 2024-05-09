using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface IParentChildRepository
    {
        public List<Parent> GetAllParents();
        public void AddParent(Parent parent);
        public void RemoveParentByID(int parentID);
    }
}
