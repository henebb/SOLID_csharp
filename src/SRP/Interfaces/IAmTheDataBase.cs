using SOLID_csharp.Models;

namespace SOLID_csharp.Interfaces
{
    public interface IAmTheDataBase
    {
        void Save(User user);
    }
}