using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Two
    {
        private int n, m;
        private int[,] array;
        private bool user_fill = false;

        public Two(int k, int l, bool t)
        {
            n = k;
            m = l;
            user_fill = t;
            Fill();
        }

        private void FillByUser(int k, int l)
        {
            Console.WriteLine("Введите элементы массива:");
            array = new int[k, l];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void RndmFill(int k, int l)
        {
            array= new int[k, l];
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    array[i, j] = rnd.Next(100000);
                }

            }
        }

        private void Fill()
        {
            if (!user_fill)
            {
                RndmFill(n, m);
            }
            else
            {
                FillByUser(n, m);
            }
        }

        public void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / (n * m));
        }

        public void array_output_normal()
        {
            Console.WriteLine("Вывод изначального массива: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void array_output_reversed()
        {
            Console.WriteLine("Массив после замены всех чётных элементов на произведених их индексов:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

