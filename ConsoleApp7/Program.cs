using System;

namespace pract5
{
    class Progra
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string words = Console.ReadLine();
            string tempword;
            int temp = 0;
            int count = 0;
            char[] nowords = new char[] { ' ', ',', '.', '!', '?' } ;

            foreach (var a in words.Split(nowords, StringSplitOptions.RemoveEmptyEntries))
            {
                temp++;
            }
            string[] arr = new string[temp];
            foreach (var a in words.Split(nowords, StringSplitOptions.RemoveEmptyEntries))
            {
                arr[count++] = a; 
            }

            Console.WriteLine();

            for (int i =0; i < arr.Length - 1;i++)
            {
                for (int j= 0; j < arr.Length - (1 + i);j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        tempword= arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tempword;
                    }
                }

            }
                for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }

        }
    }
}