using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    /*
    Interface é criada como um contrato que é assinado por uma classe.
    Uma classe pode implementar mais de uma interface.
    */
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}