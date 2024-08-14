using System;

namespace TrabalhoDs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um função /n");
            Console.WriteLine("1 - descubra o dia da semana:/n");
            Console.WriteLine("2 - Calculadora do Inss:/n");
            int OpcaoEscolhida = int.Parse(Console.ReadLine());

            switch (OpcaoEscolhida)
            {
                case 1:
                    Console.WriteLine("Digite a data que deseja, verificar o dia da semana:");
                    string Comando = Console.ReadLine();
                    DetalharData(Comando);

                    break;

                case 2:
                    Console.WriteLine(" digite o valor do seu salario para saber o desconto do inss:");
                    double comandotwo = double.Parse(Console.ReadLine());
                    CalculadoraInSS(comandotwo);
                    
                    break;


            }

        }

        public static void DetalharData(string DataInserida)
        {
            DateTime Data = DateTime.Parse(DataInserida);
            if (Data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"{Data.DayOfWeek} ,{Data.ToString("MMMM")},{Data.ToString("HH:mm")} ");
            }
            else
            {
                Console.WriteLine($"{Data.DayOfWeek} ,{Data.ToString("MMMM")}");
            }

        }

        public static void CalculadoraInSS(double salario)
        {
            double desconto = 0;
            if (salario <= 1212)
            {
                desconto = salario/ 100 * 7.5;

            }

            if (salario > 1212)
            {
                desconto = salario / 100 * 9;
            }

            if (salario >= 2428)
            {
                desconto = salario / 100 * 12;
            }

            if (salario >= 3641)
            {
                desconto = salario / 100 * 14;
            }

            Console.WriteLine($" seu desconto é de {desconto}");
        }

    }
}
