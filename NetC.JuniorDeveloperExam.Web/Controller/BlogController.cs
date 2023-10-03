using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourProjectName.Controllers
{
    public class BlogController : Controller
    {
        public class BlogPost
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
        }



        public ActionResult Display(int id)
        {
            List<BlogPost> blogPosts = GetBlogPosts();
            BlogPost blogPost = blogPosts.FirstOrDefault(post => post.Id == id);

            if (blogPost == null)
            {
                // Handle not found
                return HttpNotFound();
            }

            return View(blogPost);
        }

        // This method simulates loading blog post data from a JSON file
        private List<BlogPost> GetBlogPosts()
        {
            // Replace this with code to load and deserialize your JSON data
            List<BlogPost> blogPosts = new List<BlogPost>
            {
                new BlogPost { Id = 1, Title = "Sample Blog Post 1", Content = "This is the content of the first blog post." },
                new BlogPost { Id = 2, Title = "Sample Blog Post 2", Content = "This is the content of the second blog post." },
                // Add more blog posts as needed
            };

            return blogPosts;
        }
    }
}
