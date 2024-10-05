using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //Classe abstrata = não pode ser instanciada. Serve apenas como modelo para ser herdada
    public abstract class Conta
    {
        protected decimal saldo; //protected protege das alterações externas, exceto das classes filhas        
        public abstract void Creditar(decimal valor); //método abstrato não possui implementação        
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é de {saldo:C}.");
        }
         
    }
}