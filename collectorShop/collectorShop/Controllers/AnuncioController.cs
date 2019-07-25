using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace collectorShop.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly IGerenciadorAnuncio gerenciadorAnuncio;
     
        public AnuncioController(IGerenciadorAnuncio _gerenciadorAnuncio)
        {
            gerenciadorAnuncio = _gerenciadorAnuncio;
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
            return View();
        }

        // POST: Anuncio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anuncio anuncio)
        {
            gerenciadorAnuncio.Inserir(anuncio);
            return RedirectToAction(nameof(Index));
        }

        // GET: Anuncio/Edit/5
        public ActionResult Edit(int id)
        {
            Anuncio anuncio = gerenciadorAnuncio.Obter(id);
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