double[] numbers = { 3, 7, 22, 2, 78 };

double min = numbers[0];
double max = numbers[0];

foreach (double number in numbers)
{
    if (number < min)
    {
        min = number;
    }

    if (number > max)
    {
        max = number;
    }
}

double difference = max - min;

Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница: " + difference);
