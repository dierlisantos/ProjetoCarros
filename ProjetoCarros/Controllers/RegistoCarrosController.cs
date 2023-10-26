using Microsoft.AspNetCore.Mvc;
using ProjetoCarros.Data;
using ProjetoCarros.Models;

namespace ProjetoCarros.Controllers
{
    public class RegistoCarrosController : Controller
    {
        readonly private ApplicationDBContext _db;

        public RegistoCarrosController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<RegistoModel> RegistoCarros = _db.RegistosCarros;
            return View(RegistoCarros);
        }
        [HttpGet]
        public IActionResult NovoRegisto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NovoRegisto(RegistoModel RegistoCarros)
        {
            if(ModelState.IsValid)
            {
                _db.RegistosCarros.Add(RegistoCarros);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditarRegisto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistoModel registocarros = _db.RegistosCarros.FirstOrDefault(x => x.Id == id);

            if (registocarros == null)
            {
                return NotFound();
            }

            return View(registocarros);
        }

        [HttpPost]
        public IActionResult EditarRegisto (RegistoModel RegistoCarros)
        {
            if (ModelState.IsValid)
            {
                _db.RegistosCarros.Update(RegistoCarros);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(RegistoCarros);
        }

        [HttpGet]
        public IActionResult ApagarRegisto (int? id)
        { 
            if (id == null)
            {
                return NotFound();
            }
        
        RegistoModel RegistoCarros = _db.RegistosCarros.FirstOrDefault(x => x.Id == id);

                  if (RegistoCarros == null)
                {
                    return NotFound();
            }
             return View(RegistoCarros);
            }

        [HttpPost]
        public IActionResult ApagarRegisto(RegistoModel RegistoCarros)
        {
             if (RegistoCarros == null)
            {
                return NotFound();
            }
            _db.RegistosCarros.Remove(RegistoCarros);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }

  }