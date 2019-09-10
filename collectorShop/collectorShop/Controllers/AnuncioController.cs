using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using ServiceCorreios;
using Services;


namespace collectorShop.Controllers
{
    [Authorize]
    public class AnuncioController : Controller
    {
        private readonly IGerenciadorAnuncio gerenciadorAnuncio;
        private readonly IGerenciadorUsuario gerenciadorUsuario;
        private readonly ServiceCorreios.CalcPrecoPrazoWSSoap wsCorreios;
        
        //cResultado
        public AnuncioController(IGerenciadorAnuncio _gerenciadorAnuncio, IGerenciadorUsuario _gerenciadorUsuario,
            ServiceCorreios.CalcPrecoPrazoWSSoap _wsCorreios)
        {
            gerenciadorAnuncio = _gerenciadorAnuncio;
            gerenciadorUsuario = _gerenciadorUsuario;
            wsCorreios = _wsCorreios;
        }
        // GET: Anuncio
        public ActionResult Index()
        {
            return View(gerenciadorAnuncio.ObterTodos());
        }

        // GET: Anuncio/Details/5
        [AllowAnonymous]
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
      /*  
        public JsonResult CorreiosCalcular(string cep)
        {
            // Dados da empresa, se tiver contrato com os Correios
            var nCdEmpresa = string.Empty;
            var sDsSenha = string.Empty;
            //Códigos dos tipos de frete:
            // PAC 41106
            // SEDEX 40010
            // SEDEX A COBRAR 40045
            // SEDEX 10 40215
            // SEDEX HOJE  40290
            // Código do tipo de frete - por padrão deixei o pac
            var nCdServico = "41106";
            // Cep de origem e destino - apenas números
            var sCepOrigem = "40280000"; //POR ENQUANTO DEIXEI UM VALOR FIXO
            var sCepDestino = cep; 
            // Peso total da encomenda - por padrão deixei 1kg
            var nVlPeso = "1";
            // Formato da encomenda - por padrão deixei caixa
            var nCdFormato = 1;
            // Para encomenda do tipo PAC, deve-se preencher a dimensão da embalagem
            var nVlComprimento = 20;
            var nVlAltura = 20;
            var nVlLargura = 20;
            var nVlDiametro = 0;
            // Informa se é por mão própria - por padrão deixei Não
            var sCdMaoPropria = "N";
            // Valor declarado - por padrão não informo
            var nVlValorDeclarado = 0;
            // Se desejo recebr aviso de recebimento - por padrão não quero
            var sCdAvisoRecebimento = "N";

            // Instancio o web-service
            wsCorreios.CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            // Efetuo a requisição
            cResultado retornoCorreios; 
            retornoCorreios= wsCorreios.CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento).Result;

            string[] result = new string[2];
            result[1] = retornoCorreios.Servicos[0].PrazoEntrega;
            result[0] = retornoCorreios.Servicos[0].Valor;
            return Json(result);

        } */
    }
    }
