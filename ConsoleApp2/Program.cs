using System;

public class ArrayManipulator
{
    private Random random = new Random();

    public int[] GenerateRandomArray(int length, int min, int max)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    public int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayManipulator manipulator = new ArrayManipulator();


        int[] array = manipulator.GenerateRandomArray(10, 1, 100);
        Console.WriteLine("Generated Array:");
        PrintArray(array);


        int max = manipulator.FindMax(array);
        Console.WriteLine("\nMaximum Element: " + max);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}