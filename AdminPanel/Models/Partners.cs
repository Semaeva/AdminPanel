using AdminPanel.Interfaces;

namespace AdminPanel.Models
{
    public class Partners : IContent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PathImage { get; set; }
        public string? NameImage { get; set; }
    }
}
