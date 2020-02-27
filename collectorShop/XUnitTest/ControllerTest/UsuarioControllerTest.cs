using Microsoft.AspNetCore.Mvc;

using Moq;

using Xunit;

using System.Collections.Generic;

using System.Linq;

using collectorShop.Controllers;

using Model;

using Services;

using System.Threading.Tasks;



namespace XUnitTest.ControllerTest

{

	public class UsuarioControllerTest

	{

		[Fact]

		public void Index_RetornaResultadoView_ComUmaListaDeUsuarios()

		{

			// Arrange

			var mockRepo = new Mock<IGerenciadorUsuario>();

			//var mockRepo = new Mock<IGerenciadorUsuario<Usuario>>();

			mockRepo.Setup(repo => repo.ObterTodos())

					.Returns(ObterTestUsuarios());

			var controller = new UsuarioController(mockRepo.Object);



			// Act

			var result = controller.Index();



			// Assert

			var viewResult = Assert.IsType<ViewResult>(result);

			var model = Assert.IsAssignableFrom<List<Usuario>>(

				viewResult.ViewData.Model);

			Assert.Equal(2, model.Count());

		}



		[Fact]

		public void Create_ReturnaResultadoDeErro_QuandoEstadoDeModeloInvalido()

		{

			// Arrange

			var mockRepo = new Mock<IGerenciadorUsuario>();



			var controller = new UsuarioController(mockRepo.Object);

			controller.ModelState.AddModelError("Nome", "Required");

			var novoUsuario = ObterTestUsuario();



			// Act

			var result = controller.Create(novoUsuario);



			// Assert

			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);

			Assert.IsType<SerializableError>(badRequestResult.Value);

		}



		[Fact]

		public void Create_AdicionaUsuarioERetornaComRedirecionamento_QuandoEstadoDeModeloValido()

		{

			// Arrange

			var mockRepo = new Mock<IGerenciadorUsuario>();

			mockRepo.Setup(repo => repo.Inserir(It.IsAny<Usuario>()))

				.Verifiable();

			var controller = new UsuarioController(mockRepo.Object);

			var novoUsuario = ObterTestUsuario();



			// Act

			var result = controller.Create(novoUsuario);



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



		private IEnumerable<Usuario> ObterTestUsuarios()

		{

			return new List<Usuario>()

	{

		new Usuario()

		{

			CodUsuario = 1,

			Nome = "John",

			Cpf = "07864245696",

			Cidade = "Itabaiana",

			Estado = "Sergipe",

			Email = "johnjones@hotmail.com",

			Senha = "ma@coeo14",

			Cep = "4950000"

		},

		new Usuario()

		{

			CodUsuario = 2,

			Nome = "Doe",

			Cpf = "07800045696",

			Cidade = "Aracaju",

			Estado = "Sergipe",

			Email = "doe_2019@hotmail.com",

			Senha = "ja@coeo14",

			Cep = "4954300"

		}

	};

		}



		private Usuario ObterTestUsuario()

		{

			return new Usuario()

			{

				CodUsuario = 1,

				Nome = "John",

				Cpf = "07864245696",

				Cidade = "Itabaiana",

				Estado = "Sergipe",

				Email = "johnjones@hotmail.com",

				Senha = "ma@coeo14",

				Cep = "4950000"

			};

		}

	}

}
