using AdminPanel.Interfaces;

namespace AdminPanel.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        public string? Year { get; set; }
       // public string? Description { get; set; }
       // public string? CreatedDate { get; set; }
        public string? Month { get; set; }
        //public string? Color { get; set; }
        public ICollection<Events> Events { get; set; }
        public Calendar()
        {
            Events = new List<Events>();
        }
    }
}
