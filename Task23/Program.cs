int num;
while (true)
{
    Console.Write("Введите число N: ");
    if (int.TryParse(Console.ReadLine(), out num))
        if (num > 0)
            break;
    Console.WriteLine("Ошибка ввода!");
}

int count = 1;
int res = 0;
MyMetod(num, count, res);
static void MyMetod(int num, int count, int res)
{
   while (count <= num)
   {
        res = count * count * count;
        if (count < num)
            Console.Write($"{res}, ");
        else
            Console.Write($"{res}");
        count++;
    }
}
