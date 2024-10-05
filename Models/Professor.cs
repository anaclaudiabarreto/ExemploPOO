using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    /*
    Herança = reutilização de atributos, métodos e comportamentos de uma classe em outras classes
    A classe 'Professor' herda da classe 'Pessoa'    
    */
    public class Professor : Pessoa     
    {
        public Professor(string nome, int? idade, double salario, string disciplina)  : base(nome)
        //construtor por herança. o nome que recebemos aqui passamos para a classe pai
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            Disciplina = disciplina;
        }
        public double Salario { get; set; }
        public string Disciplina { get; set; } //Coloquei essa prop a mais para deixar a classe mais completa

        public sealed override void Apresentar()
        // Polimorfismo = devido a palavra 'override' o método sobrescreverá o outro que existe na classe herdada
        {
            //Aqui aproveitei para utilizar outros conceitos já estudados, como if ternário
            string informacaoIdade = Idade.HasValue ? $"tenho {Idade} anos" : "prefiro não informar minha idade";
            string informacaoDisciplina = Disciplina != "" ? $" leciono a matéria {Disciplina} " : ""; //diretor  
            Console.WriteLine($"Olá! Meu nome é {Nome}, {informacaoIdade}, {informacaoDisciplina}e meu salário é {Salario:C}.");
        }
    }
}