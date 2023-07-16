// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.


    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
    for (int i = 0; i < b; i++)
    {
        c = c * a;
    }
Console.WriteLine($"Число = {c} ");