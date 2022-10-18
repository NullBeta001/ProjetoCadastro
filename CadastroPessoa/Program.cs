using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.nome = "Fabio";
novaPf.cpf = "467.847.478-10";
novaPf.rendimento = 6600.5f;
novaPf.dataNasc = new DateTime(1997, 12, 22);

novoEndPf.logradouro = "Rua Sebastião Damacena";
novoEndPf.numero = "242";
novoEndPf.complemento = "Casa";
novoEndPf.endComercial = "False";

novaPf.endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");


// Console.WriteLine(novaPf.cpf);

// Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");


// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
// Console.WriteLine(impostoPagar.ToString("C2"));

// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine (novaPj.CalcularImposto(6600.5f));

DateTime temp = new DateTime(2004, 10, 20);
Console.WriteLine(novaPf.ValidarDataNasc("02/01/2000"));


// == igualdade
// > maior que
// < menor que
// >= maior ou igual
// <= menor ou igual
// != diferente

// && 'e' - todas as comparacoes sao iguais
// V && V = V
// F && V = F
// V && F = F
// F && F = F

// || 'ou' - comparacao onde valida uma
// V || V = V
// F || V = V
// V || F = V
// F || F = V