using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentosCSharp.Models;
namespace FundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("CocaCola",1000);
            bebida.Nombre = "Coca Cola";
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);
            
            Cerveza cerveza = new Cerveza();
            cerveza.Beberse(100);
            Console.WriteLine(cerveza.Cantidad);

            Console.ReadLine();
        }
    }
}
