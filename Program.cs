using System;
class Program
{   //Задана матрица размером NxM.Определить количество "ососбых" элементов матрицы,считая элемент особым , если в строке слева элементы меньше,а справа больше.
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, n = 0, sum1 = 0, sum2 = 0;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 10);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
        bool lol = true;
        for (int j = 0; j < N; j++)
        {
            for (int i = 1; i < M - 1; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    if (lol && array[j, k] < array[j, i]) lol = true;
                    else lol = false;
                }
                for (int k = i + 1; k < M; k++)
                {
                    if (lol && array[j, i] < array[j, k]) lol = true;
                    else lol = false;
                }
                if (lol)
                {
                    n++;
                    Console.WriteLine(array[j, i]);
                }
            }
            lol = true;
        }
        Console.WriteLine("Kolvo os el: " + n);
    }
}
