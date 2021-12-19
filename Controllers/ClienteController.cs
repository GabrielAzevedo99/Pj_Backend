using Crud.Models;
using Crud.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Crud.Controllers
{
    [Route("Cliente")]
    public class ClienteController : Controller

    {
     

        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();
          
            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.Id > 0).ToList();            
           return View();
        }
        [HttpPost]
        [Route("Listar")]
        public IActionResult Index(Cliente cliente)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
