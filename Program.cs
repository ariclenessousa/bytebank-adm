using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Console.WriteLine("----------Boas vindas ao ByteBank Administracao----------");
Console.WriteLine("*********************************************************");


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "22345679";
pedro.Salario = 13000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salario: " + pedro.Salario);
Console.WriteLine("Bonificacao: " + pedro.getBonificacao());

Console.WriteLine("---------------------------------------------------------");

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "843354353";
paula.Salario = 18000;

Console.WriteLine("Nome: " + paula.Nome);
Console.WriteLine("CPF: " + paula.Cpf);
Console.WriteLine("Salario: " + paula.Salario);
Console.WriteLine("Bonificacao: " + paula.getBonificacao());
Console.WriteLine("--------------------------------------------------------");

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);
Console.WriteLine("Total de bonificacao: " + gerenciador.getBonificacao());

Console.ReadKey();