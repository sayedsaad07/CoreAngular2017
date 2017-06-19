using System.Collections.Generic;
using System.Threading.Tasks;
using ASPCoreAngular.ViewModels;

namespace ASPCoreAngular.Model
{
    public interface IBloggingContextRepository
    {
        Task AddBlog(Blog blog);
        Task<Blog> BlogExists(int blogid);
        Task<Blog> GetBlogByID(int id);
        Task<List<Blog_Posts>> GetBlogsSummary();
        Task RemoveBlog(Blog blog);
        Task UpdateBlogByID(Blog blog);
    }
}