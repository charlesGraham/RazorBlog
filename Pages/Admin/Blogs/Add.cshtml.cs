using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBlog.Data;
using RazorBlog.Models.Domain;
using RazorBlog.Models.ViewModels;

namespace RazorBlog.Pages.Admin.Blogs
{
    public class Add : PageModel
    {
        [BindProperty]
        public AddBlogPost? AddBlogPostReq { get; set; }
        private readonly RazorBlogDbContext _razorBlogDbContext;

        public Add(RazorBlogDbContext razorBlogDbContext)
        {
            _razorBlogDbContext = razorBlogDbContext;
        }

        public void OnGet() { }

        public void OnPost()
        {
            var blogPost = new BlogPost();

            if (AddBlogPostReq is not null)
            {
                blogPost = new BlogPost()
                {
                    Heading = AddBlogPostReq.Heading,
                    PageTitle = AddBlogPostReq.PageTitle,
                    Content = AddBlogPostReq.Content,
                    ShortDescription = AddBlogPostReq.ShortDescription,
                    FeaturedImageUrl = AddBlogPostReq.FeaturedImageUrl,
                    UrlHandle = AddBlogPostReq.UrlHandle,
                    PublishedDate = AddBlogPostReq.PublishedDate,
                    Author = AddBlogPostReq.Author,
                    Visible = AddBlogPostReq.Visible,
                };
            }

            _razorBlogDbContext.BlogPosts.Add(blogPost);
            _razorBlogDbContext.SaveChanges();
        }
    }
}
