using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Computador
    {
        /*
        Apesar de não estar explícito, essa classe herda da classe Object, assim como todas as outras classes
        e já possui alguns métodos: ToString, Equals, GetHashCode e GetType 
        */
        public override string ToString()
        {
            return "Método ToString (da classe Object) sobrescrito.";
        }
    }
}