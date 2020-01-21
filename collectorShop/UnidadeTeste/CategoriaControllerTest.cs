using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using collectorShop.Controllers;
using Model;
using Services;
using System.Threading.Tasks;

namespace UnidadeTeste
{
    public class CategoriaControllerTest
    {
		[Fact]
		public void Index_RetornaResultadoView_ComUmaListaDeCategorias()
		{
			// Arrange
			var mockRepo = new Mock<IService<Categoria>>();
			mockRepo.Setup(repo => repo.ObterTodos())
					.Returns(ObterTestCategorias());
			var controller = new CategoriaController(mockRepo.Object);

			// Act
			var result = controller.Index();

			// Assert
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Categoria>>(
				viewResult.ViewData.Model);
			Assert.Equal(2, model.Count());
		}

		[Fact]
		public void Create_ReturnaResultadoDeErro_QuandoEstadoDeModeloInvalido()
		{
			// Arrange
			var mockRepo = new Mock<IService<Categoria>>();

			var controller = new CategoriaController(mockRepo.Object);
			controller.ModelState.AddModelError("Nome", "Required");
			var novaCategoria = ObterTestCategoria();

			// Act
			var result = controller.Create(novaCategoria);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.IsType<SerializableError>(badRequestResult.Value);
		}

		[Fact]
		public void Create_AdicionaCategoriaERetornaComRedirecionamento_QuandoEstadoDeModeloValido()
		{
			// Arrange
			var mockRepo = new Mock<IService<Categoria>>();
			mockRepo.Setup(repo => repo.Adicionar(It.IsAny<Categoria>()))
				.Verifiable();
			var controller = new CategoriaController(mockRepo.Object);
			var novaCategoria = ObterTestCategoria();

			// Act
			var result = controller.Create(novaCategoria);

			// Assert
			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Null(redirectToActionResult.ControllerName);
			Assert.Equal("Index", redirectToActionResult.ActionName);
			mockRepo.Verify();
		}
		[Fact]
		public void Edit_ReturnaResultadoDeErro_QuandoCodUsuarioInvalido()
		{
			// Arrange
			var mockRepo = new Mock<IGerenciadorUsuario>();

			var controller = new UsuarioController(mockRepo.Object);
			controller.ModelState.AddModelError("Nome", "Required");
			var id = (int)5;
			var alterarUsuario = ObterTestUsuario();

			// Act
			var result = controller.Edit(id, alterarUsuario);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.IsType<SerializableError>(badRequestResult.Value);
		}

		[Fact]
		public void Edit_EditaUsuarioERetornaComRedirecionamento_QuandoEstadoDeModeloValido()
		{
			// Arrange
			var mockRepo = new Mock<IGerenciadorUsuario>();
			var id = 1;
			mockRepo.Setup(repo => repo.Obter(id));

			var controller = new UsuarioController(mockRepo.Object);
			var novoUsuario = ObterTestUsuario();

			// Act
			var result = controller.Edit(id, novoUsuario);

			// Assert
			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Null(redirectToActionResult.ControllerName);
			Assert.Equal("Edit", redirectToActionResult.ActionName);
			mockRepo.Verify();
		}
		[Fact]

		public void Details_Deve_retornar_detalhes_de_um_usuario_existente()

		{

			var Mock = new Mock<IGerenciadorUsuario>();

			var id = 1;

			Mock.Setup(c => c.Obter(id));

			var controller = new UsuarioController(Mock.Object);

			var novoUsuario = ObterTestUsuario();

			var result = controller.Details(id);

			// Assert
			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Null(redirectToActionResult.ControllerName);
			Assert.Equal("Details", redirectToActionResult.ActionName);
			Mock.Verify();
		}
		[Fact]

		public void Details_Retorna_MensagemErro_de_usuario_NaoEncontrado()

		{

			var Mock = new Mock<IGerenciadorUsuario>();

			var id = 9;

			Mock.Setup(c => c.Obter(id));

			var controller = new UsuarioController(Mock.Object);

			var novoUsuario = ObterTestUsuario();

			var result = controller.Details(id);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.IsType<SerializableError>(badRequestResult.Value);
		}

		private IEnumerable<Categoria> ObterTestCategorias()
		{
			return new List<Categoria>()
	{
		new Categoria()
		{
			CodCategoria = 1,
			Nome = "Brinquedos"
		},
		new Categoria()
		{
			CodCategoria = 2,
			Nome = "Livros"
		}
	};
		}

		private Categoria ObterTestCategoria()
		{
			return new Categoria()
			{
				CodCategoria = 1,
				Nome = "Livros"
			};
		}
	}
}
