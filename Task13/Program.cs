// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

string getResult(int number){
    string res = "";
    if (num < 100) {
        return "Третья цифра отсутствует";
    }
    while(num > 99) {
        if (num > 999) {        
            num = num / 10;
        } else {
            num = num % 10;
            res = $"Третья цифра {num}";
        }
    }
    return res;
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
string result = getResult(num);
Console.WriteLine(result);
