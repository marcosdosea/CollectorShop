using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Services;

namespace collectorShop.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly IService<Categoria> _servicesCategoria;

        public CategoriaController(IService<Categoria> servicesCategoria)
        {
            _servicesCategoria = servicesCategoria;
        }

        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categoria/Create
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
            return Index();
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}