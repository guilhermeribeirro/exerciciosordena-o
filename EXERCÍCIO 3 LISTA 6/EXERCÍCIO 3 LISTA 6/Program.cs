using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arrayInteiro = { 9, 4, 8, 6, 2, 5 };

        
        BubbleSort(arrayInteiro);

        Console.WriteLine("Inteiros em ordem crescente:");
        foreach (int Numero in arrayInteiro)
        {
            Console.WriteLine(Numero);
        }

        
        BubbleSortReverse(arrayInteiro);

        Console.WriteLine("Inteiros em ordem decrescente:");
        foreach (int Numero in arrayInteiro)
        {
            Console.WriteLine(Numero);
        }
    }

    static void BubbleSort(int[] arrayInteiro)
    {
        int numero = arrayInteiro.Length;
        for (int i = 0; i < numero - 1; i++)
        {
            for (int j = 0; j < numero - i - 1; j++)
            {
                if (arrayInteiro[j] > arrayInteiro[j + 1])
                {
                    
                    int temp = arrayInteiro[j];
                    arrayInteiro[j] = arrayInteiro[j + 1];
                    arrayInteiro[j + 1] = temp;
                }
            }
        }
    }

    static void BubbleSortReverse(int[] arrayInteiro)
    {
        int numero = arrayInteiro.Length;
        for (int i = 0; i < numero - 1; i++)
        {
            for (int j = 0; j < numero - i - 1; j++)
            {
                if (arrayInteiro[j] < arrayInteiro[j + 1])
                {
                    
                    int temp = arrayInteiro[j];
                    arrayInteiro[j] = arrayInteiro[j + 1];
                    arrayInteiro[j + 1] = temp;
                }
            }
        }
    }
}
