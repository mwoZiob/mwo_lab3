using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mwo4.Pages
{
    public class IndexModel : PageModel
    {
        public string ver;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            //string path = "../../../version.txt";
            string path = "./api/wwwroot/version.txt";
            if(System.IO.File.Exists(path))
            {
                ver = System.IO.File.ReadAllText(path);
            }
            else
            {
                ver = "unknown";
            }
        }

        public void OnGet()
        {

        }
    }
}