using System;
using System.Collections.Generic;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Какой длины будет массив? ");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine();
                Console.Write("Введите новый элемент массива: ");
                list.Add(Int32.Parse(Console.ReadLine()));
            }

            float summ = 0;
            foreach (int VARIABLE in list)
            {
                summ += VARIABLE;
            }
            float mdl = summ / N;

            int iDelta = 0;
            int iMelta = 0;
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(mdl - list[i]) < Math.Abs(mdl - list[i - 1]))
                    iDelta = i;
                if (Math.Abs(mdl - list[i]) > Math.Abs(mdl - list[i - 1]))
                    iMelta = i;
            }

            Console.WriteLine();
            Console.WriteLine($"среднее = {mdl}; номер самого близкого = [{iDelta+1}]; номер самого дальнего = [{iMelta + 1}]");
            Console.ReadKey();
        }
    }
}
