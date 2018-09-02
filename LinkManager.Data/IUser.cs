using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinkManager.Data
{
    public interface IUser
    {
        Task<User> GetById(int id);
        Task<User> GetByName(string name);
        void Create();
        void Delete();
        void Update();
    }
}
