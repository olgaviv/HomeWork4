// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

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
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int FindSum (int number)
{
  int sum = number % 10;
 

 
     while (number >= 10)
    {
      number = number/10;
        
       sum = sum + (number % 10); 
    } 
 

    return sum;
}

Console.Write("Input a number:" );
int a  = Convert.ToInt32(Console.ReadLine());



Console.WriteLine ($" Sum of number {a} is {FindSum(a)}");

*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int [8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;

    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i< count; i++)
    {
        
        Console.Write($"{array[i]} ");
        
    }
    

}
FillArray(array);
Console.Write($"[ ");
PrintArray(array);
Console.Write("] ");

