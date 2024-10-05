using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        /* Encapsulamento = o atributo 'saldo' está protegido e só é acessado pela própria classe. 
        É possível fazer alteração no seu valor utilizando o método 'Sacar' */
        private decimal saldo { get; set; }
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
                
            else
            {
                Console.WriteLine("Você não possui saldo suficiente. Tente um valor menor.");
            }   
            //Aqui fiz uma implementação, que não foi prevista no treinamento, visando melhor usabilidade:
            Console.WriteLine("Digite S para visualizar o saldo.");
            string valorDigitadoUsuario = Console.ReadLine();
            if (valorDigitadoUsuario.ToUpper() == "S")
                {
                    ExibirSaldo();
                }              
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é de {saldo:C}.");
        }
    }
}