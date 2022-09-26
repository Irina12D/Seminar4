/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

Console.Write("Введите основание степени ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($"{x} в степени {y} = {F(x,y)}");

int F(int A, int B)
{
    int s = 1;
    for(int i=1; i<=B; i++)
        s*=A;
    return s;     
}
