using AdminPanel.Interfaces;

namespace AdminPanel.Models
{
    public class Teachers : IContent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Pictures> Pictures { get; set; }

        public Teachers()
        {
            Pictures =new List<Pictures>();
        }
    }
}
