using System;

namespace CalculadoraHorasTrabalhadas
{
    public class Program
    {
        public static string CalcularHorasPorEntradaSaida(
            string entrada, string inicioIntervalo, string fimIntervalo, string saida)
        {
            try
            {
                TimeSpan horaEntrada = TimeSpan.Parse(entrada);
                TimeSpan inicioInt = TimeSpan.Parse(inicioIntervalo);
                TimeSpan fimInt = TimeSpan.Parse(fimIntervalo);
                TimeSpan horaSaida = TimeSpan.Parse(saida);

                CalculadoraHoras calculadora = new CalculadoraHoras();
                TimeSpan horasTrabalhadas = calculadora.CalcularHorasTrabalhadas(horaEntrada, horaSaida, inicioInt, fimInt);

                return $"Horas trabalhadas: {horasTrabalhadas.TotalHours} horas";
            }
            catch (ArgumentException ex)
            {
                return ex.Message;
            }
            catch (FormatException ex)
            {
                return $"Erro de formato: {ex.Message}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora de entrada (formato HH:mm): ");
            string entrada = Console.ReadLine();

            Console.WriteLine("Informe o início do intervalo (formato HH:mm): ");
            string inicioIntervalo = Console.ReadLine();

            Console.WriteLine("Informe o fim do intervalo (formato HH:mm): ");
            string fimIntervalo = Console.ReadLine();

            Console.WriteLine("Informe a hora de saída (formato HH:mm): ");
            string saida = Console.ReadLine();

            string resultado = CalcularHorasPorEntradaSaida(entrada, inicioIntervalo, fimIntervalo, saida);
            Console.WriteLine(resultado);
        }
    }
}
