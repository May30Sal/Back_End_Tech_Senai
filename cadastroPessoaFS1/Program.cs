// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using cadastroPessoaFS1.classes;

//cria um novo objeto (tem valores atribuídos a ele)
PessoaFisica metodoPF = new PessoaFisica();

PessoaFisica novaPF = new PessoaFisica();
Endereco novoEndPF = new Endereco();

novaPF.nome = "Mayara";
novaPF.cpf = "4589875687";
novaPF.dataNascimento = "05/08/2000";
novaPF.rendimento = 1000.5f;
novaPF.endereco = novoEndPF;

novoEndPF.logradouro = "Rua Matos";
novoEndPF.numero = 2;
novoEndPF.cidade = "Campos";
novoEndPF.endComercial = false;

bool dataValida = metodoPF.ValidarDataNascimento(novaPF.dataNascimento);


//Console.WriteLine(novaPF.endereco.cidade);

//Console.WriteLine(@$"Nome: {novaPF.nome}
//Endereço: {novaPF.endereco.logradouro}, {novaPF.endereco.cidade}
//Maior de idade: {dataValida}"
//);

PessoaJuridica metodopj = new PessoaJuridica();

PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();

novaPJ.nome = "teste 001";
novaPJ.cnpj = "12.345.678/0001-00";
novaPJ.razaosocial = "Razao Social PJ";
novaPJ.rendimento = 8000.5f;
novaPJ.endereco = novoEndPJ;

novoEndPJ.logradouro = "Rua teste";
novoEndPJ.numero = 3;
novoEndPJ.cidade = "Campos";
novoEndPJ.endComercial = true;

Console.WriteLine($@"{novaPJ.ToString()}
{metodopj.ValidarCnpj(novaPJ.cnpj)}");


//Console.WriteLine($"{metodopj.ValidarCnpj("00000000000100")}");
