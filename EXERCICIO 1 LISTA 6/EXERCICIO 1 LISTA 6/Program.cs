using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Ordenar em ordem crescente");
        Console.WriteLine("2 - ordenar em ordem decrescente");
        Console.Write("Digite a opção desejada: ");

        string opcao = Console.ReadLine();

        if (opcao == "1")
            
        {
            Console.WriteLine("Você escolheu a opção 1 (ORDENAR EM ORDEM CRESCENTE)");



            int[] vetor = new int[5] { 9, 3, 4, 1, 5 };



            int auxiliar = 0;

            for (int i = 0; i < vetor.Length - 1; i++)

            {

                if (vetor[i] > vetor[i + 1])

                {

                    auxiliar = vetor[i + 1];

                    vetor[i + 1] = vetor[i];

                    vetor[i] = auxiliar;



                    int j = i - 1;

                    while (j >= 0 && auxiliar < vetor[j])

                    {

                        auxiliar = vetor[j + 1];

                        vetor[j + 1] = vetor[j];

                        vetor[j] = auxiliar;



                        j--;




                    }





                }

            }
            for (int i = 0; i < auxiliar; i++)
            {
                Console.WriteLine($" {vetor[i]} ");


            }
        }
        else if (opcao == "2")
        {
            Console.WriteLine("Você escolheu a opção 2 (ORDENAR EM ORDEM DECRESCENTE)");
            int[] vetor = new int[5] { 9, 3, 4, 1, 5 };



            int auxiliar = vetor.Length;

            for (int i = 0; i < auxiliar - 1; i++)
            {
                for (int j = 0; j < auxiliar - i - 1; j++)
                {
                    if (vetor[j] <vetor[j + 1])
                    {
                        int auxiliar2 = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = auxiliar2;
                    }
                }
            }


            for (int i = 0; i < auxiliar; i++)
            {
                Console.WriteLine($" {vetor[i]} ");


            }




        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

        Console.ReadKey();
    }
}
