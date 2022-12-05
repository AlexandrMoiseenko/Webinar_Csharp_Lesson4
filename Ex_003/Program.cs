// Напишите программу, которая выводит массив из 8 элементов, заплоненный
// случайными числами. Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах). Реализовать через функции (Доп. сложность,
// введите количество элементов массива, введите минимальный порог случайных
// значений, введите максимальный порог случайных значений). Задача: напишите
// программу, которая из массива случайных чисел ищет второй максимум (число 
// меньше максимального элемента, но больше всех остальных).
// Сделать одним циклом.
// [1, 3, 5, 6, 6, 4] -> 5

int Hello(string message)                                                   // Метод вывода приглашения и ввода числа
{
    Console.Write(message);                          // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());      // Ввод числа
}

void FillArray (int[] array, int minValue, int maxValue)                    // Метод, который создает случайный массив
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
}

void PrintArray (int[] array)                                               // Метод, который печатает массив
{
     for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}      

int SecondMaxArray(int[] array)                               // Метод по нахождению второго max числа в массиве
{
int max = array[0];
int secondMax = array[0];       // 6 2 8 2 3 5 4 5

for(int i = 1; i < array.Length; i++)
{
     if(max < array[i])
     {
     secondMax = max;
     max = array[i];    
     }
     else if(array[i] != max && secondMax < array[i])
     {
        secondMax = array[i];
     }
}
    return secondMax;
}

int minValue = Hello("Введите минимальное значение массива: ");
int maxValue = Hello("Введите максимальное значение массива: ");

int[] array = new int[8];
FillArray(array, minValue, maxValue);

int sec = SecondMaxArray(array);

PrintArray(array);
Console.WriteLine($"Второе максимальное число в массиве равно {sec}");