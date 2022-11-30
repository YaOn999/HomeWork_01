Console.Clear();

Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int ThitdNumber = int.Parse(Console.ReadLine());

int max = FirstNumber;

if (max < SecondNumber) {
    max = SecondNumber;
    }
if (max < ThitdNumber) {
    max = ThitdNumber;
    }
Console.WriteLine($"Максимальное число {max}");
