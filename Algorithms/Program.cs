
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Algorithms
{



    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            // arr =[{1,2,3},{4,5,6},{7,8,9}]

            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;

            for (int i = 0; i <= arr.Count; i++)
            {

                for (int j = 0; j <= arr.Count - 1; j++)
                {
                    if (i == j)
                    {
                        sumLeftDiagonal += arr[i][j];
                    }


                    // for(int k=0; k<arr.Count; k++)
                    // {

                    // }
                }



            }

            // get  the right diagonal summation 
            int loopCounter = arr.Count;
            for (int i = 0; i < arr.Count; i++)
            {

                for (int j = arr.Count; j >= 1; j--)
                {

                    if (j == loopCounter)
                    {
                        Console.WriteLine(arr[i][j - 1]);
                        sumRightDiagonal = sumRightDiagonal + arr[i][j - 1];

                    }


                    // for(int k=0; k<arr.Count; k++)
                    // {

                    // }
                }
                loopCounter--;



            }
            // return  Math.Abs(sumLeftDiagonal - sumRightDiagonal);
            return Math.Abs(sumLeftDiagonal - sumRightDiagonal);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}