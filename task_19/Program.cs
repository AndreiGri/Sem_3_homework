﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();                                                                       /* Очищаем терминал.
                                                                                         Запрашиваем и вводим число */
Console.Write("Для определения палиндромности числа, введите пятизначное число: ");      
int pal = int.Parse(Console.ReadLine()!);                                                
int res = pal;                                                                         // Создаём переменную для записи введённого числа и дальнейших манипуляций с ним 
int []array = new int[5];                                                              // Создаём массив для записи в него цифр введённого числа 
int i;                                                                                 // Создаём переменную для дальнейшей записи в неё цифр числа 
int div = 10;                                                                          // Создаём переменную - делитель 

for(int j = 0; j < array.Length; j++)                                                  // Создаём цикл for со счётчиком j одновременно являющийся индексом массива
{
    if(res >= div)                                                                     // Условный оператор if 
    {                                                                                  //при котором вычисляется остаток 
        i = res % div;                                                                 //от деления числа, записываеся 
        array[j] = i;                                                                  //в массив и число делится на 10 
        res = res / div;                                                               //если число больше или равно 10 
    }                                                                                  //иначе просто записывается в массив.
    else
    {
        i = res;
        array[j] = i;
    }
}

if(array[0] == array[array.Length - 1] && array[1] == array[array.Length - 2])        //Сравниваем первую с последней цифры и вторую с предпоследней
{
    Console.Write($"Число {pal} является палиндромом.");                             //Если они равны выводим текст что число является палиндромом
}
else
{
    Console.Write($"Число {pal} не является палиндромом.");                          //Если они не равны выводим текст что число не является палиндромом
}
