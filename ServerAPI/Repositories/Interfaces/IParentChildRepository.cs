using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface IParentChildRepository
    {
        public List<Parent> GetAllParentChilds();
        public void AddParentChild(Parent parentchild);
        public void RemoveParentChildnByMail(string parentmail);
    }
}
