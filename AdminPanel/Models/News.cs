namespace AdminPanel.Models
{
    public class News
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Pictures> Pictures { get; set; }//обратная связь однин-ко-многим

        public News()
        {
            Pictures = new List<Pictures>();
        }

    }
}
