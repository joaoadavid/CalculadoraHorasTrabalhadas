using Xunit;
using System;
using CalculadoraHorasTrabalhadas;
using

namespace CalculadoraHorasTrabalhadas.Tests
{
    public class CalculadoraHorasTests
    {
        [Fact]
        public void CalcularHorasTrabalhadas_DeveRetornarHorasCorretas()
        {
           
            // Arrange
            var calculadora = new CalculadoraHoras();
            var horaEntrada = new TimeSpan(8, 0, 0);
            var horaSaida = new TimeSpan(17, 0, 0);

            // Act
            var horasTrabalhadas = calculadora.CalcularHorasTrabalhadas(horaEntrada, horaSaida);

            // Assert
            Assert.Equal(new TimeSpan(9, 0, 0), horasTrabalhadas);
        }

        [Fact]
        public void CalcularHorasTrabalhadas_DeveLancarExcecao_SeHoraSaidaForMenorQueHoraEntrada()
        {
            // Arrange
            var calculadora = new CalculadoraHoras();
            var horaEntrada = new TimeSpan(9, 0, 0);
            var horaSaida = new TimeSpan(8, 0, 0);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculadora.CalcularHorasTrabalhadas(horaEntrada, horaSaida));
        }
    }
}
