using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        //Abstração = A classe é apenas um molde/uma representação do que o meu sistema considera que uma pessoa seja
        public string Nome { get; set; }
        public int? Idade { get; set; } //Coloquei como nullable porque não é de preenchimento obrigatório
        public virtual void Apresentar()
        //A palavra 'virtual' sinaliza que esse é um método que pode ser sobrescrito
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}