// Напишите цикл, который принимает на вход два числа
// (А и В) и возводит число А в натуральную степень В.
// Реализовать через функции.

int Hello(string message)                           // Метод вывода приглашения и ввода числа
{
    Console.Write(message);                  // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());     // Ввод числа
}

int Degree(int numberA, int numberB)
{
    int count = 1;
    int result = numberA;
    while(count < numberB)
    {
        result = result * numberA; 
        count++;
    }
    return result;
}

int numberA = Hello("Введите число А: ");
int numberB = Hello("Введите число B: ");
int result = Degree(numberA, numberB);

Console.WriteLine($"Если возвести число А = {numberA} в натуральную степень числа В = {numberB}, то получится = {result} ");