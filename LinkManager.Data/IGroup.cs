using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinkManager.Data
{
    public interface IGroup
    {
        Task<Group> GetById(int id);
        Task<Group> GetByName(string name);
        void Create();
        void Delete();
        void Update();
    }
}
