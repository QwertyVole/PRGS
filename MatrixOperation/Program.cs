using System;

namespace MatrixOperation
{
    class Program
    {
        static int[,] MatrixFill(int a, int b)
        {
            //creates a matrix which's size is dictated by the input, and fills it with ascending integers from 0 to a * b -1
            int[,] Matrix = new int[a, b];
            int filler = 0;
            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Matrix[j, i] = filler;
                    filler++;
                }
            }
            return Matrix;
        }
        static int[,] MatrixRandomFill(int a, int b)
        {
            //creates a matrix which's size is dictated by the input, and fills it with random integers from 0 to a * b -1
            int[,] Matrix = new int[a, b];
            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Random rnd = new Random();
                    Matrix[j, i] = rnd.Next(-a * b, a * b - 1);
                }
            }
            return Matrix;
        }
        static string MatrixPrint(int[,] Matrix)
        {
            // Prints out the Matrix 
            string output = "";
            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    if (Matrix[j, i] < 10)
                        output += $"{Matrix[j, i]}  ";
                    else
                        output += $"{Matrix[j, i]} ";
                }
                output += "\n";
            }
            Console.Write(output);
        }

        static int[,] MatrixElementSwap(int[,] Matrix, int x1, int y1, int x2, int y2)
        {
            int cache = Matrix[x1, y1];
            Matrix[x1, y1] = Matrix[x2, y2];
            Matrix[x2, y2] = cache;

            return Matrix;
        }
        static int[,] MatrixCollumSwap(int[,] Matrix, int first, int second)
        {
            int cache;
            for (int i = 0; i < Matrix.GetLength(1) - 1; ++i)
            {
                cache = Matrix[first, i];
                Matrix[first, i] = Matrix[second, i];
                Matrix[second, i] = cache;
            }
            return Matrix;
        }
        static int[,] MatrixLineSwap(int[,] Matrix, int first, int second)
        {
            int cache;
            for (int i = 0; i < Matrix.GetLength(1) - 1; ++i)
            {
                cache = Matrix[i, first];
                Matrix[i, first] = Matrix[i, second];
                Matrix[i, second] = cache;
            }
            return Matrix;
        }
        static int[,] MatrixSub(int[,] Matrix, int[,] MatrixRandom)
        {

            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Matrix[j, i] = Matrix[j, i] - MatrixRandom[j, i];
                }
            }
            return Matrix;
        }
        static int[,] MatrixAdd(int[,] Matrix, int[,] MatrixRandom)
        {

            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Matrix[j, i] = Matrix[j, i] + MatrixRandom[j, i];
                }
            }
            return Matrix;
        }
        static int[,] MatrixTransposition(int[,] Matrix)
        {
            int[,] OutputMatrix = new int[Matrix.GetLength(1), Matrix.GetLength(0)];

            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    OutputMatrix[i, j] = Matrix[j, i];
                }
            }
            return Matrix;
        }
        static int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
        {
            //https://cs.wikipedia.org/wiki/N%C3%A1soben%C3%AD_matic
            //with help from chatGPT
            //Matrix1.x = Matrix2.y and vice versa
            int[,] OutputMatrix = new int[Matrix1.GetLength(1), Matrix2.GetLength(0)];
            int cache = 0;

            for (int i = 0; i < OutputMatrix.GetLength(1); ++i)
            {
                for (int j = 0; j < OutputMatrix.GetLength(0); ++j)
                {
                    for (int k = 0; k < Matrix1.GetLength(1); ++k)
                    {
                        cache += Matrix1[k, j] * Matrix2[j, k];
                    }
                    OutputMatrix[j, i] = cache;
                    cache = 0;

                }
            }

            return OutputMatrix;
        }

        static void Main(string[] args)
        {/*
            //1. excercise
            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.Write(MatrixPrint(MatrixFill(a, b)));
            Console.WriteLine("-------------------------");

            //2. excercise
            Console.WriteLine("x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Swap 2 elements");
            Console.WriteLine("-------------------------");
            Console.Write(MatrixPrint(MatrixElementSwap(MatrixFill(a, b), x1, y1, x2, y2)));
            Console.WriteLine("-------------------------");

            Console.WriteLine("Swap 2 columns");
            Console.WriteLine("-------------------------");
            Console.WriteLine("first column");
            int firstCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second column");
            int secondCol = Convert.ToInt32(Console.ReadLine());
            Console.Write(MatrixPrint(MatrixCollumSwap(MatrixFill(a, b), firstCol, secondCol)));
            Console.WriteLine("-------------------------");
            
            Console.WriteLine("first row");
            int firstRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second row");
            int secondRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Swap 2 rows");
            Console.WriteLine("-------------------------");
            Console.Write(MatrixPrint(MatrixLineSwap(MatrixFill(a, b), firstRow, secondRow)));
            Console.WriteLine("-------------------------");
            
            //4. excercise
            Console.WriteLine("Subtracts a randomly filled Matrix");
            Console.WriteLine("-------------------------");
            Console.Write(MatrixPrint(MatrixSub(MatrixFill(a, b),MatrixRandomFill(a,b))));
            Console.WriteLine("-------------------------");

            Console.WriteLine("Adds a randomly filled Matrix");
            Console.WriteLine("-------------------------");
            Console.Write(MatrixPrint(MatrixAdd(MatrixFill(a, b), MatrixRandomFill(a, b))));
            Console.WriteLine("-------------------------");
            //5. excercise
            Console.WriteLine("-------------------------");
            Console.WriteLine("Matrix transposition");
            Console.WriteLine("-------------------------");
            Console.Write(MatrixPrint(MatrixTransposition(MatrixFill(a, b))));
            Console.WriteLine("-------------------------");*/
            MatrixPrint(MatrixFill(3, 2));
            MatrixPrint(MatrixFill(2, 3));


            MatrixPrint(MatrixMultiplication(MatrixFill(3, 2), MatrixFill(2, 3))));
            Console.ReadKey();
        }
    }
}