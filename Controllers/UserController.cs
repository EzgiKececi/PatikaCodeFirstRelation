using CodeFirstRelation.Context;
using CodeFirstRelation.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using System.Net.WebSockets;

namespace CodeFirstRelation.Controllers
{
    public class UserController : Controller
    {
        private readonly PatikaSecondDbContext _context;

        public UserController(PatikaSecondDbContext context)
        {
            _context = context;
        }

       

        public IActionResult Add()
        {
            var userName = new UserEntity()
            {
                UserName = "Yeni Kullanıcı",
                Email = "yenikullanici@patika.dev"
            };

            _context.Users.Add(userName);
            _context.SaveChanges();

            return Ok();

        }

        
        
        
    };
}
