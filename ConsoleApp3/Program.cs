using System;
using System.Collections.Generic;

namespace ConsoleApp3
{

    public class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите как нужно заполнить массив (0 - рандомными числами, 1 - с клавиатуры пользователем):");
            int t = int.Parse(Console.ReadLine());
            bool f = t == 1 ? true : false;
            One one = new One(n, f);
            one.mid_value();
            one.more_hundred();
            one.no_repeat_elements();

            Console.WriteLine("Введите количество строк и столбцов в двумерном массиве");
            int n1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите как нужно заполнить двумерный массив (0 - рандомными числами, 1 - с клавиатуры пользователем):");
            int v = int.Parse(Console.ReadLine());
            bool r = v == 1 ? true : false;
            Two two = new Two(n1, m1, r);
            two.mid_value();
            two.array_output_normal();
            two.array_output_reversed();


            Console.WriteLine("Введите количество строк в ступенчатом массиве:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите как нужно заполнить ступенчатый массив (0 - рандомными числами, 1 - с клавиатуры пользователем):");
            int p = int.Parse(Console.ReadLine());
            bool g = p == 1 ? true : false;
            Stepped step = new Stepped(n2, g);
            step.all_mid_value();
            step.inside_mid_value();
            step.change_odd();







        }
    }


}