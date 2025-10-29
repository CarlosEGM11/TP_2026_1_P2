using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public class RutinaTests
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista()
        {
            //Arrange
            Rutina rutina = new Rutina("Basica", 60);
            Ejercicio ejercicio = new Ejercicio("Sentadillas", 15, 3, 60);
            Ejercicio ejercicio2 = new Ejercicio("Lagartija", 10, 5, 30);

            //Act
            rutina.AgregarEjercicio(ejercicio);
            rutina.AgregarEjercicio(ejercicio2);

            //Assert
            Assert.NotEmpty(rutina.ObtenerEjercicios());
        }
    }
}
