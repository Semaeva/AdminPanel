namespace AdminPanel.Models
{
    public class Pictures
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int NewsId { get; set; } //foreign key
        public News? News { get; set; }//навигационное поле

        public string? Path { get; set; }
    }
}
