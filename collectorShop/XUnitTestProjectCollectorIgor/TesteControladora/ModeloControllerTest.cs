using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using System.Linq;
using collectorShop.Controllers;
using Model;
using Services;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace XUnitTestProjectCollectorIgor.TesteControladora
{
    public class ModeloControllerTest
    {

        [Fact]
        public void Index_ReturnViewResult_ModeloList()
        {
            // Arrange

            var mockRepo =
                new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();


            mockRepo.Setup(r => r.ObterTodos()).Returns(ObterTestModelo());
            mockRepo04.Setup(r => r.ObterTodos()).Returns(ObterTestCategoria());
            mockRepo02.Setup(r => r.ObterTodos()).Returns(ObterTestSubCategoria());
            mockRepo03.Setup(r => r.ObterTodos()).Returns(ObterTestUsuario());
            var controller = new ModeloController(mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);

            //Act
            var result = controller.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Modelo>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count);

        }

        private IEnumerable<Usuario> ObterTestUsuario()
        {
            return new List<Usuario>()
            {
                new Usuario()
                {
                    Administrador = "True",
                    Cpf = "09314854239",
                    Nome = "Igor",
                    Cep = "49500000",
                    Cidade = "Frei Paulo",
                    CodUsuario = 1,
                    Email = "igor@bol.com",
                    Estado = "SE",
                    Senha = "olaeusouoronald"
                }
            };
        }

        private IEnumerable<Subcategoria> ObterTestSubCategoria()
        {
            return new List<Subcategoria>()
            {
                new Subcategoria()
                {
                    CodCategoria = 1,
                    Nome = "Barbie",
                    NomeCategoria = "Brinquedos"
                },
                new Subcategoria()
                {
                    CodCategoria = 2,
                    Nome = "Barbie",
                    NomeCategoria = "Brinquedos"
                }
            };
        }

        private IEnumerable<Categoria> ObterTestCategoria()
        {

            return new List<Categoria>()
            {
                new Categoria()
                {
                    CodCategoria =1,
                    Nome = "Brinquedos"
                },

                new Categoria()
                {
                    CodCategoria = 2,
                    Nome = "Brinquedos"
                }
            };
        }

        private IEnumerable<Modelo> ObterTestModelo()
        {
            return new List<Modelo>()
            {
                new Modelo()
                {

                    Ano = "2000",
                    Autor = "Igor",
                    CodModelo = 1,
                    CodSubcategoria = 1,
                    CodUsuario = 1,
                    Colecao = "Chique",
                    Desenhista = "Carlos",
                    Edicao = "premium",
                    Isbn = "0123456789123",
                    Label = "xxx",
                    Marca = "Hot",
                    Nome = "Barbie",
                    nomeSubCategoria = "Traquinas",
                    nomeUsuario = "Sandro",
                    QuantTiragem = "Raro",
                    Roteirista = "Alemberg"

                },
                new Modelo()
                {
                    Ano = "2010",
                    Autor = "Igor",
                    CodModelo = 2,
                    CodSubcategoria = 2,
                    CodUsuario = 2,
                    Colecao = "Chique",
                    Desenhista = "Carlos",
                    Edicao = "premium",
                    Isbn = "0123487489123",
                    Label = "tipico",
                    Marca = "Charman",
                    Nome = "Barbie",
                    nomeSubCategoria = "Traquinas",
                    nomeUsuario = "Sandro",
                    QuantTiragem = "Raro",
                    Roteirista = "Alemberg"
                }
            };
        }

        [Fact]

        public void Add_ReturnsBadRequestResult_WhenModelStateIsInvalid()
        {
            var mockRepo =
                new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();

            var controller = new ModeloController(
                mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);
            controller.ModelState.AddModelError("Nome", "Required");
            var newModelo = GetTestModelo();

            //Act
            var result = controller.Create(newModelo);

            //Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);

        }
        [Fact]
        public void Add_AddsEmployeeAndReturnsARedirect_WhenModelStateIsValid()
        {
            // Arrange
            var mockRepo =
                new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();

            mockRepo.Setup(re => re.Inserir(It.IsAny<Modelo>())).Verifiable();
            mockRepo02.Setup(re => re.Inserir(It.IsAny<Subcategoria>())).Verifiable();
            mockRepo03.Setup(re => re.Inserir(It.IsAny<Usuario>())).Verifiable();
            mockRepo04.Setup(re => re.Adicionar(It.IsAny<Categoria>())).Verifiable();

            var controller = new ModeloController(
                mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);


            var newEmployee = GetTestModelo();

            // Act
            var result = controller.Create(newEmployee);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Index", redirectToActionResult.ActionName);
            mockRepo.Verify();
        }
        private Modelo GetTestModelo()
        {
            return new Modelo()
            {
                Ano = "2000",
                Autor = "Igor",
                CodModelo = 1,
                CodSubcategoria = 1,
                CodUsuario = 1,
                Colecao = "Chique",
                Desenhista = "Carlos",
                Edicao = "premium",
                Isbn = "0123456789123",
                Label = "xxx",
                Marca = "Hot",
                Nome = "Barbie",
                nomeSubCategoria = "Traquinas",
                nomeUsuario = "Sandro",
                QuantTiragem = "Raro",
                Roteirista = "Alemberg"
            };
        }

        [Fact]
        public void Edit_ReturnaResultadoDeErro_QuandoCodModeloInvalido()
        {
            // Arrange

            var mockRepo =
                new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();
            mockRepo.Setup(r => r.ObterTodos()).Returns(ObterTestModelo());
            mockRepo04.Setup(r => r.ObterTodos()).Returns(ObterTestCategoria());
            mockRepo02.Setup(r => r.ObterTodos()).Returns(ObterTestSubCategoria());
            mockRepo03.Setup(r => r.ObterTodos()).Returns(ObterTestUsuario());
            var controller = new ModeloController(mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);
            controller.ModelState.AddModelError("Nome", "Required");


            var alterarUsuario = ObterTestModelo();

            // Act
            var result = controller.Edit(1, alterarUsuario.FirstOrDefault());

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
        [Fact]
        public void Edit_ModeloAndReturnComRedirecionamento_WhenModeloStateisValid()
        {
            // Arrange
            var mockRepo =
                new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();

            mockRepo.Setup(repo => repo.Obter(1));
            mockRepo02.Setup(repo => repo.Obter(1));
            mockRepo03.Setup(repo => repo.Obter(1));
            mockRepo04.Setup(repo => repo.Obter(1));

            var controller = new ModeloController(mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);


            // Act
            var result = controller.Edit(1);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Edit", redirectToActionResult.ActionName);
            mockRepo.Verify();
        }

        [Fact]
        public void Details_Retornar_detalhes_de_modelo_existente()
        {
            var model = new Modelo();
            var model01 = new Subcategoria();
            var model02 = new Usuario();
            var model03 = new Categoria();
            var mockRepo = new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();
            mockRepo.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => model);
            mockRepo02.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => model01);
            mockRepo03.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => model02);
            mockRepo04.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => model03);
            var controller = new ModeloController(mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);
            ViewResult result = controller.Details(1) as ViewResult;
            var viewName = result.ViewName;


            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Details");
            Assert.Equal(model, result.Model);

        }
        [Fact]
        public void Details_Retornar_detalhes_de_modelo_inexistente()
        {

            var mockRepo = new Mock<IServiceModelo>();
            var mockRepo02 = new Mock<IGerenciadorSubcategoria>();
            var mockRepo03 = new Mock<IGerenciadorUsuario>();
            var mockRepo04 = new Mock<IService<Categoria>>();
            mockRepo.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => null);
            mockRepo02.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => null);
            mockRepo03.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => null);
            mockRepo04.Setup(c => c.Obter(It.IsAny<int>())).Returns(() => null);
            var controller = new ModeloController(mockRepo.Object, mockRepo02.Object, mockRepo04.Object, mockRepo03.Object);
            var result = controller.Details(-1);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
