Console.Clear();

Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());

if (SecondNumber < FirstNumber) {
    Console.WriteLine($"max = {FirstNumber}");
    }
    else {
    Console.WriteLine($"max = {SecondNumber}");
    }
