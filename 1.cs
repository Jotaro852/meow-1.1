using System;
class meow11
{
  static void Main()
  {
    int[] numbers = new int[10]; // массив
    Random rand = new Random(); // объявляем генератор 
    
    Console.Write("Массив: "); // вывод инфы
    for (int i = 0; i < 10; i++)
    {
        numbers[i] = rand.Next(100); // заполняем массив
    }
    var str = string.Join(" ", numbers);
    Console.WriteLine(str);
    
    int min = 100; // переменная для минимального числа 
    for (int i = 0; i < 10; i++)
    {
        if (numbers[i] < min) // если n число из массива мньше минимального
        {
            min = numbers[i]; // записываем число в переменную
        }
    }
    Console.WriteLine($"минимальный элемент: {min}"); // вывод мин числа
  }
}