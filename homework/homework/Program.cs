using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintNumberInWords("5679");
            EnterAnyKeybordKey();
        }
        public static void PrintDigitInWord(char liczba)
        {

            switch (liczba)
            {
                case '0':
                    Console.WriteLine("zero");
                    break;
                case '1':
                    Console.WriteLine("jeden");
                    break;
                case '2':
                    Console.WriteLine("dwa");
                    break;
                case '3':
                    Console.WriteLine("trzy");
                    break;
                case '4':
                    Console.WriteLine("cztery");
                    break;
                case '5':
                    Console.WriteLine("piec");
                    break;
                case '6':
                    Console.WriteLine("szesc");
                    break;
                case '7':
                    Console.WriteLine("siedem");
                    break;
                case '8':
                    Console.WriteLine("osiem");
                    break;
                case '9':
                    Console.WriteLine("dziewiec");
                    break;
                default:
                    Console.WriteLine("Podano złą wartość");
                    break;
            }
        }

        public static void PrintNumberInWords(string liczba)
        {
            for (int i = 0; i < liczba.Length; i++)
            {
                PrintDigitInWord(liczba[i]);
            }
        }
        public static void EnterAnyKeybordKey()
        {
            Console.WriteLine("Please,enter any keybord key");
            char output = Console.ReadKey().KeyChar;

            while (output != 'Q' && output != 'q')
            {
                int ascii = output;
                Console.WriteLine();
                Console.WriteLine($"The ASCII value of {output} is {ascii}.");
                Console.WriteLine("Please,enter any keybord key");
                output = Console.ReadKey().KeyChar;


            }
            if (output == 'Q' || output == 'q')
            {
                Environment.Exit(0);
                //lub return;
            }
        }


    }
}

