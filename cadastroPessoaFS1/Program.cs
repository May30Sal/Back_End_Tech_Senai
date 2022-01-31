// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using cadastroPessoaFS1.classes;

//cria um novo objeto (tem valores atribuídos a ele)
PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "teste000";
Console.WriteLine(novaPF.nome);

PessoaJuridica novaPJ = new PessoaJuridica();
novaPJ.nome = "teste 001";
Console.WriteLine($"nome: " + (novaPJ.nome));


