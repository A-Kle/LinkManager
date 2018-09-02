using LinkManager.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkManager.Services
{
    public class LinkService : ILink
    {
        private readonly LinkManagerContext _context;

        public LinkService(LinkManagerContext context)
        {
            _context = context;
        }

        public async Task<List<Link>> GetAll()
        {
            return await _context.Links.ToListAsync();
        }

        public async Task<Link> GetById(int id)
        {
            return await _context.Links.Where(l => l.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Link> GetByName(string name)
        {
            return await _context.Links.Where(l => l.Name == name).FirstOrDefaultAsync();
        }

        public async Task<List<Link>> GetLinksByGroupId(int groupId)
        {
            return await _context.Links.Where(l => l.GroupId == groupId).ToListAsync();
        }

        public async Task<List<Link>> GetLinksByGroupName(string groupName)
        {
            return await _context.Links
                .Join(_context.Groups,
                    link => link.GroupId,
                    group => group.Id,
                    (link, group) => new { Link = link, Group = group })
                .Where(linkAndGroup => linkAndGroup.Group.Name == groupName)
                .Select(linkAndGroup => linkAndGroup.Link).ToListAsync();
        }

        public void Create(Link link)
        {
            _context.Add(link);
            _context.SaveChanges();
        }

        public void Remove(Link link)
        {
            _context.Remove(link);
            _context.SaveChanges();
        }

        public void Update(Link link)
        {
            _context.Update(link);
            _context.SaveChanges();
        }
    }
}
