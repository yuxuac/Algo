using System;

namespace Algo.Exercise
{
    public class TwoDimensionArray
    {
        public static int[][] GiveMeAnArrayOfArray()
        {
            var array = new int[3][];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    array[i][j] = j;
                }
            }
            return array;
        }

        public static int[,] GiveMeAn2DArray()
        {
            var array = new int[3, 2]
            {
                { 0, 1 },
                { 0, 1 },
                { 0, 1 }
            };
            return array;
        }

        public static void Test()
        {
            var array1 = TwoDimensionArray.GiveMeAn2DArray();
            

            var v1 = array1.GetLength(0);
            var v2 = array1.GetLength(1);
            var v3 = array1.Length;
            for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write(array1[i, j] + ",");
                }
                Console.WriteLine();
            }

            var array2 = TwoDimensionArray.GiveMeAnArrayOfArray();

            v1 = array2.GetLength(0);
            //v2 = array2.GetLength(1);
            v3 = array2.Length;
            for(int i = 0; i < array2.GetLength(0); i++)
            {
                for(int j = 0; j < array2[i].Length; j++)
                {
                    Console.Write(array2[i][j] + ",");
                }
                Console.WriteLine();
            }

        }
    }
}