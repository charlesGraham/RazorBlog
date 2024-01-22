using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Models.ViewModels;

namespace RazorBlog.Pages.Admin.Blogs
{
    public class Add : PageModel
    {
        [BindProperty]
        public AddBlogPost AddBlogPostReq { get; set; }

        public void OnGet() { }

        public void OnPost()
        {
            var heading = Request.Form["heading"];
            var title = Request.Form["title"];
            var content = Request.Form["content"];
            var shortDescription = Request.Form["shortDescription"];
        }
    }
}
