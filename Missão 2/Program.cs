// Missão 2

using System;
class Program
{
    static void Main(string[] args)
    {
        string[] vetorDeStrings = new string[5];
        int tamanhoMaiorString = 0;
        int tamanhoMenorString = int.MaxValue; //aqui estava MinValue
        string maiorString = "";
        string menorString = "";
        Console.WriteLine("Digite as 5 strings:");
        for (int i = 0; i < vetorDeStrings.Length; i++) { //no lugar de for estava "foreach" e no tamanho do vetor estava diminuindo 2 posições
            Console.Write($"String {i + 1}: ");
            vetorDeStrings[i] = Console.ReadLine();
            if (vetorDeStrings[i].Length > tamanhoMaiorString)
            {
                tamanhoMaiorString = vetorDeStrings[i].Length;
                maiorString = vetorDeStrings[i];
            }
            if (vetorDeStrings[i].Length < tamanhoMenorString) //no lugar de < estava ?
            {
                tamanhoMenorString = vetorDeStrings[i].Length;
                menorString = vetorDeStrings[i];
            }
        }
        Console.WriteLine($"Maior string: {maiorString}, com {tamanhoMaiorString} caracteres"); //faltou o ;
       
        Console.WriteLine($"Menor string: {menorString}, com {tamanhoMenorString} caracteres"); // faltou o ;
    }
}
