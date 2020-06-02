using System;

namespace AULA08ABSTRACAO
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

            System.Console.WriteLine("Deseja aumentar seu limite em quanto?");
            float acres = float.Parse( Console.ReadLine() );

            visa.AumentarLimite(acres);
            Console.WriteLine("Novo limite: R$ "+visa.limite);
        }
    }
}
