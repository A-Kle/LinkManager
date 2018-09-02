using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinkManager.Data
{
    public interface ILink
    {
        Task<List<Link>> GetAll();
        Task<Link> GetById(int id);
        Task<Link> GetByName(string name);
        Task<List<Link>> GetLinksByGroupName(string groupName);
        Task<List<Link>> GetLinksByGroupId(int groupId);
        void Create(Link link);
        void Remove(Link link);
        void Update(Link link);
    }
}
