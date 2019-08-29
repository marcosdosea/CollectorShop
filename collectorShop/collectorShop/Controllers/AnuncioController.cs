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
    public class AnuncioController : Controller
    {
        private readonly IGerenciadorAnuncio gerenciadorAnuncio;
        private readonly IGerenciadorUsuario gerenciadorUsuario;
        public AnuncioController(IGerenciadorAnuncio _gerenciadorAnuncio, IGerenciadorUsuario _gerenciadorUsuario)
        {
            gerenciadorAnuncio = _gerenciadorAnuncio;
            gerenciadorUsuario = _gerenciadorUsuario;
        }
        // GET: Anuncio
        public ActionResult Index()
        {
            return View(gerenciadorAnuncio.ObterTodos());
        }

        // GET: Anuncio/Details/5
        public ActionResult Details(int id)
        {
            Anuncio anuncio = gerenciadorAnuncio.Obter(id);
            return View(anuncio);
        }

        // GET: Anuncio/Create
        public ActionResult Create()
        {
            ViewBag.CodUsuario= new SelectList(gerenciadorUsuario.ObterTodos(), "CodUsuario", "Nome", null);
            
            return View();
        }

        // POST: Anuncio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                gerenciadorAnuncio.Inserir(anuncio);
                return RedirectToAction(nameof(Index));
            }
            return View(anuncio);
        }

        // GET: Anuncio/Edit/5
        public ActionResult Edit(int id)
        {
            Anuncio anuncio = gerenciadorAnuncio.Obter(id);
            IEnumerable<Usuario> listaUsuario = gerenciadorUsuario.ObterTodos();
            ViewBag.CodUsuario = new SelectList(listaUsuario, "CodUsuario", "Nome",
                listaUsuario.Where(usuario => usuario.CodUsuario == anuncio.CodUsuario).FirstOrDefault());
            return View(anuncio);
           
        }

        // POST: Anuncio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                gerenciadorAnuncio.Editar(anuncio);
                return RedirectToAction(nameof(Index));
            }
                return View(anuncio);
            
        }

        // GET: Anuncio/Delete/5
        public ActionResult Delete(int id)
        {
            Anuncio anuncio = gerenciadorAnuncio.Obter(id);
            return View(anuncio);
        }

        // POST: Anuncio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            gerenciadorAnuncio.Remover(id);
            return RedirectToAction(nameof(Index)); 
        }
    }
}