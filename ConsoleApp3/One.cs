using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class One
    {
        private int array_size;
        private bool user_fill = false;

        public One(int cnt, bool t)
        {
            array_size= cnt;
            user_fill = t;
            Fill();
        }
        private int[] array;

        private void FillByUser(int m)
        {
            Console.WriteLine("Введите элементы массива:");
            array= new int[m];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void RndmFill(int m)
        {
            array = new int[m];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100000);
            }
        }

        private void Fill()
        {
            if (!user_fill)
            {
                RndmFill(array_size);
            }
            else
            {
                FillByUser(array_size);
            }
        }

        private void array_output(int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
        }

        public void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / array.Length);
        }

        public void more_hundred()
        {
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    cnt++;
                }
            }
            int[] changed_array= new int[cnt];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    changed_array[j] = array[i];
                    j++;
                }
            }
            Console.Write("Массив после удаления всех элементов, больших 100 по модулю: ");
            array_output(changed_array);
        }

        public void no_repeat_elements()
        {
            int cnt = 1;
            for (int i = 1; i < array.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        have = true;
                    }
                }
                if (!have)
                {
                    cnt++;
                }
            }
            int[] changed_array = new int[cnt];
            int k = 1;
            changed_array[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        have = true;
                    }
                }
                if (!have)
                {
                    changed_array[k] = array[i];
                    k++;
                }
            }
            Console.Write("Массив, если удалить все дубликаты элементов: ");
            array_output(changed_array);
        }


    }
}
