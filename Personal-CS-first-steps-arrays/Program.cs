using System;
using System.Collections;

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

            foreach (var x in array3D)
            {
                Console.WriteLine ((string)x);
            }

            //irregular array
            int[][] iregular = new int[2][];
            iregular[0] = new int[] { 1, 2, 3, 4 };
            iregular[1] = new int[] { 5, 6, 7 , 8 };


            //arraylist
            ArrayList first = new ArrayList();
            first.Add(2);
            Console.WriteLine(first[0]);
            //add bevore choosed index but must exist
            first.Insert(0,"ciaooooo");
            Console.WriteLine(first[0]);
            Console.WriteLine(first[1]);

            int[] normarr = {1,2,3,4,5,6};

            first.AddRange(normarr);
            foreach (var x in first)
            {
                Console.WriteLine("\n" + x);
            }

            first.InsertRange(0,normarr);

            foreach (var x in first)
            {
                Console.WriteLine(x);
            }

            first.Remove(null);

            foreach (var x in first)
            {
                Console.WriteLine("\n" + x);
            }
            Console.WriteLine("\n\n\n\n");

            first.RemoveAt(6);
            foreach (var x in first)
            {
                Console.WriteLine("\n" + x);
            }

            Console.WriteLine("\n\n\n\n");

            first.RemoveRange(0, 7);
            foreach (var x in first)
            {
                Console.WriteLine("\n" + x);
            }

            
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(first.Contains(3));

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\n\n\n\n");
            //stack <=> mazzo di carte l'ultima inserita è la prima
            Stack<int> stacker = new Stack<int>(normarr);

            foreach(int x in stacker)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n" + stacker.Peek());
            stacker.Clear();
            if(stacker.Count < 0)
            {
                Console.WriteLine("Franchi u was wrong");
            }
            else
            {
                Console.WriteLine("U are right man ;)");
                stacker.Push(1);
                Console.WriteLine("\n" + stacker.Contains(1));
            }






        }
    }
}
