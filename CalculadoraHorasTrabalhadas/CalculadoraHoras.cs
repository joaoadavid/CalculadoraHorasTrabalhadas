namespace CalculadoraHorasTrabalhadas
{
    public class CalculadoraHoras
    {
        public TimeSpan CalcularHorasTrabalhadas(
            TimeSpan horaEntrada, TimeSpan horaSaida,
            TimeSpan inicioIntervalo, TimeSpan fimIntervalo)
        {
            if (horaSaida < horaEntrada)
            {
                throw new ArgumentException("Hora de saída não pode ser menor que a hora de entrada.");
            }

            if (fimIntervalo < inicioIntervalo)
            {
                throw new ArgumentException("Hora de fim do intervalo não pode ser menor que o início do intervalo.");
            }

            // Calcula horas trabalhadas sem intervalo
            TimeSpan horasTrabalhadas = horaSaida - horaEntrada;

            // Subtrai o tempo de intervalo
            TimeSpan duracaoIntervalo = fimIntervalo - inicioIntervalo;
            return horasTrabalhadas - duracaoIntervalo;
        }
    }
}
