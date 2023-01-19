using System.ComponentModel.DataAnnotations;

namespace AdminPanel.ViewModels
{
    public class CalendarViewModel
    {
        [Display(Name = "Мероприятие")]
        public string? NameEvent { get; set; }
        [Display(Name = "Год")]
        public string? Year { get; set; }
        [Display(Name = "Месяц")]
        public int? Month { get; set; }
    }
}
