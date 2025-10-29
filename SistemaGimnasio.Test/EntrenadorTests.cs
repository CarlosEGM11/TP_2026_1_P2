using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class EntrenadorTests
    {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            //Arrange
            Usuario usuario = new Usuario("Ana", 20, "Resistencia");
            Entrenador entrenador = new Entrenador("Luis", "Resistencia");

            //Act
            entrenador.AsignarUsuario(usuario);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
