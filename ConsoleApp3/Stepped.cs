using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class Stepped
    {
        private int array_size;
        private int[][] array;
        private bool user_fill = false;
        public Stepped(int k, bool t)
        {
            array_size= k;
            user_fill = t;
            Fill();
        }

        private void Fill()
        {
            if (user_fill)
            {
                FillByUser(array_size);
            }
            else
            {
                RndmFill(array_size);
            }
        }



        public void recreate(int n)
        {
            if (user_fill)
            {
                FillByUser(n);
            }
            else
            {
                RndmFill(n);
            }
        }

        private void RndmFill(int n)
        {
            array= new int[n][];
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int current_array_size = int.Parse(Console.ReadLine());
                array[i] = new int[current_array_size];
                Random rnd = new Random();
                for (int j = 0; j < current_array_size; j++)
                {
                    array[i][j] = rnd.Next(10000);
                }
            }
        }

        private void FillByUser(int n)
        {
            array = new int[n][];
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int current_array_size = int.Parse(Console.ReadLine());
                array[i] = new int[current_array_size];
                Console.WriteLine("Введите элементы строки массива:");
                for (int j = 0; j < current_array_size; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void all_mid_value()
        {
            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < array_size; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    cnt++;
                }
            }
            Console.WriteLine("Среднее значение во всём массиве: " + sum / cnt);
        }

        public void inside_mid_value()
        {
            for (int i = 0; i < array_size; i++)
            {
                double sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                Console.WriteLine("Среднее значение в строке " + (i + 1) + ": " + sum / array[i].Length);
            }
        }

        private void step_array_output(int[][] outputted_array)
        {
            for (int i = 0; i < outputted_array.Length; i++)
            {
                for (int j = 0; j < outputted_array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void change_odd()
        {
            for (int i = 0; i < array_size; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("Массив после изменения:");
            step_array_output(array);
        }

    }
}

