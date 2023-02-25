double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(100 * new Random().NextDouble(), 0);
    }
    return result;
}

double MinMaxDif(double[] array)
{
    double min = array[0];
    double max = array[0];
    double size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = GetArray(size);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{String.Join("; ", array)}] равна {MinMaxDif(array)}.");
