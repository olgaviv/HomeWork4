// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



int Stepen (int a, int b)
{
    int st = a;
    for (int current =1;  current<=b-1; current ++)
    st = st*a;
    return st;
}
Console.Write("Введите число: " );
int a  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: " );
int b  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Stepen (a,b));
