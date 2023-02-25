int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int OddSum(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 1; i < size; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, 10, 100);
Console.WriteLine($"Сумма элементов массива [{String.Join(";", array)}] на нечетных позициях равна {OddSum(array)}.");