namespace AdminPanel.Models
{
    public class NewsPictures
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? NewsId { get; set; } //foreign key
        public News? News { get; set; }//навигационное поле

        public int? AchievementsId { get; set; }
        public Achievements? Achievements { get; set; }

        public int? TeachersId { get; set; }
        public Teachers? Teachers { get; set; }

        public string? Path { get; set; }
    }
}
