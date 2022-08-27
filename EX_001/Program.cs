// Урок 6. Двумерные массивы и рекурсия
// На "5" с этого семинара нужно будет использовать "правильные" именования.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которое Вы введёте: ");
int M = Convert.ToInt32(Console.ReadLine());

int [] array = new int[M];

Console.WriteLine("Введите числа, отрицательные и положительные: ");
int count = 0;
for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
      
      if (array[i] < 0)
      count++;

}
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Отрицательных чисел: {count}");

