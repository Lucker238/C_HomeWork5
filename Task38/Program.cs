// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

string showArray(double[] arr)
{
    return string.Join(", ", arr);
}

double[] makeArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

double findDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        else if(arr[i] < min) min = arr[i];   
    }
    return max - min;
}

System.Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] array = makeArray(length);
System.Console.WriteLine($"[{showArray(array)}]");
System.Console.WriteLine($"Разность максимального и минимального элементов равна: {findDiff(array)}");