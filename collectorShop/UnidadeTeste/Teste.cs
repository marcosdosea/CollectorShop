using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils;
using Xunit;

namespace UnidadeTeste
{
    public class Testes
    {
        private IConfiguration _configuration;

        public Testes()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            _configuration = builder.Build();
        }
        [Theory]

        [InlineData(Browser.Firefox, 100, 160.9)]

        [InlineData(Browser.Firefox, 230.05, 370.1505)]

        [InlineData(Browser.Firefox, 250.5, 403.0545)]

        [InlineData(Browser.Chrome, 100, 160.9)]

        [InlineData(Browser.Chrome, 230.05, 370.1505)]

        [InlineData(Browser.Chrome, 250.5, 403.0545)]

        public void TestarConversaoDistancia(

            Browser browser, double valorMilhas, double valorKm)

        {

            Tela tela =

                new Tela(_configuration, browser);



            tela.CarregarPagina();

            tela.PreencherDistanciaMilhas(valorMilhas);

            tela.ProcessarConversao();

            double resultado = tela.ObterDistanciaKm();

            tela.Fechar();



            Assert.Equal(valorKm, resultado);

        }

    }
}
