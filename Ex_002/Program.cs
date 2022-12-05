// Напишите программу, которая принимает на вход число и
// выдает сумму цифр в числе. Реализовать через функции.

int Hello(string message)                             // Метод вывода приглашения и ввода числа
{
    Console.Write(message);                          // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());      // Ввод числа
}

int Sum(int number)
{
   int sum = 0;
   for(int i = 1; i <= number; i ++)
   {
    sum += i; 
   }
    return sum;
}

int number = Hello("Введите число: ");
int sum = Sum(number);

Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");