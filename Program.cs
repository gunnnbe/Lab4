using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int N = 10; // Замените на необходимый размер массива

        // Создаем массив и заполняем его случайными вещественными числами
        double[] array = new double[N];
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            array[i] = random.NextDouble() * 10; // Генерируем случайное вещественное число от 0 до 10
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Вычисляем сумму элементов с нечетными номерами
        double sumOddIndexes = 0;
        for (int i = 1; i < N; i += 2)
        {
            sumOddIndexes += array[i];
        }
        Console.WriteLine($"Сумма элементов с нечетными номерами: {sumOddIndexes}");

        // Находим первый и последний отрицательные элементы
        int firstNegativeIndex = -1;
        int lastNegativeIndex = -1;
        for (int i = 0; i < N; i++)
        {
            if (array[i] < 0)
            {
                if (firstNegativeIndex == -1)
                    firstNegativeIndex = i;
                lastNegativeIndex = i;
            }
        }

        // Вычисляем сумму элементов между первым и последним отрицательными элементами
        double sumBetweenNegatives = 0;
        if (firstNegativeIndex != -1 && lastNegativeIndex != -1)
        {
            for (int i = firstNegativeIndex + 1; i < lastNegativeIndex; i++)
            {
                sumBetweenNegatives += array[i];
            }
        }
        Console.WriteLine($"Сумма элементов между первым и последним отрицательными элементами: {sumBetweenNegatives}");

        // Сжимаем массив
        int newSize = 0;
        for (int i = 0; i < N; i++)
        {
            if (Math.Abs(array[i]) > 1)
            {
                array[newSize] = array[i];
                newSize++;
            }
        }

        // Заполняем освободившиеся элементы нулями
        for (int i = newSize; i < N; i++)
        {
            array[i] = 0;
        }

        // Выводим измененный массив
        Console.WriteLine("Измененный массив:");
        PrintArray(array);
    }

    // Метод для вывода массива на экран
    static void PrintArray(double[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}