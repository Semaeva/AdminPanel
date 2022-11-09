using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.ViewModels
{
    public class BufferedSingleFileUploadDb
    {
        [Display(Name = "File")]
        [DataType(DataType.Upload)]

        public IFormFile? FormFile { get; set; }
    }
    public class NewsViewModel
    {
        /* [BindProperty]
         public BufferedSingleFileUploadDb FileUpload { get; set; }

 */

        [Display(Name = "File")]
        [DataType(DataType.Upload)]

        public IFormFile? FormFile { get; set; }

        //[Display(Name ="Наименование новости")]
        //public string? NameNews { get; set; }

        //[Display(Name = "Описание новости")]
        //public string? DescriptionNews { get; set; }

        //public string? Path { get; set; }




        //[Display(Name ="Наименование фотографии")]
        //public string? NamePictires { get; set; }
        //public string? ReturnUrl {get; set;}    
    }
}
