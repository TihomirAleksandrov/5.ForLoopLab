using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int letterValue = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                switch (letter)
                {
                    case 'a':
                        letterValue += 1;
                        break;
                    case 'e':
                        letterValue += 2;
                        break;
                    case 'i':
                        letterValue += 3;
                        break;
                    case 'o':
                        letterValue += 4;
                        break;
                    case 'u':
                        letterValue += 5;
                        break;
                }
            }
            Console.WriteLine(letterValue);
        }
    }
}
