using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ArrayController : ControllerBase
{
    [HttpGet]
    public ActionResult<double[]> Get()
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

        return array;
    }

    [HttpGet("sum-odd-indexes")]
    public ActionResult<double> GetSumOddIndexes([FromQuery] int size = 10)
    {
        // Ваш код для вычисления суммы элементов с нечетными номерами
        // ...

        return 0; // Замените на реальный результат
    }

    [HttpGet("sum-between-negatives")]
    public ActionResult<double> GetSumBetweenNegatives([FromQuery] int size = 10)
    {
        // Ваш код для вычисления суммы элементов между первым и последним отрицательными элементами
        // ...

        return 0; // Замените на реальный результат
    }

    [HttpGet("compressed-array")]
    public ActionResult<double[]> GetCompressedArray([FromQuery] int size = 10)
    {
        // Ваш код для сжатия массива
        // ...

        return new double[size]; // Замените на реальный результат
    }
}
