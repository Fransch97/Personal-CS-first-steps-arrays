using System;
using System.Collections;
using System.Collections.Generic;

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


            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\n\n\n\n");
            //the reverse of Stack
            Queue<int> queue = new Queue<int>(normarr);
            foreach (int x in queue)
            {
                Console.WriteLine(x);
            }


            //Enqueue is the Add
            
            queue.Enqueue(100);
            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }
            queue.Clear();

            if(queue.Count() < 0)
            {
            Console.WriteLine("nope");
            }
            else { Console.WriteLine("perfect"); }



            //sortedlist is like ((IT) arrayassociativo ) but sorted and needs to know the types

            SortedList<int, string> slist = new SortedList<int, string>();

            slist.Add(2, "primo inserimento");
            slist.Add(3, "secondo inserimento");
            slist.Add(1, "terzo inserimento");

            foreach(var x in slist)
            {
                Console.WriteLine($"Key: {x.Key} \nValue: {x.Value} \n\n");
            }

            //hashtable is like sortedlist (always sorted) but don't needs to know types
            Hashtable htable = new Hashtable();
            htable.Add("Key1", "sono il primo inserimento");
            htable.Add("Key49", "sono il sono inserimento");
            htable.Add("Key5", "sono il terzo inserimento");
            htable.Add("key100", "sono il quarto inserimento");
            Console.WriteLine("\n\n\n\n\n\n");
            //needs DictionaryEntry to let him know that "x" is a part of htable
            foreach (DictionaryEntry x in htable)
            {
                Console.WriteLine($"Key: {x.Key}\nValue: {x.Value}");
            }


            //hashtable by different key types he gonna order they by type 
            Hashtable htable1 = new Hashtable();
            htable1.Add("Key1", "sono il primo inserimento");
            htable1.Add(2, "sono il sono inserimento con un int come chiave");
            htable1.Add("Key5", "sono il terzo inserimento");
            htable1.Add(1, "sono il quarto inserimento con un int come chiave");
            Console.WriteLine("\n\n\n\n\n\n");
            
            foreach(DictionaryEntry x in htable1)
            {
                Console.WriteLine($"Key: {x.Key}\nValue: {x.Value}");
            }
        }
    }
}
