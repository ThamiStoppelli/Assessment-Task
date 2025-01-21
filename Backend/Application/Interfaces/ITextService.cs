using Application.DTOs;

namespace Application.Interfaces
{
    public interface ITextService
    {
        IEnumerable<ListItemDTO> GetAll();
        void Add(ListItemDTO text);
        void Update(int id, ListItemDTO text);
        void Delete(int id);
        Task UpsertDataFromSource();
    }
}
