using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils;

namespace UnidadeTeste
{
    public class Tela
    {
        private IConfiguration _configuration;
        private Browser _browser;
        private IWebDriver _driver;

        public Tela(IConfiguration configuration, Browser browser)
        {
            _configuration = configuration;
            _browser = browser;

            string caminhoDriver = null;
            if (browser == Browser.Firefox)
            {
                caminhoDriver =
                    _configuration.GetSection("Selenium:CaminhoDriverFirefox").Value;
            }
            else if (browser == Browser.Chrome)
            {
                caminhoDriver =
                    _configuration.GetSection("Selenium:CaminhoDriverChrome").Value;
            }
            else if (browser == Browser.Edge)
            {
                caminhoDriver =
                    _configuration.GetSection("Selenium:CaminhoDriverEdge").Value;
            }
            else if (browser == Browser.InternetExplorer)
            {
                caminhoDriver =
                    _configuration.GetSection("Selenium:CaminhoDriverInternetExplorer").Value;
            }

            _driver = WebDriverFactory.CreateWebDriver(
                browser, caminhoDriver);
        }
        /// <summary>
        /// O método acionará a operação LoadPage de WebDriverExtensions 
        /// (classe esta também definida em Selenium.Utils), informando à mesma a URL e 
        /// um timeout de 5 segundos para o carregamento da página a ser testada;
        /// </summary>
        public void CarregarPagina()
        {
            _driver.LoadPage(
                TimeSpan.FromSeconds(5),
                _configuration.GetSection("Selenium:UrlTela").Value);
        }
        /// <summary>
        /// A operação PreencherDistanciaMilhas acionará o método SetText de WebDriverExtensions 
        /// com o intuito de simular o preenchimento do campo que conterá o valor de uma distância 
        /// em milhas;
        /// </summary>
        /// <param name="valor"></param>
        public void PreencherDistanciaMilhas(double valor)
        {
            _driver.SetText(
                By.Name("DistanciaMilhas"),
                valor.ToString());
        }
        /// <summary>
        /// O método ProcessarConversao efetuará o envio da distância para conversão, acionando 
        /// para isto a operação Submit de WebDriverExtensions. A chamada ao método Until da 
        /// instância do tipo WebDriverWait (namespace OpenQA.Selenium.Support.UI) fará com que 
        /// se aguarde por 10 segundos o aparecimento de uma resposta em um label cujo Id é 
        /// DistanciaKm; caso isto não 
        /// aconteça um erro é então gerado, de maneira a indicar que o teste em questão não obteve 
        /// sucesso;
        /// </summary>
        public void ProcessarConversao()
        {
            _driver.Submit(By.Id("btnConverter"));

            WebDriverWait wait = new WebDriverWait(
                _driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.Id("DistanciaKm")) != null);
        }
        /// <summary>
        /// A operação ObterDistanciaKm faz uso do método Get de WebDriverExtensions, obtendo 
        /// com isto o valor associado ao label DistanciaKm. Este resultado é então convertido, 
        /// servindo de base para a execução de diferentes casos de teste na classe Testes;
        /// </summary>
        /// <returns></returns>
        public double ObterDistanciaKm()
        {
            return Convert.ToDouble(
                _driver.GetText(By.Id("DistanciaKm")));
        }
        /// <summary>
        /// Já o método Fechar acionará o método Quit da instância do tipo IWebDriver. Este procedimento 
        /// forçará o fechamento de janelas do browser que tenham sido criadas durante a condução de um teste.
        /// A atribuição de null ao atributo _driver contribuirá para liberar
        /// mais rapidamente recursos alocados durante a utilização de um objeto baseado em IWebDriver.
        /// </summary>
        public void Fechar()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}