using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class TextService : ITextService
    {
        private readonly IRepository<Text> _repository;

        public TextService(IRepository<Text> repository)
        {
            _repository = repository;
        }

        public IEnumerable<ListItemDTO> GetAll()
        {
            return _repository.GetAll()
                .Select(t => new ListItemDTO { Id = t.Id, Content = t.Content });
        }

        public void Add(ListItemDTO text)
        {
            _repository.Add(new Text { Content = text.Content });
        }

        public void Update(int id, ListItemDTO text)
        {
            _repository.Update(new Text { Id = id, Content = text.Content });
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public async Task UpsertDataFromSource()
        {
            // Logic to fetch data from a public API and upsert it
        }
    }
}
