//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int c = 0;
    int b = 0;
    while (a != 0)
    {
    c = a % 10;
    b = b + c;
    a = a / 10;
    }
Console.WriteLine(b);
