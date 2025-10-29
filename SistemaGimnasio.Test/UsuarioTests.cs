using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class UsuarioTests
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arragne
            Usuario usuario = new Usuario("Juan", 15, "Fuerza");
            Rutina rutina = new Rutina("Rutina#1", 90);

            //Act
            usuario.AsignarRutina(rutina);

            //Assert
            Assert.Equal("Rutina#1", usuario.RutinaAsignada.Nombre);
        }
    }
}