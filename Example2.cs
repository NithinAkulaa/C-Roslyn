
using System;
namespace LiteralsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            Console.WriteLine(vowels[1]);

            for (int i = 0; i < vowels.Length; i++)
                Console.WriteLine(vowels[i]);
        }
    }
}

string message = "Hi there";
string upperMess = message.ToUpper();
string lowerMess = message.ToLower();

int x = 2022;

Console.WriteLine(message + x.ToString());