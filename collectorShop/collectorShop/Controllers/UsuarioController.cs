using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;
using System;
using System.Linq;

namespace collectorShop.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IGerenciadorUsuario gerenciadorUsuario;

        public UsuarioController(IGerenciadorUsuario _gerenciadorUsuario)
        {
            gerenciadorUsuario = _gerenciadorUsuario;
        }
        // GET: usuario
        public ActionResult Index()
        {
            return View(gerenciadorUsuario.ObterTodos());
        }

        // GET: usuario/Details/5
        public ActionResult Details(int id)
        {
            Usuario usuario = gerenciadorUsuario.Obter(id);
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                gerenciadorUsuario.Inserir(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: usuario/Edit/5
        public ActionResult Edit(int id)
        {
            Usuario usuario = gerenciadorUsuario.Obter(id);
            return View(usuario);
        }

        // POST: usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                gerenciadorUsuario.Editar(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);

        }

        // GET: usuario/Delete/5
        public ActionResult Delete(int id)
        {
            Usuario usuario = gerenciadorUsuario.Obter(id);
            return View(usuario);
        }

        // POST: usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            gerenciadorUsuario.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}