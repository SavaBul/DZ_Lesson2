﻿//Задача 13: Напишите программу, которая выводит третью цифру слева заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//3267912 -> 6

Console.Write("Введите числа : ");
int num = Convert.ToInt32(Console.ReadLine());

int index = 1;
int i = 0;               // счетчик количества цифр
int result = 0;

while (num > index)
{
    index = index * 10; // 1 умножаеться на 10 каждый раз пока  меньше num
    i++;                // считчик +1
}

if (i > 3)              // условия если количество цифр больше 3 то цикл 
{
    while (i > 3)
    {
        num = num / 10;
        result = num % 10;
        i--;
    }
}
else if (i < 3)          // если условия меньше 3 вывод
{
    Console.WriteLine("Нет третий цифры"); 
}
else                      // если все условия не выпольняються то остоток от деления на 10
{
    result = num % 10;

}

Console.WriteLine($"Результат {result}");










