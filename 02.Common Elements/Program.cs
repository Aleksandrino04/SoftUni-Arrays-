using System;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            foreach (string currElement in firstArr)
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    string secondCurElement = secondArr[i];
                    if (currElement == secondCurElement)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }

            
        }
    }
}