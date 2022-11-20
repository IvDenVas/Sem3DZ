int number;
while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        if (number > 9999 && number <100000)
            break;
    Console.WriteLine("Ошибка ввода!");
}
MyMetod(number);
static void MyMetod(int number)
{
    if((number / 10000) == (number % 10) && ((number / 1000) % 10) == (number / 10) % 10)
        Console.WriteLine($"{number} -> да");
    else
        Console.WriteLine($"{number} -> нет");
}
