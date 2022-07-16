using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //array normali
            string[] primo = { "uno", "due" , "tre", "quattro" };
            foreach (string x in primo)
            {
                Console.WriteLine(x + "\n");
            }

            int[] secondo = {1 , 2, 3}; 
            foreach (int x in secondo)
            {
                Console.WriteLine (x + "\n");
            }

            //array multidimensionali

            //2D
            string[,] array2d =
            {
                { "aaaa", "bbb" },
                { "ccc", "ddd" },
                { "eee", "fff" }
            };

            foreach(string x in array2d)
            {
                    Console.WriteLine((string)x);
            };



            //3D
            string[,,] array3D =
            {
                {   
                    {"xxx", "yyyy","eee" }
                },
            };

            foreach (string x in array3D)
            {
                Console.WriteLine ((string)x);
            }





        }
    }
}
