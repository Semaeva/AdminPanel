using AdminPanel.Interfaces;
using AdminPanel.Models.PicturesModel;

namespace AdminPanel.Models
{
    public class Managers : IContent
    {
        public int Id { get; set; }
        public string? Name { get ; set ; }
        public string? Description { get; set; }
        public string? PathImage { get;set; }
        public string? NameImage { get; set; }

        //public ICollection<NewsPictures>? Pictures { get; set; }
    }
}
