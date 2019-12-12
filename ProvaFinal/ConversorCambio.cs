using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ProvaFinal
{
    class ConversorCambio
    {
        static object Main(string[] args)
        {

            double precoReal = 0;
            double taxa = 4.250;
            double conversao = 0;

            Console.Write("Entre com o preço em Real: ");
            precoReal = double.Parse(Console.ReadLine());

            conversao = precoReal / taxa;

            Console.Write("Preço convertido em dolar ! $" + conversao + "Dolares");
            Console.ReadKey();
        }


    }
}
