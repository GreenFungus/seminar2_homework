// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string getResult(int number) {
    if (number < 1 || number > 7) {
        return "Не корректное число, введите 1-7";
    } else {
        if (number < 6) {
            return "нет";
        } else {
            return "да";
        }
    }
}

Console.WriteLine("Введите день недели:");
int num = Convert.ToInt32(Console.ReadLine());
string result = getResult(num);
Console.WriteLine(result);
