using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorBlog.Pages.Admin.Blogs
{
    public class Add : PageModel
    {
        private readonly ILogger<Add> _logger;

        public Add(ILogger<Add> logger)
        {
            _logger = logger;
        }

        public void OnGet() { }
    }
}
