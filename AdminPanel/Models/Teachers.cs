using AdminPanel.Interfaces;
using AdminPanel.Models.PicturesModel;

namespace AdminPanel.Models
{
    public class Teachers : IContent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<TeachersPicture> TeachersPictures { get; set; }

        public Teachers()
        {
            TeachersPictures =new List<TeachersPicture>();
        }
    }
}
