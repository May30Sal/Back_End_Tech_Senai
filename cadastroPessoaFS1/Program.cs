using cadastroPessoaFS1.classes;

Console.WriteLine(@$"
---------------------------------------------
|   Bem vindo ao sistema de cadastro de     |
|       Pessoas Físicas e Jurídicas         |
---------------------------------------------
");

Console.Write("Carregando ");
Console.BackgroundColor = ConsoleColor.White;

for (var i = 0; i < 10; i++)
{
    Console.Write(". ");
    Thread.Sleep(500);
}

Console.ResetColor();

string? opcao;

do 
{
    Console.Clear();
    Console.WriteLine(@$"
---------------------------------------------
|       Escolha uma das opções abaixo:      |
|-------------------------------------------|
|       1 - Pessoa Física                   |
|       2 - Pessoa Jurídica                 |
|                                           |
|       0 - Sair do Sistema                 |
---------------------------------------------
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
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

            Console.Clear();
            Console.WriteLine(@$"Nome: {novaPF.nome}
Endereço: {novaPF.endereco.logradouro}, {novaPF.endereco.cidade}
Maior de idade: {(dataValida ? "sim" : "não")}
Taxa de imposto a ser paga: {metodoPF.PagarImposto(novaPF.rendimento).ToString("C")}"
);
            Console.WriteLine(@"
Aperte 'Enter' para continuar!");
            Console.ReadLine();
            break;
        case "2":
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

            Console.Clear();
            Console.WriteLine($@"{novaPJ.ToString()}
{novaPJ.endereco.ToString()}
CNPJ Válido: {(metodopj.ValidarCnpj(novaPJ.cnpj) ? "sim" : "não")}
Taxa de imposto a ser paga: {metodopj.PagarImposto(novaPJ.rendimento).ToString("C")}");
            Console.WriteLine(@"
Aperte 'Enter' para continuar!");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine("Obrigada por utilizar nosso sistema!");
            Thread.Sleep(2000);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida. Digite outra opção");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0");




