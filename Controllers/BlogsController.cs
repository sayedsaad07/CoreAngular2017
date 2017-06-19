using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPCoreAngular.Model;
using ASPCoreAngular.ViewModels;

namespace ASPCoreAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Blogs")]
    public class BlogsController : Controller
    {
        private readonly IBloggingContextRepository _repository;

        public BlogsController(IBloggingContextRepository context)
        {
            _repository = context;
        }

        //// GET: api/Blogs
        //[HttpGet]
        //public IEnumerable<Blog> GetBlogs()

        //{
        //    return _context.Blogs;
        //}
        [HttpGet]
        public async Task<IActionResult> GetBlogs()
        {
            return Json(await _repository.GetBlogsSummary());

        }


        // GET: api/Blogs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Blog blog = await _repository.GetBlogByID(id);

            if (blog == null)
            {
                return NotFound();
            }

            return Ok(blog);
        }



        // PUT: api/Blogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlog([FromRoute] int id, [FromBody] Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != blog.BlogId)
            {
                return BadRequest();
            }

            try
            {
                await _repository.UpdateBlogByID(blog);
            }
            catch (DbUpdateConcurrencyException)
            {

                Blog b = await _repository.GetBlogByID(id);
                if (b == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Blogs
        [HttpPost]
        public async Task<IActionResult> PostBlog([FromBody] Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.AddBlog(blog);

            return CreatedAtAction("GetBlog", new { id = blog.BlogId }, blog);
        }

        // DELETE: api/Blogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blog = await _repository.BlogExists(id);
            if (blog == null)
            {
                return NotFound();
            }

            await _repository.RemoveBlog(blog);

            return Ok(blog);
        }
    }
}