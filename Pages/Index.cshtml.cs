using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace mwo4.Pages
{
    public class IndexModel : PageModel
    {
        public string ver;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            string path = "../version.txt";
            if(File.Exists(path))
            {
                ver = File.ReadAllText(path);
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