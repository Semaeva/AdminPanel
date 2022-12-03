using AdminPanel.Models;

namespace AdminPanel.Interfaces
{
    public interface IPictures
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
