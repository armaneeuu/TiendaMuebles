using Microsoft.AspNetCore.Mvc;
using TiendaMuebles.Models;
using TiendaMuebles.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TiendaMuebles.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CatalogoController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }
        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProducto select o;
            return View(await productos.ToListAsync());
        }
        public async Task<IActionResult> Detalles(int id)
        {
           Producto objProducto = await _context.DataProducto.FindAsync(id);
           if(objProducto == null){
               return NotFound();
           }
           return View(objProducto);
        }
    }
}