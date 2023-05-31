//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();                                                              // Очищаем терминал

string NumCube(int n)                                                         // Создаём метод для вычисления
{                                                                             // кубов от чисел от 1 до N
    string text = " ";
    for(int i = 1; i <= n; i++)
    {
        if(i < n)
        {
            text = text + $"{Math.Pow(i, 3)}, ";
        }
        else
        {
            text = text + " " + $"{Math.Pow(i, 3)}.";
        }
        
    }
    return text;
}

Console.Write("Введите положительное целое число: ");                           // Запрашиваем и число
int num = int.Parse(Console.ReadLine()!);

Console.Write($"Кубами из чисел от 1 до {num} являются числа:{NumCube(num)}");  // Выводим результат в терминал