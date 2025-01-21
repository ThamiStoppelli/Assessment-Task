using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TextRepository : IRepository<Text>
    {
        private readonly MyDbContext _context;

        public TextRepository(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Text> GetAll() => _context.Texts.ToList();
        public Text GetById(int id) => _context.Texts.Find(id);
        public void Add(Text entity) { _context.Texts.Add(entity); _context.SaveChanges(); }
        public void Update(Text entity) { _context.Texts.Update(entity); _context.SaveChanges(); }
        public void Delete(int id) { var entity = GetById(id); _context.Texts.Remove(entity); _context.SaveChanges(); }
    }
}
