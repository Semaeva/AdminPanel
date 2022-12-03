using AdminPanel.Interfaces;

namespace AdminPanel.Models
{

    public class Achievements : IContent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<AchievementsPictures>? AchievementsPictures { get; set; }
        public string? MainPicturePath { get; set; }

        public Achievements()
        {
            AchievementsPictures = new List<AchievementsPictures>();
        }
    }
}
