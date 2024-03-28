using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HoySeComeAPI.Models;
using HoySeComeAPI.Data;

namespace HoySeComeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientesControler : ControllerBase
    {
        private readonly ApiContext _context;

        public IngredientesControler(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult CreateEdit(Ingredientes ingrediente)
        {
            if(ingrediente.Id == 0)
            {
                _context.Ingredientes.Add(ingrediente);
            } else
            {
                var ingredientesInDb = _context.Ingredientes.Find(ingrediente.Id);

                if (ingredientesInDb == null)
                    return new JsonResult(NotFound());

                ingredientesInDb = ingrediente;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(ingrediente));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Ingredientes.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Ingredientes.Find(id);

            if(result==null)
                return new JsonResult(NotFound());

            _context.Ingredientes.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        // Get Name
        [HttpGet("/GetName")]
        public JsonResult Get(string name)
        {
            var result = _context.Ingredientes.
        }
    }
}
