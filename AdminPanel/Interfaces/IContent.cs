using AdminPanel.Models;

namespace AdminPanel.Interfaces
{
    public interface IContent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
