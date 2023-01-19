using AdminPanel.Interfaces;

namespace AdminPanel.Models.PicturesModel
{
    public class AchievementsPictures : IPictures
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }

        public int AchievementsId { get; set; }
        public Achievements Achievements { get; set; }
    }
}
