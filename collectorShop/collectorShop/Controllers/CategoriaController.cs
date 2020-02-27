using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Services;

namespace collectorShop.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        private readonly IService<Categoria> _servicesCategoria;

        public CategoriaController(IService<Categoria> servicesCategoria)
        {
            _servicesCategoria = servicesCategoria;
        }

        // GET: Categoria
        public IActionResult Index()
        {
            return View(_servicesCategoria.ObterTodos());
        }

        // GET: Categoria/Details/5
        public IActionResult Details(int id)
        {
           
            Categoria cat = _servicesCategoria.Obter(id);
            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }

        // GET: Categoria/Create
        [Authorize(Roles ="administrador")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                /*if (_servicesCategoria.Adicionar(categoria))
                {
                    //sucesso
                }
                else
                {
                    // erro
                }*/

                var id = _servicesCategoria.Adicionar(categoria);

                if (id == -999)
                {
                    //mensagem de erro
                }
                else
                {
                    //mensagem de sucesso
                }
                //servicesCategoria.Adicionar(categoria);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Categoria/Edit/5
        [Authorize(Roles = "administrador")]
        public IActionResult Edit(int id)

        {
            Categoria categoria = _servicesCategoria.Obter(id);
            return View(categoria);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Categoria categoria)
        {
            try
            {
                // TODO: Ad_serd update logic here
                _servicesCategoria.Editar(categoria);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //throw new InvalidProgramException();
                return View(categoria);
            }
        }

        // GET: Categoria/Delete/5
        [Authorize(Roles = "administrador")]
        public IActionResult Delete(int id)
        {
            Categoria cat = _servicesCategoria.Obter(id);
            return View(cat);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _servicesCategoria.Remover(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        

    }
}