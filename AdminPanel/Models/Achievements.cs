using AdminPanel.Interfaces;

namespace AdminPanel.Models
{

    public class Achievements : IContent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Pictures>? Pictures { get; set; }
    }
}
