﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using ServiceReference1;
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

        public JsonResult CorreiosCalcular(string cep)
        {
            // Dados da empresa, se tiver contrato com os Correios
            string nCdEmpresa = string.Empty;
            string sDsSenha = string.Empty;
            //Códigos dos tipos de frete:
            // PAC 41106
            // SEDEX 40010
            // SEDEX A COBRAR 40045
            // SEDEX 10 40215
            // SEDEX HOJE  40290
            // Código do tipo de frete - por padrão deixei o pac
            string nCdServico = "41106";
            // Cep de origem e destino - apenas números
            string sCepOrigem = "40280000"; //POR ENQUANTO DEIXEI UM VALOR FIXO
            string sCepDestino = cep; 
            // Peso total da encomenda - por padrão deixei 1kg
            string nVlPeso = "1";
            // Formato da encomenda - por padrão deixei caixa
            int nCdFormato = 1;
            // Para encomenda do tipo PAC, deve-se preencher a dimensão da embalagem
            decimal nVlComprimento = 20;
            decimal nVlAltura = 20;
            decimal nVlLargura = 20;
            decimal nVlDiametro = 0;
            // Informa se é por mão própria - por padrão deixei Não
            string sCdMaoPropria = "N";
            // Valor declarado - por padrão não informo
            decimal nVlValorDeclarado = 0;
            // Se desejo recebr aviso de recebimento - por padrão não quero
            string sCdAvisoRecebimento = "N";

            // Instancio o web-service
        
            ServiceReference1.CalcPrecoPrazoWSSoapClient wsCorreios = new ServiceReference1.CalcPrecoPrazoWSSoapClient();
           
            //   ServiceCorreios.CalcPrecoPrazoWS webServiceCorreios = new ServicesCorreios.CalcPrecoPrazoWS();
            cResultado retornoCorreios = (ServiceReference1)wsCorreios.CalcPrecoPrazoAsync(nCdEmpresa,sDsSenha,nCdServico,sCepOrigem,sCepDestino,nVlPeso,nCdFormato,nVlComprimento,nVlAltura,nVlLargura,nVlDiametro,sCdMaoPropria,nVlValorDeclarado,sCdAvisoRecebimento);
                //CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);

            // Efetuo a requisição
            //   Correios.cResultado retornoCorreios = webServiceCorreios.CalcPrecoPrazo(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            string[] result = new string[2];
            result[1] = retornoCorreios.Servicos[0].PrazoEntrega;
            result[0] = retornoCorreios.Servicos[0].Valor;
            return Json(result);

        }
    }
    }
