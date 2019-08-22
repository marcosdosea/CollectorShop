using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using Services;

namespace collectorShop.Controllers
{
    public class ModeloController : Controller
    {
        private readonly IServiceModelo _servicesModelo;
        private readonly IGerenciadorSubcategoria _gerenciadorSubcategoria;
        private readonly IGerenciadorUsuario _gerenciadorUsuario;
        private readonly IService<Categoria> _gerenciadorCategoria;
        // GET: Modelo

        public ModeloController(IServiceModelo serviceModelo, IGerenciadorSubcategoria gerenciadorSubcategoria, IService<Categoria> gerenciadorCategoria, IGerenciadorUsuario gerenciadorUsuario)
        {
            _servicesModelo = serviceModelo;
            _gerenciadorSubcategoria = gerenciadorSubcategoria;
            _gerenciadorCategoria = gerenciadorCategoria;
            _gerenciadorUsuario = gerenciadorUsuario;
        }
        public IActionResult Index()
        {
            return View(_servicesModelo.ObterTodos());
        }

        // GET: Modelo/Details/5
        public IActionResult Details(int id)
        {
            Modelo modelo = _servicesModelo.Obter(id);
            return View(modelo);
        }

        // GET: Modelo/Create
        public IActionResult Create()
        {
            ViewBag.CodCategoria = new SelectList(_gerenciadorCategoria.ObterTodos(), "CodCategoria", "Nome", null);
            ViewBag.CodSubcategoria = new SelectList(_gerenciadorSubcategoria.ObterTodos(), "CodSubcategoria", "Nome", null);
            return View();
        }

        // POST: Modelo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                _servicesModelo.Inserir(modelo);
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // GET: Modelo/Edit/5
        public ActionResult Edit(int id)
        {
            Modelo modelo = _servicesModelo.Obter(id);
            IEnumerable<Subcategoria> listaSubCategoria = _gerenciadorSubcategoria.ObterTodos();
            ViewBag.CodSubcategoria = new SelectList(listaSubCategoria, "codSubcategoria", "nome",
            listaSubCategoria.Where(subcategoria => subcategoria.CodSubcategoria == modelo.CodSubcategoria).FirstOrDefault());

            IEnumerable<Usuario> listaUsuario = _gerenciadorUsuario.ObterTodos();
            ViewBag.CodUsuario = new SelectList(listaUsuario, "CodUsuario", "nome",
            listaUsuario.Where(usuario => usuario.CodUsuario == modelo.CodUsuario).FirstOrDefault());

            return View(modelo);
        }

        // POST: Modelo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                _servicesModelo.Editar(modelo);
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // GET: Modelo/Delete/5
        public ActionResult Delete(int id)
        {
            Modelo modelo = _servicesModelo.Obter(id);
            return View(modelo);
        }

        // POST: Modelo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _servicesModelo.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}