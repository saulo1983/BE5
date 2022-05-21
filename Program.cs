// See https://aka.ms/new-console-template for more information


using BE5.Classes;
/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();
*/
// novaPf.ValidarDataNascimento(new DateTime(2000,01,01));
// novaPf.ValidarDataNascimento("01,01,2000");
/*
novaPf.nome = "Luiz";
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678901";
novaPf. rendimento = 500.0f;
novoEnd.logradouro = "Alameda Barao de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai de Informatica";
novoEnd.endComercial = true;
novaPf.endereco = novoEnd;

/*
Console.WriteLine($"{novaPf.nome}");
Console.WriteLine($"{novaPf.dataNascimento}");
Console.WriteLine($"{novaPf.cpf}");
Console.WriteLine($"{novaPf.rendimento}");
Console.WriteLine($"{novaPf.endereco.logradouro}");
Console.WriteLine($"{novaPf.endereco.numero}");
Console.WriteLine($"{novaPf.endereco.complemento}");
Console.WriteLine($"{novaPf.endereco.endComercial}");
*/
/*
Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {novaPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
*/

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome PJ";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razao = "Razao Social PJ";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Alameda Barão de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informática";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");
Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razao}
CNPJ: {novaPj.cnpj}
CNPJ válido? {metodoPj.ValidarCnpj(novaPj.cnpj)}
");