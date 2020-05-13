using System;

namespace OOP_lab_3_16_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    ++count;
                }
            }

            int[] letters = new int[1252];

            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    ++letters[(int)letter];
                }
            }

            Console.WriteLine("Kiлькiсть слiв, якi мають непарну довжину: {0}.\n\nЧастотa входження кожної лiтери:", count);

            for (int i = 0; i <= 1251; ++i)
            {
                if (letters[i] != 0)
                {
                    Console.WriteLine("{0} - {1}", (char)i, letters[i]);
                }
            }

        }
    }
}
