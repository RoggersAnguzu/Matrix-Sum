using System;
namespace Matrix
{
    public class Mats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows and Columns of Matrices:");
            int Rows = Convert.ToInt32(Console.ReadLine());
            int Columns = Convert.ToInt32(Console.ReadLine());
            int[,] Matrix1 = new int[Rows, Columns];
            int[,] Matrix2 = new int[Rows, Columns];
            int[,] ResultMatrix = new int[Rows, Columns];
            //Enter Matrix 1 Elements
            Console.WriteLine("\nEnter the elements of the first Matrix: ");
            for(int i=0; i<Rows;i++)
            {
                for(int j = 0; j<Columns; j++)
                {
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            //Enter the Matrix 2 Elements
            Console.WriteLine("\nEnter the elements of the Second Matrix: ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nSum of both the Matrices:");
            for(int i =0; i<Rows; i++)
            {
                for(int j = 0; j<Columns; j++)
                {
                    ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    Console.Write($"{ResultMatrix[i, j]}");
                }
                Console.WriteLine("Please press the Enter button to Exit!");
            }
        }
    }
}