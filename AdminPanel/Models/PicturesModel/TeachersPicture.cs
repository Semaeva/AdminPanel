using AdminPanel.Interfaces;

namespace AdminPanel.Models.PicturesModel
{
    public class TeachersPicture : IPictures
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
    }
}
