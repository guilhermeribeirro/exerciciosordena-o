using System;



class Program
{
static void Main (string[] args)
    {
        string[] palavras = { "Cachorro", "Gato", "Elefante", "Girafa", "Porco" };

        Array.Sort(palavras);

        Console.WriteLine("LISTA DE PALAVRAS CLASSIFICADAS EM ORDEM ALFABÉTICA:");

        foreach (string palavra in palavras)
        {
            Console.WriteLine(palavra);
        }
        Array.Reverse(palavras);

        Console.WriteLine("LISTA DE PALAVRAS EM ORDEM ALFABÉTICA DECRESCENTE:");

        foreach (string palavra in palavras)
        {
            Console.WriteLine(palavra);

        }

    }


}