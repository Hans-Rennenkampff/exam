class Program
{
    static void Main()
    {
        Console.Clear();
        int[] arr = { 1, 2, 8, 23, 45, 67, 99, 123, 28 };
        PrintArrayReverse(arr, arr.Length - 1);
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{arr[index]} ");
            PrintArrayReverse(arr, index - 1);
        }
        else
        {
            Console.WriteLine(); // Added a line break for a more aesthetically pleasing appearance
        }
    }
}