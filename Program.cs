using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();

            System.Console.WriteLine("Digite a data do pagamento");
            visa.data = DateTime.Parse( Console.ReadLine() );
            System.Console.WriteLine("Data digitada: "+visa.data);
            
            System.Console.WriteLine();

            Console.WriteLine("Digite o valor para pagar:");
            Console.ReadLine();
            System.Console.WriteLine(visa.Pagar());

            System.Console.WriteLine();

            System.Console.WriteLine("Digite o acrescimo de limite:");
            visa.acrescimo = float.Parse( Console.ReadLine ());
            System.Console.WriteLine("Seu novo limite: ");
            Console.WriteLine(visa.AumentarLimite(5000, visa.acrescimo));

            
        }
    }
}
