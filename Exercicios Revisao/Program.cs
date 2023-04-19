// Exercicio 1

int quantidade;
float precoUnico;
float precoTotal;
Console.Write("Quantidade de itens: ");
quantidade = int.Parse(Console.ReadLine());
Console.Write("Preço unitário: ");
precoUnico = float.Parse(Console.ReadLine());
precoTotal = quantidade * precoUnico;
Console.WriteLine("Preço total: " + precoTotal + ",00");
