internal class Program
{
    private static void Main()
    {
        var random = new Random();

        // 1. Создаём массив из 10 случайных чисел от 1 до 100
        var numbers = new int[10];
        for (var i = 0; i < numbers.Length; i++)
            numbers[i] = random.Next(1, 101); // верхняя граница не включается, поэтому 101

        // 2. Выводим массив с помощью цикла for
        Console.Write("Исходный массив: ");
        for (var i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");

        Console.WriteLine();

        // 3. Вычисляем среднее арифметическое
        var sum = 0;
        for (var i = 0; i < numbers.Length; i++) sum += numbers[i];

        var average = (double)sum / numbers.Length; // приводим к double, чтобы не потерять дробную часть
        Console.WriteLine($"Среднее арифметическое: {average:F2}");

        // 4. Считаем количество чисел больше среднего (for + if)
        var count = 0;
        for (var i = 0; i < numbers.Length; i++)
            if (numbers[i] > average)
                count++;

        Console.WriteLine($"Количество чисел больше среднего: {count}");

        // 5. Создаём новый массив только из чисел больше среднего
        var aboveAverage = new int[count];
        var index = 0;
        for (var i = 0; i < numbers.Length; i++)
            if (numbers[i] > average)
            {
                aboveAverage[index] = numbers[i];
                index++;
            }

        // 6. Выводим новый массив
        Console.Write("Числа больше среднего: ");
        for (var i = 0; i < aboveAverage.Length; i++) Console.Write(aboveAverage[i] + " ");

        Console.WriteLine();
    }
}