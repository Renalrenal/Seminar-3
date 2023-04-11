int[] array = { 11, 2, 3, 6, 7, 8, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length ; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;

        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);