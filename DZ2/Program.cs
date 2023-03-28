//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a;
int b;
int c;

Console.WriteLine("Введите число 'a'");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите число 'b'");
int.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Введите число 'c'");
int.TryParse(Console.ReadLine(), out c);

int max = a;
{
  
  if (b > max) max = b;
  if (c > max) max = c;

}

Console.WriteLine(max);
