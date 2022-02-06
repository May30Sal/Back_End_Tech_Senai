// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using cadastroPessoaFS1.classes;

//cria um novo objeto (tem valores atribuídos a ele)
PessoaFisica metodoPF = new PessoaFisica();

PessoaFisica novaPF = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPF.nome = "Mayara";
novaPF.cpf = "4589875687";
novaPF.dataNascimento = "05/08/2000";
novaPF.rendimento = 1000.5f;
novaPF.endereco = novoEnd;

novoEnd.logradouro = "Rua Matos";
novoEnd.numero = 2;
novoEnd.cidade = "Campos";
novoEnd.endComercial = false;

bool dataValida = metodoPF.ValidarDataNascimento(novaPF.dataNascimento);


Console.WriteLine(novaPF.endereco.cidade);

Console.WriteLine(@$"Nome: {novaPF.nome}
Endereço: {novaPF.endereco.logradouro}, {novaPF.endereco.cidade}
Maior de idade: {dataValida}"
);


// PessoaJuridica novaPJ = new PessoaJuridica();
// novaPJ.nome = "teste 001";
// Console.WriteLine($"nome: " + (novaPJ.nome));
