using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();

// novaPf.nome = "Fabio";
// novaPf.cpf = "467.847.478-10";

// Console.WriteLine(novaPf.cpf);

// Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");

float imposotoPagar = novaPf.CalcularImposto(12000);
Console.WriteLine(imposotoPagar + 1000);

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