using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize different primitives
            byte byteExample = 2;
            int intExample = 303;
            // As the compiler treats this as a double, if we want to type it as an integer
            // we must use 'f' as a sign of 'float' after the number
            float floatExample = 42.10f;
            // When declaring a character ('char') we must use single quotes
            char charExample = 'A';
            
            // A string isn't considered as a primitive in C# but for sake of clarity
            // here's an example how the compiler insist that strings are declared with double quotes
            string stringExam = "This is a string";
            
            Console.WriteLine("Byte: " + byteExample);
            Console.WriteLine("Integer: " + intExample);
            Console.WriteLine("Float: " + floatExample);
            Console.WriteLine("Char: " + charExample);
            Console.WriteLine("String: " + stringExam);
        }
    }
}