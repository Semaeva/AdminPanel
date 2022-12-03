namespace AdminPanel.Models
{
    public class News
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? MainPicturePath { get; set; }

        public ICollection<NewsPictures> NewsPictures { get; set; }//обратная связь однин-ко-многим
        //test
        public News()
        {
            NewsPictures = new List<NewsPictures>();
        }

    }
}
