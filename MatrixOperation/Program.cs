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
            //creates a matrix which's size is dictated by the input, and fills it with random integers from -a*b -1  to a*b -1
            int[,] Matrix = new int[a, b];
            Random rnd = new Random();

            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Matrix[j, i] = rnd.Next(-a * b, a * b - 1);
                }
            }
            return Matrix;
        }

        static void MatrixPrint(int[,] Matrix)
        {
            // Converts the Matrix to a string and Writes it to console
            string output = "";
            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    if (Matrix[j, i] < 10 && Matrix[j, i] > 0)
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
            //swaps two elements based on the x and y coordinates
            //coordinates start at 0
            int cache = Matrix[x1, y1];
            Matrix[x1, y1] = Matrix[x2, y2];
            Matrix[x2, y2] = cache;

            return Matrix;
        }

        static int[,] MatrixCollumSwap(int[,] Matrix, int first, int second)
        {
            //swaps two collums
            //labeling starts at 1
            int cache;
            for (int i = 0; i < Matrix.GetLength(1) - 1; ++i)
            {
                cache = Matrix[first - 1, i];
                Matrix[first - 1, i] = Matrix[second - 1, i];
                Matrix[second - 1, i] = cache;
            }
            return Matrix;
        }

        static int[,] MatrixLineSwap(int[,] Matrix, int first, int second)
        {
            //Swaps two lines
            //line labeling starts at 1
            int cache;
            for (int i = 0; i < Matrix.GetLength(1) - 1; ++i)
            {
                cache = Matrix[i, first - 1];
                Matrix[i, first - 1] = Matrix[i, second - 1];
                Matrix[i, second - 1] = cache;
            }
            return Matrix;
        }

        static int[,] MatrixSub(int[,] Matrix, int[,] MatrixRandom)
        {
            //subtracts two arrays from each other
            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Matrix[j, i] -= MatrixRandom[j, i];
                }
            }
            return Matrix;
        }

        static int[,] MatrixAdd(int[,] Matrix, int[,] MatrixRandom)
        {
            //adds a Randomly filled Matrix to a Matrix filled in ascending order
            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    Matrix[j, i] += MatrixRandom[j, i];
                }
            }
            return Matrix;
        }

        static int[,] MatrixTransposition(int[,] Matrix)
        {
            //flips all elments across the main diagonal
            int[,] OutputMatrix = new int[Matrix.GetLength(1), Matrix.GetLength(0)];

            for (int i = 0; i < Matrix.GetLength(1); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(0); ++j)
                {
                    OutputMatrix[i, j] = Matrix[j, i];
                }
            }
            return OutputMatrix;
        }

        static int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
        {
            //https://cs.wikipedia.org/wiki/N%C3%A1soben%C3%AD_matic
            //with help from chatGPT
            //Matrix1.x = Matrix2.y and vice versa = > dont need to verify thanks to how input is written
            //Should work TODO: Test and verify input

            int[,] OutputMatrix = new int[Matrix1.GetLength(1), Matrix2.GetLength(0)];
            int cache = 0;

            for (int i = 0; i < Matrix1.GetLength(1); i++)
            {
                //changes the y coordinate of computed cell
                for (int k = 0; k < Matrix2.GetLength(0); k++)
                {
                    //changes the x coordinate of computed cell
                    for (int j = 0; j < Matrix1.GetLength(0); ++j)
                    {
                        //computes a single cell of Output Matrix
                        cache += Matrix1[j, i] * Matrix2[k, j];
                    }
                    OutputMatrix[k, i] = cache;
                    cache = 0;
                }
            }
            return OutputMatrix;
        }

        static void Main(string[] args)
        {
            //1. excercise
            Console.WriteLine("Choose the size of the aray");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Size along the x axis");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Size along the y axis");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixFill(a, b));
            Console.WriteLine("-------------------------");
            /*
            //2. excercise
            Console.WriteLine("Swaps 2 elements of a Matrix filled in ascending order");
            Console.WriteLine("x coordinates start at 0 and go up to " + (a-1));
            Console.WriteLine("y coordinates start at 0 and go up to " + (b-1));
            Console.WriteLine("-------------------------");
            Console.WriteLine("x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixElementSwap(MatrixFill(a, b), x1, y1, x2, y2));
            Console.WriteLine("-------------------------");

            Console.WriteLine("Swaps 2 columns of a Matrix filled in ascending order");
            Console.WriteLine("numbering starts at 1 and goes up to " + a);
            Console.WriteLine("-------------------------");
            Console.WriteLine("first column");
            int firstCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second column ");
            int secondCol = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixCollumSwap(MatrixFill(a, b), firstCol, secondCol));
            Console.WriteLine("-------------------------");

            Console.WriteLine("Swaps 2 rows of a Matrix filled in ascending order ");
            Console.WriteLine("numbering starts at 1 and goes up to " + b);
            Console.WriteLine("-------------------------");
            Console.WriteLine("first row");
            int firstRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second row");
            int secondRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixLineSwap(MatrixFill(a, b), firstRow, secondRow));
            Console.WriteLine("-------------------------");
            */
            //4. excercise
            Console.WriteLine("Subtracts a randomly filled Matrix from a Matrix filled in ascending order");
            Console.WriteLine("-------------------------");
            int[,] RndMatrix = MatrixRandomFill(a, b);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Random matrix");
            MatrixPrint(RndMatrix);
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixSub(MatrixFill(a, b),RndMatrix));
            Console.WriteLine("-------------------------");

            Console.WriteLine("Adds a randomly filled Matrix from previous task to a Matrix filled in ascending order");
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixAdd(MatrixFill(a, b), RndMatrix));
            Console.WriteLine("-------------------------");
            //5. excercise
            Console.WriteLine("Matrix transposition");
            Console.WriteLine("Flips a Matrix filled in ascending order across the main diagonal");
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixTransposition(MatrixFill(a, b)));
            Console.WriteLine("-------------------------");
            //6.exercise
            Console.WriteLine("Multiplies a Matrix filled in ascending order with randomly filled array from previous task");
            Console.WriteLine("-------------------------");
            MatrixPrint(MatrixMultiplication(MatrixFill(a, b),RndMatrix));
            Console.WriteLine("-------------------------");
            
            Console.ReadKey();
        }
    }
}