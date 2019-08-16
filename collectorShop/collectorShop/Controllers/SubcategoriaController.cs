using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace collectorShop.Controllers
{
    public class SubcategoriaController : Controller
    {
        private readonly IGerenciadorSubcategoria gerenciadorSubcategoria;
        private readonly IService<Categoria> gerenciadorCategoria;

        public SubcategoriaController(IGerenciadorSubcategoria _gerenciadorSubcategoria, IService<Categoria> _gerenciadorCategoria)
        {
            gerenciadorSubcategoria = _gerenciadorSubcategoria;
            gerenciadorCategoria = _gerenciadorCategoria;
        }
        // GET: Subcategoria
        public ActionResult Index()
        {
            return View(gerenciadorSubcategoria.ObterTodos());
        }

        // GET: Subcategoria/Details/5
        public ActionResult Details(int id)
        {
            Subcategoria subcategoria = gerenciadorSubcategoria.Obter(id);
            return View(subcategoria);
        }

        // GET: Subcategoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subcategoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subcategoria subcategoria)
        {
            if (ModelState.IsValid)
            {
                gerenciadorSubcategoria.Inserir(subcategoria);
                return RedirectToAction(nameof(Index));
            }
            return View(subcategoria);
        }

        // GET: Subcategoria/Edit/5
        public ActionResult Edit(int id)
        {
            Subcategoria subcategoria = gerenciadorSubcategoria.Obter(id);
            return View(subcategoria);
        }

        // POST: Subcategoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Subcategoria subcategoria)
        {
            if (ModelState.IsValid)
            {
                gerenciadorSubcategoria.Editar(subcategoria);
                return RedirectToAction(nameof(Index));
            }
            return View(subcategoria);

        }

        // GET: Subcategoria/Delete/5
        public ActionResult Delete(int id)
        {
            Subcategoria subcategoria = gerenciadorSubcategoria.Obter(id);
            return View(subcategoria);
        }

        // POST: Subcategoria/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            gerenciadorSubcategoria.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}