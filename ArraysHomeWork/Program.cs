using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.3
            /* int[] array1 = { 1, 2, 3, 4, 5 };
             int[] temp = new int[5];
             int index = 0;

             for (int i = array1.Length - 1; i >= 0; i--)
             {
                 temp[index] = array1[i];
                 index++;
             }

             for (int i = 0; i < temp.Length; i++)
             {
                 Console.WriteLine(temp[i]);
             }*/

            //7.4
            /*int countOfStudents = int.Parse(Console.ReadLine());
            Random rand = new Random();

            byte[] hight = new byte[countOfStudents];
            int all = 0;

            for (int i = 0; i < hight.Length; i++)
            {
                hight[i] = (byte)rand.Next(155, 200);
                all += hight[i];
            }
            Console.WriteLine((double)all/countOfStudents);*/

            //7.6
            /*int stroki = int.Parse(Console.ReadLine());
            int stolbzy = int.Parse(Console.ReadLine());

            int[,] arrayMatrix = new int[stroki, stolbzy];
            int number = 0;

            for (int i = 0; i < arrayMatrix.GetLength(1); i++)
            {
                number += i;
            }
            for (int i = 0; i < arrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMatrix.GetLength(1); j++)
                {
                    arrayMatrix[i, j] = number;
                    Console.Write(arrayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }*/

           /* //7.9

            int[] array = { 0, 1, 2, 10, 4, 5 };
            int max = array[0];
            int min = array[0];
            int numberMin = 0;
            int numberMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    numberMax = i;
                }
                if (min > array[i])
                {
                    min = array[i];
                    numberMin = i;
                }
            }
            Console.WriteLine($"Max = {max} = {numberMax}; Min = {min} = {numberMin}");*/


            //7.11

            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i,j] = 1;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();

            }

        }
    }
}
