using CadastroPessoa.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Fabio";
novaPf.cpf = "467.847.478-10";

Console.WriteLine(novaPf.cpf);

Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");