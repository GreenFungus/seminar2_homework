// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int GetNumber() {
    Console.Write("Введите трёхзначное число:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = GetNumber();
if (num < 100 || num > 999) {
    Console.WriteLine("Число не трехзначное");
    return;
}
Console.WriteLine($"Введенное число {num}");
int secondRank = num / 10 % 10;
Console.WriteLine($"Вторая цифра в этом числе {secondRank}");


