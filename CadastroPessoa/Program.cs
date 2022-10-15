using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Fabio";
novaPf.cpf = "467.847.478-10";
novaPf.rendimento = 6600.5f;

// Console.WriteLine(novaPf.cpf);

// Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");


float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(impostoPagar.ToString("C2"));

PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine (novaPj.CalcularImposto(6600.5f));

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