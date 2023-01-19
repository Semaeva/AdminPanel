namespace AdminPanel.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Day { get; set; }
        public string? FullDate { get; set; }
        public int? CalendarId { get; set; }
        public Calendar? Calendar { get; set; }
    }
}
