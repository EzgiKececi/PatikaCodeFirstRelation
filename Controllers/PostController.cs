using CodeFirstRelation.Context;
using CodeFirstRelation.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelation.Controllers
{
    public class PostController : Controller
    {
        private readonly PatikaSecondDbContext _context;

        public PostController(PatikaSecondDbContext context)
        {
            _context = context;
        }


        public IActionResult Add()
        {
            var newPost = new PostEntity()
            {
                Title = "Patika",
                Content = "CodeFirst Relation",
                UserId=1
            };

            _context.Posts.Add(newPost);
            _context.SaveChanges();

            return Ok();

        }
    }
}
