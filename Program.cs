// See https://aka.ms/new-console-template for more informati
using BE5.Classes;

Console.WriteLine(@$"

============================================================
|       Bem vindo ao sistema de cadastro de                |
|           Pessoas Físicas e Jurídicas                    |
|----------------------------------------------------------|
");

BarraCarregamento("Carregando", 500);
string? opcao;
do
{
Console.Clear();

Console.WriteLine(@$"

============================================================
|           Escolha uma das opções abaixo                  |
|----------------------------------------------------------|
|                    1 - Pessoa Física                     |
|                    2 - Pessoa Jurídica                   |
|                    0 - Sair                              |
============================================================
");

    opcao = Console.ReadLine();

switch(opcao)
{
    case "0":
        Console.Clear();
        Console.WriteLine($"Obrigado por utilizar nosso sistema!!!");
        BarraCarregamento("Finalizando ", 400);
        break;
    case "1":
        PessoaFisica novaPf = new PessoaFisica();
        Endereco novoEnd = new Endereco();
        PessoaFisica metodoPf = new PessoaFisica();
        novaPf.nome = "Luiz";
        novaPf.dataNascimento = "01/01/2000";
        novaPf.cpf = "12345678901";
        novaPf. rendimento = 1600.0f;
        novoEnd.logradouro = "Alameda Barao de Limeira";
        novoEnd.numero = 539;
        novoEnd.complemento = "Senai de Informatica";
        novoEnd.endComercial = true;
        novaPf.endereco = novoEnd;
        Console.Clear();
        Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Nome: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
            Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            ");
            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
        break;
    case "2":
        PessoaJuridica metodoPj = new PessoaJuridica();
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();
        novaPj.nome = "Nome PJ";
        novaPj.cnpj = "00.000.000/0001-00";
        novaPj.razaoSocial = "Razao Social Pj";
        novaPj.rendimento = 8000.5f;
        novoEndPj.logradouro = "Alameda Barão de Limeira";
        novoEndPj.numero = 539;
        novoEndPj.complemento = "Senai Informática";
        novoEndPj.endComercial = true;
        novaPj.endereco = novoEndPj;
        Console.Clear();
        Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            CNPJ Valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
            Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
             ");
            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
        break;
    
    default:
        Console.Clear();
        Console.WriteLine($"Opção inválida, por favor digite outra opção.");
        Thread.Sleep(2000);
        break;
}
} while(opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write($"{texto} ");

    for (var contador = 0; contador < 10; contador ++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}

