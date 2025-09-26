string nome, sobrenome;
Console.Write("dgite seu nome:");
nome = Console.ReadLine()!;
Console.Write("digite seu sobrenome:");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"seunome completo: {nome} {sobrenome}");
Console.WriteLine($"seu nome catálogo: {sobrenome.ToUpper()}, {nome}");