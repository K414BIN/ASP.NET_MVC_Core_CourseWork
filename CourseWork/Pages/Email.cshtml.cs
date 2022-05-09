using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace CourseWork.Pages
{
    
    public class EmailModel : PageModel
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; } 
        public string FromEmail { get; set; }
        public string FromPassword { get; set; }
        public IFormFile Attachment { get; set; }       

    }
}