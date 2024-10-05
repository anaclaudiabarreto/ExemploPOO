using ExemploPOO.Models;

Pessoa pessoa = new Pessoa("Leonardo"); //Abstração = Aqui estou criando um objeto (pessoa), que é a concretização da classe Pessoa
pessoa.Idade = 20;
pessoa.Apresentar();

ContaCorrente cc = new ContaCorrente(123, 1000);
/*
Encapsulamento = Se eu tentar acessar o atributo 'saldo' não vou conseguir, pelo nível de proteção utilizado 'private'
Conseguimos alterá-lo utilizando o método 'Sacar'
*/
cc.Sacar(120);

//Herança = reutilização de atributos, métodos e comportamentos de uma classe em outras classes
Aluno aluno = new Aluno("Joaquim"); //a classe 'Aluno' não possui o atributo 'Nome', mas herda da classe 'Pessoa', que o possui.
aluno.Idade = 10;
aluno.Nota = 8.5;
aluno.Apresentar();

Professor prof = new Professor("Amália", null, 5500, "Direito Administrativo");
prof.Apresentar();

//Classe Abstrata
Corrente corr = new Corrente(); //a classe 'Corrente' herda da classe 'Conta', que é abstrata
corr.Creditar(10);
corr.ExibirSaldo();

//Métodos selados
Diretor diretor = new Diretor("Antônio", 65, 12000, "");
diretor.Apresentar();

//Classe Object
Computador pc = new Computador();
Console.WriteLine(pc.ToString());

//Interfaces
CalculadoraComum calc = new CalculadoraComum();
Console.WriteLine(calc.Multiplicar(3, 7));