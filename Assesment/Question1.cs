using System;
using System.IO;

class Question1
{
    static void Main()
    {
        // Put all file names in root directory into array.
        string[] array1 = Directory.GetFiles(@"D:\\Amit");

        // Put all bin files in root directory into array.
        // ... This is case-insensitive.
        string[] array2 = Directory.GetFiles(@"D:\", "*.BIN");

        // Display all files.
        Console.WriteLine("--- Files: ---");
        foreach (string name in array1)
        {
            Console.WriteLine(name);
        }

        // Display all BIN files.
        Console.WriteLine("--- BIN Files: ---");
        foreach (string name in array2)
        {
            Console.WriteLine(name);
        }
    }