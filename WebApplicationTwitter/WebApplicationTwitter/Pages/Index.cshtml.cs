using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationTwitter.Pages
{
    public class IndexHomeModel : PageModel
    {
        private readonly ILogger<IndexHomeModel> _logger;

        public IndexHomeModel(ILogger<IndexHomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}