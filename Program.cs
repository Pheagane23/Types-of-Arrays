using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2D arrays
            int[,] array = new int[4, 3];
            
            int evenNumber = 2;
            for (int row = 0;row < array.GetLength(0) ; row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = evenNumber;
                    evenNumber += 2;
                }
            }


            for (int row =0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col] + "");
                }
                Console.WriteLine();
            }
            #endregion

            #region Jagged arrays
            Console.WriteLine();
            Console.WriteLine("Jagged Arrays");
            string[] name1 = new string[] { "David", "Kabelo" };
            string[] name2 = new string[] { "Carol", "Kabelo", "James" };

            string[][] jagged = new string[][] { name1, name2 };

            string[] H_Kabelo = new string[] { "Tennis", "soccer" };
            string[] H_James = new string[] { "Soccer", "Hockey", "Reading" };
            string[] H_Carol = new string[3];

            string[][] jaggedHobbies = new string[4][];

            jaggedHobbies[0] = H_Kabelo;
            jaggedHobbies[1] = H_James;
            jaggedHobbies[2] = H_Carol;
            jaggedHobbies[3] = new string[] { "Swimming", "Rugby", "Chess" };

            //Carol is interested in Chess, Tennis, Hockey
            jaggedHobbies[2][0] = "Chess";
            jaggedHobbies[2][1] = "Tennis";
            jaggedHobbies[2][2] = "Hockey";

            jaggedHobbies[1][2] = "Rugby";

            // Displaying the jagged arrays
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("Names " + (i + 1) + ": ");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < jaggedHobbies.Length; i++)
            {
                Console.WriteLine("Hobbies " + (i + 1) + ": ");
                for (int j = 0; j < jaggedHobbies[i].Length; j++)
                {
                    Console.Write(jaggedHobbies[i][j] + " ");
                }
                Console.WriteLine();
            }
#endregion

            Console.Read();
        }
    }
}
