using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[8]; 

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        int[] arrayQuickSort = (int[])array.Clone();
        int[] arrayMergeSort = (int[])array.Clone();
        int[] arrayBubbleSort = (int[])array.Clone();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        QuickSort(arrayQuickSort, 0, arrayQuickSort.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("\nCzas sortowania szybkiego: " + stopwatch.Elapsed);
        PrintArray(arrayQuickSort);

        stopwatch.Restart();
        MergeSort(arrayMergeSort, 0, arrayMergeSort.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("\nCzas sortowania przez scalanie: " + stopwatch.Elapsed);
        PrintArray(arrayMergeSort);

        stopwatch.Restart();
        BubbleSort(arrayBubbleSort);
        stopwatch.Stop();
        Console.WriteLine("\nCzas sortowania bąbelkowego: " + stopwatch.Elapsed);
        PrintArray(arrayBubbleSort);
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);
            QuickSort(array, low, partitionIndex - 1);
            QuickSort(array, partitionIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, middle + 1, rightArray, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
