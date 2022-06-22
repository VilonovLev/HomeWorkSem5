// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arrayTask34 = CreateRandomArray(10,100,999);
PrintArray(arrayTask34);
PrintCountEvenNum(arrayTask34);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] arrayTask36 = CreateRandomArray(5,-100,100);
PrintArray(arrayTask36);
PrintSumOddElem(arrayTask36);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayTask38 = InitialArrRealNum(5);
PrintArrayDouble(arrayTask38);
double result = DiffMaxMinElm(arrayTask38);
Console.WriteLine($"Разница между Max и Min элементами массива: {result}");

//Методы
void PrintArray(int[] array)
{   
    string print = "[";
    for(int i = 0; i < array.Length; ++i)
    {
        if(i == array.Length - 1)
        {
            print += array[i];
            break;
        }
        print += array[i] + ", ";
    }
    Console.Write(print + "]\n");
}

void PrintArrayDouble(double[] array)
{   
    string print = "[";
    for(int i = 0; i < array.Length; ++i)
    {
        if(i == array.Length - 1)
        {
            print += array[i];
            break;
        }
        print += array[i] + " ";
    }
    Console.Write(print + "]\n");
}

int[] CreateRandomArray(int length, int start, int end)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; ++i)
    {
        array[i] = new Random().Next(start,end + 1);
    }
    return array;
}

void PrintCountEvenNum(int[] array)
{
    int evenNum = 0;
    for(int i = 0; i <array.Length; i++)
    {
        if(array[i] % 2 == 0)
        evenNum++;
    }
    Console.WriteLine($"Четных чисел в массиве: {evenNum}");
}

void PrintSumOddElem(int[] array)
{
    int sum = 0;
    for(int i = 1; i <array.Length; i += 2)
    {   
        sum += array[i];
    }
    Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях: {sum}");
}

double DiffMaxMinElm(double[] array)
{
    double max = array[0],
        min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}

double[] InitialArrRealNum(int length)
{
    double[] array = new double[length];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        string input = Console.ReadLine();
        array[i] = Convert.ToDouble(input);
    }
    return array;
}