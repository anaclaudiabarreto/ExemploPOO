using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    /*
    Herança = reutilização de atributos, métodos e comportamentos de uma classe em outras classes
    A classe 'Aluno' herda da classe 'Pessoa';
    e nenhuma classe pode herdar da classe 'Aluno' porque ela é selada
    */
    public sealed class Aluno : Pessoa //A classe 'Aluno' herda da classe 'Pessoa'
    {
        public Aluno(string nome) : base(nome)
        //construtor por herança. o nome que recebemos aqui passamos para a classe pai
        { }

        public double Nota { get; set; }

        public override void Apresentar()
        // Polimorfismo = devido a palavra 'override' o método sobrescreverá o outro que existe na classe herdada
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}