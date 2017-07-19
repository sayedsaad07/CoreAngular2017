using ASPCoreAngular.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAngular.Model
{
    public class BloggingContextRepository : IBloggingContextRepository
    {
        private readonly BloggingContext _context;
        public BloggingContextRepository(BloggingContext context)
        {
            _context = context;
        }


        public async Task<List<Blog_Posts>> GetBlogsSummary()
        {
            List<Blog_Posts> blog_postList = new List<Blog_Posts>();
            var datalist = await (from b in _context.Blogs
                                  join p in _context.Posts on b.BlogId equals p.BlogId
                                  select new { b.BlogId, p.PostUrl, b.Subject, p.Title, p.Content }
                                  ).ToListAsync();
            datalist.ForEach(bp =>
            {
                var newblogpost = new Blog_Posts();
                newblogpost.BlogId = bp.BlogId;
                newblogpost.PostUrl = bp.PostUrl;
                newblogpost.BlogName = bp.Subject;
                newblogpost.postName = bp.Title;
                newblogpost.postContent = bp.Content;
                blog_postList.Add(newblogpost);
            }
            );
            return blog_postList;
        }

        public async Task<Blog> GetBlogByID(int id)
        {
            return await _context.Blogs.SingleOrDefaultAsync(m => m.BlogId == id);
        }

        public async Task<Blog> BlogExists(int blogid)
        {
           return await _context.Blogs.SingleOrDefaultAsync(m => m.BlogId == blogid);
        }
        public async Task UpdateBlogByID(Blog blog)
        {
            _context.Entry(blog).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task AddBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveBlog(Blog blog)
        {

            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();

        }
    }
}
