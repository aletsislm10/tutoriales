using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp.Models
{
    public class Cerveza : Bebida
    {
        /*public Cerveza() :base("cerveza",1000){ }*/

        //cuando se haga una cerveza se va a pedir obligado la cantidad y el nombre opcional
        public Cerveza (int Cantidad, string Nombre = "Cerveza") : base (Nombre,Cantidad) { }
    }
}
