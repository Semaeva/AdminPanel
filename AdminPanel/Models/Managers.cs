using AdminPanel.Interfaces;

namespace AdminPanel.Models
{
    public class Managers : IContent
    {
        public int Id { get; set; }
        public string? Name { get ; set ; }
        public string? Description { get; set; }
        public ICollection<NewsPictures>? Pictures { get; set; }
    }
}
