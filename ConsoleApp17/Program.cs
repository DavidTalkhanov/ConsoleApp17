﻿using System;

namespace InputOneDEmentionMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод массива в столбик
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for(int i =0;i<n;i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(var item in mas)
                Console.WriteLine(item);
        }
    }
}
