// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Укажите количество цифр для ввода");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите через запятую {size} отрицательных или положетельных чисел");
int [] array = Array.ConvertAll(Console.ReadLine().Split(","), int. Parse);
int count = 0;
for(int i = 0; i < size; i++)
{
 
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"[{String.Join(", ", array)}] -> {count}");