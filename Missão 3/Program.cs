// Missão 3

int[,] tabela = new int[3,3];

for (int i = 0; i<tabela.GetLength(0); i++)
{
    for (int j = 0; j < tabela.GetLength(1); j++)
    {
        Console.Write($"Digite quantos pratos foram vendidos: ");
        tabela[i,j] = int.Parse(Console.ReadLine());
    } 
}
Console.WriteLine();
Console.WriteLine("          Prato 1   Prato 2   Prato 3   Prato 4");
for (int i = 0; i < tabela.GetLength(0); i++)
{
    if (i == 0) { Console.Write("Segunda: "); }
    if (i == 1) { Console.Write("Terça:   "); }
    if (i == 2) { Console.Write("Quarta:  "); }
    if (i == 3) { Console.Write("Quinta:  "); }
    if (i == 4) { Console.Write("Sexta:   "); }
    if (i == 5) { Console.Write("Sábado:  "); }
    if (i == 6) { Console.Write("Domingo: "); }

    for (int j = 0; j < tabela.GetLength(1); j++)
        
    {
        Console.Write($"     {tabela[i,j]}    ");
    }
    Console.WriteLine();
}

//A seguir, tentei fazer a lógica para armazenar o índice com o nº maior de pratos vendidos,
// porém, não deu certo e não consegui consertar a tempo:



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Prato mais popular em cada dia da semana:");
Console.WriteLine();
for (int i = 0; i < tabela.GetLength(0); i++)
{
    int pratoPopular = int.MinValue;
    for (int j = 0; j < tabela.GetLength(1); j++)
    {
        if (tabela[i, j] > pratoPopular) 
        {
            pratoPopular = j;
        }

        if (j == 0) { Console.WriteLine("Segunda: Prato " + pratoPopular); }
        if (j == 1) { Console.WriteLine("Terça:   Prato " + pratoPopular); }
        if (j == 2) { Console.WriteLine("Quarta:  Prato " + pratoPopular); }
        if (j == 3) { Console.WriteLine("Quinta:  Prato " + pratoPopular); }
        if (j == 4) { Console.WriteLine("Sexta:   Prato " + pratoPopular); }
        if (j == 5) { Console.WriteLine("Sábado:  Prato " + pratoPopular); }
        if (j == 6) { Console.WriteLine("Domingo: Prato " + pratoPopular); }

        
    }
}


