using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace collectorShop.Controllers
{
    public class NegociacaoAnuncioController : Controller
    {
        private readonly IGerenciadorUsuario _gerenciadorUsuario;
        private readonly IServiceNegociacao _serviceNegociacao;
        private readonly IServiceNegociacaoAnuncio _serviceNegociacaoAnuncio;

        public NegociacaoAnuncioController(IGerenciadorUsuario gerenciadorUsuario, IServiceNegociacao serviceNegociacao, IServiceNegociacaoAnuncio serviceNegociacaoAnuncio)
        {
            _gerenciadorUsuario = gerenciadorUsuario;
            _serviceNegociacao = serviceNegociacao;
            _serviceNegociacaoAnuncio = serviceNegociacaoAnuncio;

        }

        // GET: NegociacaoAnuncio
        public ActionResult Index()
        {
            return View(_serviceNegociacaoAnuncio.ObterTodos());
        }

        // GET: NegociacaoAnuncio/Details/5
        public IActionResult Details(int codAnuncio, int codNegociacao)
        {
            NegociacaoAnuncio negociacaoAnuncio = _serviceNegociacaoAnuncio.Obter(codNegociacao, codAnuncio);
            return View(negociacaoAnuncio);
        }

        // GET: NegociacaoAnuncio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NegociacaoAnuncio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NegociacaoAnuncio negociacaoAnuncio)
        {
            if (ModelState.IsValid)
            {
                _serviceNegociacaoAnuncio.Inserir(negociacaoAnuncio);
            }

            return View(negociacaoAnuncio);
        }

        // GET: NegociacaoAnuncio/Edit/5
        public ActionResult Edit(NegociacaoAnuncio negociacaoAnuncio)
        {

            if (ModelState.IsValid)
            {
                _serviceNegociacaoAnuncio.Editar(negociacaoAnuncio);
                return RedirectToAction(nameof(Index));
            }
                return View(negociacaoAnuncio);
        }

        // POST: NegociacaoAnuncio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int codNegociacao, int codAnuncio, IFormCollection collection)
        {
            NegociacaoAnuncio negociacaoAnuncio = _serviceNegociacaoAnuncio.Obter(codAnuncio, codNegociacao);
            IEnumerable<NegociacaoAnuncio> lista = _serviceNegociacaoAnuncio.ObterTodos();
            ViewBag.CodUsuario = new SelectList(lista, "Codigo Anuncio", "Codigo Negociacao",
                lista.Where(
                    x => x.CodAnuncio == negociacaoAnuncio.CodAnuncio && x.CodNegociacao == negociacaoAnuncio.CodNegociacao)).FirstOrDefault();

                return View(negociacaoAnuncio);
            
        }

        // GET: NegociacaoAnuncio/Delete/5
        public ActionResult Delete(int codNegociacao, int codAnuncio)
        {
            NegociacaoAnuncio negociacao = _serviceNegociacaoAnuncio.Obter(codNegociacao, codAnuncio);
            return View(negociacao);
        }

        // POST: NegociacaoAnuncio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int codNegociacao, int codAnuncio, IFormCollection collection)
        {
            _serviceNegociacaoAnuncio.Remover(codNegociacao, codAnuncio);

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