using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome, int? idade, double salario, string disciplina) : base(nome, idade, salario, disciplina)
        {
        }

        /*
        o método 'Apresentar' precisou ser inutilizado porque o 'Apresentar' da classe 'Professor' está como selado 
        e não permite ser sobrescrito pelas classes filhas 
        */
        /*
        public override void Apresentar()
        // Polimorfismo = devido a palavra 'override' o método sobrescreverá o outro que existe na classe herdada
        {            
            string informacaoIdade = Idade.HasValue ? $"tenho {Idade} anos" : "prefiro não informar minha idade";            
            Console.WriteLine($"Olá! Meu nome é {Nome}, {informacaoIdade}, sou o diretor da instituição e meu salário é {Salario:C}.");
        }
        */        
    }
}